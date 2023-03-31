using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.Campos;

namespace eAudStuffCSharp.EAudTypes.Query
{
    public class Tarefa<T>    {
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
        public string TituloSanitizado =>
            Util.TextFunctions.SanitizaTexto(Titulo);

        [JsonPropertyName("idTarefaAssociada")]
        public int? IdTarefaAssociada { get; set; } 

        [JsonPropertyName("tituloTarefaAssociada")]
        public string TituloTarefaAssociada { get; set; } 

        [JsonPropertyName("dtPrevisaoInicio")]
        [JsonConverter(typeof(Util.DateTimeConverter))]
        public DateTime? DtPrevisaoInicio { get; set; } 

        [JsonPropertyName("dtPrevisaoFim")]
        [JsonConverter(typeof(Util.DateTimeConverter))]
        public DateTime? DtPrevisaoFim { get; set; } 

        [JsonPropertyName("dtRealizadaInicio")]
        [JsonConverter(typeof(Util.DateTimeConverter))]
        public DateTime? DtRealizadaInicio { get; set; } 

        [JsonPropertyName("dtRealizadaFim")]
        [JsonConverter(typeof(Util.DateTimeConverter))]
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
        public string DescricaoAtividade { get; set; } 

        [JsonPropertyName("idSituacao")]
        public int IdSituacao { get; set; } 

        [JsonPropertyName("dataUltimaModificacao")]
        [JsonConverter(typeof(Util.DateTimeConverter))]
        public DateTime? DataUltimaModificacao { get; set; } 

        [JsonPropertyName("autorUltimaModificacao")]
        public string AutorUltimaModificacao { get; set; } 

        [JsonPropertyName("campos")]
        public T Campos { get; set; } 

        [JsonPropertyName("colunasPapel")]
        public object ColunasPapel { get; set; } 

        [JsonPropertyName("quantidade")]
        public int Quantidade { get; set; } 

        [JsonPropertyName("qtdTotalInteracoes")]
        public int QtdTotalInteracoes { get; set; } 

        [JsonPropertyName("interacoes")]
        public List<object> Interacoes { get; set; } 

        [JsonPropertyName("podeCompartilhar")]
        public bool PodeCompartilhar { get; set; } 

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

        [JsonPropertyName("idAnalisePreliminar")]
        public object IdAnalisePreliminar { get; set; } 

        [JsonPropertyName("nomePessoaPendencia")]
        public object NomePessoaPendencia { get; set; } 

        [JsonPropertyName("siglaUnidadePendencia")]
        public object SiglaUnidadePendencia { get; set; } 

        [JsonPropertyName("nomeEquipePendencia")]
        public object NomeEquipePendencia { get; set; } 

        [JsonPropertyName("valorParaFiltragemDeFatiaDeGrafico")]
        public object ValorParaFiltragemDeFatiaDeGrafico { get; set; } 

        [JsonPropertyName("estadoSituacao")]
        public string EstadoSituacao { get; set; } 

        [JsonPropertyName("acompanhamento")]
        public bool Acompanhamento { get; set; } 

        [JsonPropertyName("sistema")]
        public string Sistema { get; set; } 

        [JsonPropertyName("usuarioPodeGerenciarAtividade")]
        public bool UsuarioPodeGerenciarAtividade { get; set; } 

        [JsonPropertyName("pendencias")]
        public List<object> Pendencias { get; set; } 

        [JsonPropertyName("caixasAtividade")]
        public List<object> CaixasAtividade { get; set; } 

        [JsonPropertyName("abasAtividade")]
        public List<AbasAtividade> AbasAtividade { get; set; } 

        [JsonPropertyName("mesAnoUltimaModificacao")]
        public string MesAnoUltimaModificacao { get; set; } 
    }
}
