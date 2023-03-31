using System;
using System.Text.Json.Serialization;

namespace eAudStuffCSharp.EAudTypes.Query {

    public class TarefaPrecedente {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("titulo")]
        public string Titulo { get; set; } 

        [JsonPropertyName("nomeExibicao")]
        public string NomeExibicao { get; set; } 

        [JsonPropertyName("tarefaAssociada")]
        public int? TarefaAssociada { get; set; } 

        [JsonPropertyName("dataRealizadaInicio")]
        [JsonConverter(typeof(Util.DateTimeConverter))]
        public DateTime? DataRealizadaInicio { get; set; } 

        [JsonPropertyName("dataRealizadaFim")]
        [JsonConverter(typeof(Util.DateTimeConverter))]
        public DateTime? DataRealizadaFim { get; set; } 

        [JsonPropertyName("assunto")]
        public string Assunto { get; set; } 
    }
}