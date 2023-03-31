using System;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares;
namespace eAudStuffCSharp.EAudTypes.Query.Campos {
    
    public class ValorTarefaAssociada {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("titulo")]
        public string Titulo { get; set; }

        [JsonPropertyName("codGanttTarefa")]
        public object CodGanttTarefa { get; set; }

        [JsonPropertyName("nomeExibicao")]
        public string NomeExibicao { get; set; }

        [JsonPropertyName("tarefaAssociada")]
        public object TarefaAssociada { get; set; }

        [JsonPropertyName("dataRealizadaInicio")]
        [JsonConverter(typeof(Util.DateTimeConverter))]
        public DateTime? DataRealizadaInicio { get; set; }

        [JsonPropertyName("dataRealizadaFim")]
        [JsonConverter(typeof(Util.DateTimeConverter))]
        public DateTime? DataRealizadaFim { get; set; }

        [JsonPropertyName("atividade")]
        public Atividade.Atividade Atividade { get; set; }

        [JsonPropertyName("assunto")]
        public string Assunto { get; set; }

        [JsonPropertyName("valoresDosCampos")]
        public ItemValorCampo[] ValoresDosCampos { get; set; }

        [JsonPropertyName("tipoInteracaoDoRedirecionamentoNaCriacaoAutomatica")]
        public object TipoInteracaoDoRedirecionamentoNaCriacaoAutomatica { get; set; }
    }

}