using System;
using System.Linq;
using System.Collections.Generic;
using eAudStuffCSharp.EAudTypes.Query.Campos;
using eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares;

namespace eAudStuffCSharp.Util
{
    public class TabelaUtils 
    {
        public static object[] GetConfiguracaoInstanciaTabela(CampoConfiguracao configuracaoTabela) =>
            configuracaoTabela.ColunasFormatoTabela.Select(x => 
                    new {
                        id = x.Id,
                        alias = $"coluna_{x.Id}",
                        dominioCampoLista = x.DominioListaFormatoTabela,
                        entidadeReferenciada = x.EntidadeReferenciada,
                        exibirSomatorio = x.ExibirSomatorio,
                        formato = x.Formato,
                        html = $"<th>{x.Nome}</th>",
                        mascara = x.Mascara,
                        nome = x.Nome,
                        obrigatorio = x.Obrigatorio,
                        valor = string.IsNullOrEmpty(x.Valor) ? "" : x.Valor,
                        somenteLeitura = x.SomenteLeitura,
                        valorMaximo = x.ValorMaximo
                    })
            .Union(new object[] {
                new  {
                    alias = "colunaAcao",
                    id = -1,
                    html = "<th>Ações</th>",
                    valor = "",
                    nome = "Ações",
                    formato = new Nullable<int>()
                }
            })
            .ToArray();

        public static CelulaTabela[][] FromValorTabela(EAudTypes.Query.ClassesAuxiliares.ValorTabela valorTabela, ConfigCampoTabela[] configuracaoAlvo, bool tabelaNova, Func<Dictionary<string, EAudTypes.Query.ClassesAuxiliares.CelulaTabela>, bool> filtro) =>
            valorTabela.Dados
            .Where(filtro)
            .Select((x, i) => 
                // Crio a primeiraa célula da tabela (a colunaAcao)
                (new CelulaTabela[] { new CelulaTabela() { 
                    Valor = i + 1, 
                    Nova = tabelaNova 
                        /*
                        // Se a tabela é nova, todas as linhas serão novas.
                        ? true 
                        : x.Any(cell => cell.Key.Equals("colunaAcao")) 
                            //Se a tabela não é nova, procuro uma célula colunaAcao. Se encontro, uso o .Nova. 
                            ? x.FirstOrDefault(cell => cell.Key.Equals("colunaAcao")).Value.Nova 
                            // Caso contrário, é linha nova em tabela existente.
                            : true */
                }})
                // Junto com todas as células já existentes
                .Union(x
                    .Where(cell => !cell.Key.Equals("colunaAcao") && valorTabela.ConfiguracaoColunas.Any(vc => vc.Id == cell.Value.Id))
                    .Select(cell => cell.Value))
                // Adiciono células novas que a configuracao destino tem e que não estão na configuracao origem
                .Union(
                    configuracaoAlvo
                    .Where(c => !valorTabela.ConfiguracaoColunas.Any(vc => vc.Id.Equals(c.Id)))
                    .Select(c => new CelulaTabela() {
                        Id = c.Id,
                        Valor = null,
                        Descricao = null,
                    }))
                .ToArray()
            ).ToArray();

    }
}