using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text.Json;
using System.IO;
using Microsoft.AspNetCore.StaticFiles;

using eAudStuffCSharp.EAudTypes.Query;
using eAudStuffCSharp.EAudTypes.Post;
using eAudStuffCSharp.EAudTypes.Post.CamposPost;
using Serilog;

namespace eAudStuffCSharp {
    ///<summary>
    ///Contém funções que encapsulam chamadas para endpoints do e-Aud.
    ///</summary>
    public static class EAudFunctions {
        private static Regex Rx = new Regex(@"^\d{6,8}$");        
        static HttpClient client = null;

        ///<summary>
        ///Inicia o cliente. Esse processo basicamente obtém a variável de ambiente CHAVE_EAUD (ou CHAVE_EAUD_T se especificado o ambiente de treinamento) e 
        ///configura o header padrão para todas as chamdas HTTP com a chave de autenticação.
        ///</summary>
        public static void Init(string ambiente) {
            Log.Information("Iniciando client e-Aud. Ambiente : " + ambiente);
            client = new() { 
                BaseAddress = new Uri(ambiente.Equals("treinamento") ? "https://eaud-t.cgu.gov.br/api/auth/" :  "https://eaud.cgu.gov.br/api/auth/"), 
                Timeout = new TimeSpan(0, 7, 0) 
            };
            string chave = Environment.GetEnvironmentVariable(
                ambiente.Equals("treinamento") 
                ? "CHAVE_EAUD_T" 
                : ambiente.Equals("integrador") 
                    ?  "CHAVE_EAUD_INTEGRADOR" 
                    : "CHAVE_EAUD");
                    
            client.DefaultRequestHeaders.Add("chave-api", chave.Trim());
        }
        ///<summary>
        ///Essa função é uma função genérica que obtém entidades a partir de qualquer URL do e-Aud. Note que ela é uma função Geradora Assíncrona. Ela cuida
        ///dos aspectos de paginação do e-aud de forma transparente, de forma que o cliente pode atravessar a coleção resultante sem ter que se preocupar
        ///com isso.
        ///</summary>
        public static async IAsyncEnumerable<T> GetEntidades<T>(string uri, Dictionary<string, string> query, int skip = 0, int limit = 30, bool soPrimeiraPagina = false){
            int ultimoCount = 0;
            do {
                skip += ultimoCount;
                var newDict = new Dictionary<string, string>(){
                        {"tamanhoPagina", limit.ToString()},
                        {"offset", skip.ToString()}
                };
                string uriQuery = String.Join("?", uri, String.Join("&", (query?.Union(newDict) ?? newDict).Select(kv => String.Join("=", kv.Key, kv.Value))));
                Log.Information($"Obtendo {uriQuery}");
                QueryTarefasContainer<T> result = await client.GetFromJsonAsync<QueryTarefasContainer<T>>(uriQuery);
                ultimoCount = result.Data.Count();
                foreach (T t in result.Data) yield return t;
            } while (ultimoCount == limit && !soPrimeiraPagina);
        }

        ///<summary>
        ///É basicamente a <c>GetEntidades<t>()</c> porém é preparada para alguns endpoints que não empacotam o resultado num objeto, ou seja, o retorno da API já é a lista de objetos direta. 
        ///Como exemplo, podemos citar o endpoint "tarefa/<idTarefa>/interacao/listar"
        ///</summary>
        public static async IAsyncEnumerable<T> GetEntidadesSemQueryContainer<T>(string uri, Dictionary<string, string> query, int skip = 0, int limit = 30, bool soPrimeiraPagina = false){
            int ultimoCount = 0;
            do {
                skip += ultimoCount;
                var newDict = new Dictionary<string, string>(){
                        {"tamanhoPagina", limit.ToString()},
                        {"offset", skip.ToString()}
                };
                string uriQuery = String.Join("?", uri, String.Join("&", query.Union(newDict).Select(kv => String.Join("=", kv.Key, kv.Value))));
                Log.Information($"Obtendo {uriQuery}");
                T[] result = await client.GetFromJsonAsync<T[]>(uriQuery);
                ultimoCount = result.Count();
                foreach (T t in result) yield return t;
            } while (ultimoCount == limit && !soPrimeiraPagina);
        }

        ///<summary>
        ///Nessa função, retorna-se as páginas de dados obtidas, de acordo com o que foi requerido pelo parâmetro <c>limit</c>. Assim,
        ///em situações onde é desejável lidar com páginas de entidades, essa função poderá ser utilizada. Adicionalmente, ela tem
        ///mecanismos para tratar erros e aguardar um tempo. Assim, em extrações longas, pode-se usar essa função pois ela irá tentar 
        ///obter cada página por 20 vezes, com um intervalo de 1 minuto entre cada requisição. Para que isso funcione corretamente,
        ///é recomendável informar um campo para ordenar os resutlados.
        ///</summary>
        public static async Task<IEnumerable<T[]>> GetEntidadesPaginada<T>(string uri, Dictionary<string, string> query, int skip = 0, int limit = 30, bool soPrimeiraPagina = false){
            int ultimoCount = 0;
            List<T[]> resultado = new List<T[]>();
            do {
                skip += ultimoCount;
                var newDict = new Dictionary<string, string>(){
                        {"tamanhoPagina", limit.ToString()},
                        {"offset", skip.ToString()}
                };
                string uriQuery = String.Join("?", uri, String.Join("&", query.Union(newDict).Select(kv => String.Join("=", kv.Key, kv.Value))));
                
                int numTentativas = 1;
                QueryTarefasContainer<T> result = null;
                do {
                    try {
                        Log.Information($"Tentativa {numTentativas} p obter {uriQuery}");
                        result = await client.GetFromJsonAsync<QueryTarefasContainer<T>>(uriQuery);
                    }catch (Exception e){
                        if (numTentativas == 20){
                            throw new Exception($"Erro Obtendo {uriQuery}, Tentativas {numTentativas}. Desistindo...", e);
                        } else {
                            Log.Information(e.Message);
                            Log.Information(e.InnerException?.Message ?? "Não há innerException");
                            System.Threading.Thread.Sleep(60000 * numTentativas);
                            numTentativas++;
                        }
                    }
                } while (numTentativas < 21 && result == null);

                ultimoCount = result.Data.Count();
                resultado.Add(result.Data.ToArray());
            } while (ultimoCount == limit && !soPrimeiraPagina);
            return resultado;
        }

        ///<summary>
        ///Obtém as unidades vinculadas ao órgão informado no parâmetro.
        ///</summary>
        public static async IAsyncEnumerable<LinhaUnidade> GetUnidades(int idOrgao = 4185){
            Dictionary<string, string> dParms = new Dictionary<string, string>(){
                    {"colunaOrdenacao", "ID"},
                    {"direcaoOrdenacao", "ASC"},
                    {"apenasUnidadesLotacao", "false"},
                    {"idsUnidadesOrgao", idOrgao.ToString()}
                };
                
            await foreach (LinhaUnidade li in EAudFunctions.GetEntidades<LinhaUnidade>("unidade", dParms, 0 , 100))
                yield return li;
        }

        ///<summary>
        ///Método genérico para postar entidades com suporte para até 20 tentativas no caso de erro.
        ///</summary>
        public static async Task<string> PostEntidade<T>(string uri, T entidade, int tentativa = 1){
            HttpResponseMessage result;
            try {
                result = await client.PostAsJsonAsync<T>(uri, entidade);
            }catch (Exception e){
                if (tentativa == 20){
                    Log.Information($"Erro postando entidade na url {uri}, tentativa {tentativa}. Desistindo...");
                    throw new Exception($"Erro postando entidade na url {uri}, tentativa {tentativa}. Desistindo...", e);
                } else {
                    Log.Information($"Erro postando entidade na url {uri}, tentativa {tentativa}");
                    System.Threading.Thread.Sleep(60000 * tentativa);
                    return await PostEntidade<T>(uri, entidade, tentativa + 1);
                }
            }
            var conteudo = await result.Content.ReadAsStringAsync();
            if (result.IsSuccessStatusCode)
                return conteudo;
            else{
                Log.Error($"Erro HTTP {result.StatusCode} postando objeto em {uri}");
                Log.Error(conteudo);
                throw new Exception($"Erro HTTP {result.StatusCode} postando objeto em {uri}");
            }
        }


        ///<summary>
        ///Alguns endpoints não documentados do e-aud usam o padrão Form ao invés do padrão JSON. Esse método transforma um dicionário
        ///em um post do tipo form.
        ///</summary>
        public static async Task<string> PostForm(string uri, IEnumerable<KeyValuePair<string, string>> form, int tentativa = 1){
            try {

                FormUrlEncodedContent content = new FormUrlEncodedContent(form);
                return await  (await client.PostAsync(uri, content)).Content.ReadAsStringAsync();
            }catch (Exception e){
                if (tentativa == 20){
                    Log.Information($"Erro postando entidade na url {uri}, tentativa {tentativa}. Desistindo...");
                    throw new Exception($"Erro postando entidade na url {uri}, tentativa {tentativa}. Desistindo...", e);
                } else {
                    Log.Information($"Erro postando entidade na url {uri}, tentativa {tentativa}");
                    System.Threading.Thread.Sleep(60000 * tentativa);
                    return await PostForm(uri, form, tentativa + 1);
                }
            }
        }

        ///<summary>
        ///Esse método deve ser usado sempre que se precise postar arquivos no e-aud. Os dados retornados por esse método
        ///podem ser usados para preencher um campo de arquivos no contexto de uma tarefa ou uma interação.
        ///</summary>
        public static async Task<IEnumerable<EAudTypes.Query.Campos.CampoArquivo>> PostArquivos(int idCampo, IEnumerable<string> arquivos, string pastaBase){
            var retorno = new List<EAudTypes.Query.Campos.CampoArquivo>();
            foreach (string arquivo in arquivos)
            {
                Log.Information($"Postando arquivo {pastaBase + "/" + arquivo}");
                using (var content = new MultipartFormDataContent())
                {
                    string contentType = null;
                    new FileExtensionContentTypeProvider().TryGetContentType(pastaBase + "/" + arquivo, out contentType);
                    if (string.IsNullOrEmpty(contentType))
                        contentType = "application/octet-stream";

                    using (var streamArquivo = File.OpenRead(pastaBase + "/" + arquivo)){
                        //streamArquivo.CopyTo(memoryStreamArquivo);
                        var streamContent = new StreamContent(streamArquivo);
                        streamContent.Headers.ContentType = MediaTypeHeaderValue.Parse(contentType);
                        await streamContent.LoadIntoBufferAsync();
                        content.Add(new StringContent(idCampo.ToString()), "idCampo");
                        content.Add(streamContent, $"upload{idCampo}", arquivo);
                        var resultadoChamada = await client.PostAsync("arquivo/novo", content);
                        if (resultadoChamada.IsSuccessStatusCode){
                            var campoArquivo = await resultadoChamada.Content.ReadFromJsonAsync<EAudTypes.Query.Campos.CampoArquivo>();
                            Log.Information($"Arquivo postado com sucesso. Id: {campoArquivo.Id}");
                            retorno.Add(campoArquivo);
                        } else {
                            throw new Exception($"Erro fazendo upload do arquivo {arquivo}. Mensagem: {await resultadoChamada.Content.ReadAsStringAsync()}");
                        }
                    }
                }
            }
            return retorno;
        }

        ///<summary>
        ///Método específico para postar entidades do tipo tarefa. No e-aud, isso corresponde a criar uma nova tarefa.
        ///</summary>
        public static async Task<EAudTypes.Post.TarefaPost<T>> PostaTarefa<T>(EAudTypes.Post.TarefaPost<T> tarefa){
            string result = await EAudFunctions.PostEntidade("tarefa/salvar", tarefa);
            if (Rx.IsMatch(result)){
                Log.Information($"Tarefa {result} criada");
                tarefa.IdTarefaGerada = int.Parse(result);
                return tarefa;
            } else {
                Log.Error(result);
                throw new Exception($"Erro criando tarefa da atividade {tarefa.CodigoAtividade}.");
            }
        }

        ///<summary>
        ///Método específico para postar entidades do tipo interacao. No e-aud, isso corresponde a executar uma interação no contexto de uma tarefa.
        ///</summary>
        public static async Task<object> PostaInteracao<T>(EAudTypes.Post.InteracaoPost<T> interacao){
            //Log.Information($"Postando Programa {tarefaPost.Campos.Titulo}");
            //File.WriteAllText(Util.Constantes.DIR_DADOS + $"/InteracoesOrcamento/{interacao.IdsTarefas[0]}_{interacao.IdTipoInteracao}.json", JsonSerializer.Serialize(interacao, Confs.JsonSerializerOptions));
            string result = await EAudFunctions.PostEntidade("tarefa/interacao/registrar", interacao);

            if (result.StartsWith("{")) {
                Log.Information("Interação postada com sucesso.");
                // Log.Information(result);
                return JsonSerializer.Deserialize<object>(result, Confs.JsonSerializerOptions);
            } else {
                Log.Error($"Erro postando interação {interacao.IdTipoInteracao} para tarefa(s) [{String.Join(',', interacao.IdsTarefas)}]");
                Log.Error(result);
                throw new Exception($"Erro postando interação {interacao.IdTipoInteracao} para tarefa(s) [{String.Join(',', interacao.IdsTarefas)}]");
            }
        }

        ///<summary>
        ///Essa função é uma função genérica para postar uma entidade qualquer e obter um retorno tipado. Assim, ela requer dois parâmetros de tipo: T
        ///que é o parâmetro que define o tipo que será postado, e Z que é o parâmetro que define o tipo que será retornado. A função cuida de desserializar
        ///a resposta no tipo Z.
        ///</summary>
        public static async Task<Z> PostEntidade<T, Z>(string uri, T entidade, int tentativa = 1){
            try {
                return await (await client.PostAsJsonAsync<T>(uri, entidade)).Content.ReadFromJsonAsync<Z>();
            }catch (Exception e){
                if (tentativa == 20){
                    Log.Information($"Erro postando entidade na url {uri}, tentativa {tentativa}. Desistindo...");
                    throw new Exception($"Erro postando entidade na url {uri}, tentativa {tentativa}. Desistindo...", e);
                } else {
                    Log.Information($"Erro postando entidade na url {uri}, tentativa {tentativa}");
                    System.Threading.Thread.Sleep(60000 * tentativa);
                    return await PostEntidade<T, Z>(uri, entidade, tentativa + 1);
                }
            }
        }

        ///<summary>
        ///Função utilitária para obter uma lista de tarefas resumida. Por padrão, seleciona as seguintes colunas:
        ///<list type="bulet">
        ///<item><description>id</description></item>
        ///<item><description>situacao</description></item>
        ///<item><description>estado</description></item>
        ///<item><description>idEstado</description></item>
        ///<item><description>titulo</description></item>
        ///<item><description>idAtividade</description></item>
        ///<item><description>idSituacao</description></item>
        ///<item><description>idTarefaAssociada</description></item>
        ///<item><description>tituloTarefaAssociada</description></item>
        ///<item><description>dataUltimaModificacao</description></item>
        ///<item><description>autorUltimaModificacao</description></item>
        ///<item><description>dataRealizadaInicio</description></item>
        ///<item><description>dataRealizadaFim</description></item>
        ///</list>
        ///Cabe lembrar que o parâmetro "apenasExcluidas" só funciona para tarefas que estejam em uma situação do tipo "exclusão". Tarefas deletadas do banco de dados através
        ///da interação padrão "Excluir" nunca são retornadas.
        ///</summary>
        public static async IAsyncEnumerable<LinhaTarefa> GetTarefasDeAtividadeResumida(string idAtividade, DateTime? dataInteracaoInicial = new Nullable<DateTime>(),  bool soPrimeiraPagina = false, bool apenasExcluidas = false){
            Dictionary<string, string> dParms = new Dictionary<string, string>(){
                {"colunaOrdenacao", "dataInteracaoInicial"},
                {"atividades", idAtividade},
                {"direcaoOrdenacao", "ASC"},
                {"exibirColunaPendencias", "true"},
                {"apenasModificadasNosUltimos30Dias", "false"},
                {"apenasAbertas", "false"},
                {"colunasSelecionadas", "id,situacao,estado,idEstado,titulo,idAtividade,idSituacao,idTarefaAssociada,tituloTarefaAssociada,dataUltimaModificacao,autorUltimaModificacao,dataRealizadaInicio,dataRealizadaFim"}
            };

            if (dataInteracaoInicial.HasValue) {
                dParms.Add("dataInteracaoInicial", dataInteracaoInicial.Value.ToString("yyyy-MM-dd"));
                //dParms.Add("horaInteracaoInicial", dataInteracaoInicial.Value.ToString("hh:mm"));
            }
            if (apenasExcluidas) dParms.Add("apenasExcluidas", "true");

            await foreach (LinhaTarefa lt in EAudFunctions.GetEntidades<LinhaTarefa>("tarefa", dParms, 0 , 50, soPrimeiraPagina))
                yield return lt;
        }

        ///<summary>
        ///Similar à função <c>GetTarefasDeAtividadeResumida</c>, porém filtrando somente tarefas com pendência.
        ///</summary>
        public static async IAsyncEnumerable<LinhaTarefa> GetTarefasDeAtividadeResumidaComPendencia(string idAtividade,  Dictionary<string, string> filtrosAdicionais = null, bool pendenciasParaUsuarioLogado = false, int skip = 0){
            Dictionary<string, string> dParms = new Dictionary<string, string>(){
                {"colunaOrdenacao", "id"},
                {"atividades", idAtividade},
                {"direcaoOrdenacao", "ASC"},
                {"exibirColunaPendencias", "true"},
                {"apenasModificadasNosUltimos30Dias", "false"},
                {"apenasAbertas", "false"},
                {"colunasSelecionadas", "id,situacao,estado,idEstado,titulo,idAtividade,idSituacao,idTarefaAssociada,tituloTarefaAssociada,dataUltimaModificacao,autorUltimaModificacao,dataRealizadaInicio,dataRealizadaFim"}
                
            };

            if (pendenciasParaUsuarioLogado) dParms.Add("pendenciasParaUsuarioLogado", "true");
            
            if (filtrosAdicionais != null)
                foreach(var filtroAdicional in filtrosAdicionais)
                    dParms.Add(filtroAdicional.Key, filtroAdicional.Value);

            
            await foreach (LinhaTarefa lt in EAudFunctions.GetEntidades<LinhaTarefa>("tarefa", dParms, skip, 20, false))
                yield return lt;
        }

        ///<summary>
        ///Similar à função <c>GetTarefasDeAtividadeResumida</c>, porém retorna resultados paginados.
        ///</summary>
        public static async Task<IEnumerable<LinhaTarefa[]>> GetTarefasDeAtividadeResumidaPaginada(string idAtividade, DateTime? dataInteracaoInicial,  bool soPrimeiraPagina = false, bool apenasExcluidas = false, int tamanhoPagina = 50, int skip = 0, string situacoes = null, string estados = null){
            Dictionary<string, string> dParms = new Dictionary<string, string>(){
                {"colunaOrdenacao", "id"},
                {"atividades", idAtividade},
                {"direcaoOrdenacao", "ASC"},
                {"exibirColunaPendencias", "true"},
                {"apenasModificadasNosUltimos30Dias", "false"},
                {"apenasAbertas", "false"},
                {"colunasSelecionadas", "id,situacao,titulo,idAtividade,idSituacao"}
            };

            if (!String.IsNullOrEmpty(situacoes))
                dParms.Add("situacoes", situacoes);

            if (!String.IsNullOrEmpty(estados))
                dParms.Add("estados", estados);

            if (dataInteracaoInicial.HasValue && dataInteracaoInicial.Value.Year > 1970) {
                dParms.Add("dataInteracaoInicial", dataInteracaoInicial.Value.ToString("yyyy-MM-dd"));
                //dParms.Add("horaInteracaoInicial", dataInteracaoInicial.Value.ToString("hh:mm"));
            }
            if (apenasExcluidas) dParms.Add("apenasExcluidas", "true");

            return await EAudFunctions.GetEntidadesPaginada<LinhaTarefa>("tarefa", dParms, skip , tamanhoPagina, soPrimeiraPagina);
        }

        ///<summary>
        ///Retorna a lista de tarefas filhas da tarefa informada no parâmetro idTarefaAssociada
        ///</summary>
        public static async Task<LinhaTarefa[]> GetTarefasAssociadas(int idTarefaAssociada){
            Dictionary<string, string> dParms = new Dictionary<string, string>(){
                {"colunaOrdenacao", "id"},
                {"idTarefaAssociada", idTarefaAssociada.ToString()},
                {"direcaoOrdenacao", "ASC"},
                {"apenasModificadasNosUltimos30Dias", "false"},
                {"apenasAbertas", "false"},
                {"exibirColunaPendencias", "true"}
            };
            var lts = new List<LinhaTarefa>();
            await foreach (LinhaTarefa lt in EAudFunctions.GetEntidades<LinhaTarefa>("tarefa/tarefasAssociadas", dParms, 0 , 20, false))
                lts.Add(lt);
            return lts.ToArray();
        }

        ///<summary>
        ///Similar à função <c>GetTarefasDeAtividadeResumida</c>. Entretanto, ela retorna a lista de tarefas detalhada, o que requer uma chamada
        ///à API para cada tarefa, ou seja, trata-se de uma função que deve ser usada com extrema moderação e sua execução será bastante lenta.
        ///</summary>
        public static async IAsyncEnumerable<Tarefa<T>> GetTarefasDeAtividadeDetalhada<T>(string idAtividade, DateTime dataInteracaoInicial, bool soPrimeiraPagina = false){
            await foreach (LinhaTarefa lt in EAudFunctions.GetTarefasDeAtividadeResumida(idAtividade, dataInteracaoInicial, soPrimeiraPagina))
            {
                Log.Information($"Obtendo tarefa {lt.Id}");
                yield return await GetTarefaDetalhada<T>(lt.Id);
            }
        }

        ///<summary>
        ///Similar à função <c>GetTarefasDeAtividadeResumida</c>, porém, por usar os endpoints específicos do assunto Plano Operacional, retorna linhas mais
        ///ricas em termos de detalhes do plano operacional sem precisar detalhar cada plano.
        ///</summary>

        public static async IAsyncEnumerable<LinhaPlanoOperacional> GetProgramas(bool soPrimeiraPagina = false, string pactuacaoPoBase = "2"){
            Dictionary<string, string> dParms = new Dictionary<string, string>(){
                {"colunaOrdenacao", "id"},
                {"atividades", "93"},
                {"direcaoOrdenacao", "DESC"},
                {"exibirColunaPendencias", "true"},
                {"apenasModificadasNosUltimos30Dias", "false"},
                {"pactuacoesPO", pactuacaoPoBase},
                {"colunasSelecionadas", "id,situacao,titulo,pactuacaoPO,totalOrcamento,totalHomemHoraAlocado,estado"}
            };

            await foreach (LinhaPlanoOperacional lt in EAudFunctions.GetEntidades<LinhaPlanoOperacional>("planejamento/planooperacional", dParms, 0 , 20, soPrimeiraPagina))
                yield return lt;
        }

        ///<summary>
        ///Função genérica para obter uma entidade qualquer do sistema cujo tipo é especificado pelo parâmetro de tipo T.
        ///</summary>
        public static async Task<T> GetEntidade<T>(string uri) =>
            await client.GetFromJsonAsync<T>(uri);

        ///<summary>
        ///Função específica para obter uma tarefa detalhada. Note que o tipo que represente os campos da tarefa deverá ser informado.
        ///</summary>
        public static async Task<Tarefa<T>> GetTarefaDetalhada<T>(int id) => 
            await client.GetFromJsonAsync<Tarefa<T>>($"tarefa/{id}/dto/json");

        ///<summary>
        ///Função específica para obter as definições de um campo.
        ///</summary>
        public static async Task<EAudTypes.Query.Campos.CampoConfiguracao> GetCampo(int id) =>
            (await client.GetFromJsonAsync<EAudTypes.Query.Campos.CampoConfiguracao[]>($"campo/{id}")).FirstOrDefault();

    }
} 