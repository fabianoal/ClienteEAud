using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using eAudStuffCSharp.Util;

namespace eAudStuffCSharp.EAudTypes.Query
{
    public class LinhaTarefa  {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("situacao")]
        public string Situacao { get; set; } 

        [JsonPropertyName("estado")]
        public string Estado { get; set; } 

        [JsonPropertyName("atividade")]
        public string Atividade { get; set; } 

        [JsonPropertyName("titulo")]
        public string Titulo { get; set; } 

        [JsonIgnore]
        public string TituloSanitizado => Util.TextFunctions.SanitizaTexto(Titulo);

        [JsonIgnore]
        public string TituloParaComparacao => Util.TextFunctions.PreparaTextoParaComparacao(Titulo);

        [JsonIgnore]
        private static Regex sufix = new Regex(".*\\[([A-Z]*)\\]$");


        [JsonIgnore]
        private static Regex prefix = new Regex("^\\[([A-Z]*)\\].*");

        [JsonIgnore]
        private static Regex regexunidade = new Regex("\\[[A-Z]*\\].*");

        [JsonIgnore]
        public bool HasSufixoUnidade => sufix.IsMatch(this.Titulo);

        [JsonIgnore]
        public bool HasPrefixoUnidade => prefix.IsMatch(this.Titulo);

        [JsonIgnore]
        public string UnidadeDoTitulo =>
                HasSufixoUnidade
                    ? sufix.Match(this.Titulo).Groups[1].Value
                    : HasPrefixoUnidade
                        ? prefix.Match(this.Titulo).Groups[1].Value
                        : null;

        [JsonIgnore]
        public string TituloSemSufixoOuPrefixo =>
            regexunidade.Replace(Titulo, "");

        
        [JsonIgnore]
        public string TituloSemSufixoOuPrefixoParaComparacao =>
            TextFunctions.PreparaTextoParaComparacao(TituloSemSufixoOuPrefixo);


        [JsonPropertyName("idTarefaAssociada")]
        public int? IdTarefaAssociada { get; set; } 

        [JsonPropertyName("tituloTarefaAssociada")]
        public string TituloTarefaAssociada { get; set; } 

        [JsonPropertyName("dtPrevisaoInicio")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? DtPrevisaoInicio { get; set; } 

        [JsonPropertyName("dtPrevisaoFim")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? DtPrevisaoFim { get; set; } 

        [JsonPropertyName("dtRealizadaInicio")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? DtRealizadaInicio { get; set; } 

        [JsonPropertyName("dtRealizadaFim")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? DtRealizadaFim { get; set; } 

        [JsonPropertyName("prioridade")]
        public string Prioridade { get; set; } 

        [JsonPropertyName("favorita")]
        public bool Favorita { get; set; } 

        [JsonPropertyName("tags")]
        public List<object> Tags { get; set; } 

        [JsonPropertyName("assunto")]
        public string Assunto { get; set; } 

        [JsonPropertyName("idAtividade")]
        public int? IdAtividade { get; set; } 

        [JsonPropertyName("descricaoAtividade")]
        public object DescricaoAtividade { get; set; } 

        [JsonPropertyName("idSituacao")]
        public int? IdSituacao { get; set; } 

        [JsonPropertyName("dataUltimaModificacao")]
        [JsonConverter(typeof(Util.DateTimeConverter))]
        public DateTime? DataUltimaModificacao { get; set; } 

        [JsonPropertyName("autorUltimaModificacao")]
        public string AutorUltimaModificacao { get; set; } 

        [JsonPropertyName("campos")]
        public object Campos { get; set; } 

        [JsonPropertyName("colunasPapel")]
        public object ColunasPapel { get; set; } 

        [JsonPropertyName("quantidade")]
        public object Quantidade { get; set; } 

        [JsonPropertyName("qtdTotalInteracoes")]
        public int QtdTotalInteracoes { get; set; } 

        [JsonPropertyName("interacoes")]
        public List<object> Interacoes { get; set; } 

        [JsonPropertyName("podeCompartilhar")]
        public object PodeCompartilhar { get; set; } 

        [JsonPropertyName("arquivoComportamentoEspecifico")]
        public string ArquivoComportamentoEspecifico { get; set; } 

        [JsonPropertyName("tarefaAssociada")]
        public object TarefaAssociada { get; set; } 

        [JsonPropertyName("papelPendencia")]
        public object PapelPendencia { get; set; } 

        [JsonPropertyName("mesConclusaoPrevisto")]
        public object MesConclusaoPrevisto { get; set; } 

        [JsonPropertyName("mesConclusaoRealizado")]
        public object MesConclusaoRealizado { get; set; } 

        [JsonPropertyName("nomePessoaPendencia")]
        public object NomePessoaPendencia { get; set; } 

        [JsonPropertyName("siglaUnidadePendencia")]
        public object SiglaUnidadePendencia { get; set; } 

        [JsonPropertyName("nomeEquipePendencia")]
        public object NomeEquipePendencia { get; set; } 

        [JsonPropertyName("sistema")]
        public object Sistema { get; set; } 

        [JsonPropertyName("usuarioPodeGerenciarAtividade")]
        public bool UsuarioPodeGerenciarAtividade { get; set; } 

        [JsonPropertyName("pendencias")]
        public List<Pendencia> Pendencias { get; set; } 

        [JsonPropertyName("mesAnoUltimaModificacao")]
        public string MesAnoUltimaModificacao { get; set; } 
    }
}
