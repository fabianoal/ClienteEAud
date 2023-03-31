using System.Text.Json.Serialization;
using System.Collections;
using System.Collections.Generic;

namespace eAudStuffCSharp.EAudTypes.Query.Campos{
    public class ValorPactuacaoPO    {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; } 

        [JsonPropertyName("dataInicio")]
        public string DataInicio { get; set; } 

        [JsonPropertyName("dataFim")]
        public string DataFim { get; set; } 

        [JsonPropertyName("ativo")]
        public bool Ativo { get; set; } 

        //[JsonPropertyName("custoDaHora")]
        //public object CustoDaHora { get; set; } 

        [JsonPropertyName("nomeExibicao")]
        public string NomeExibicao { get; set; } 

        [JsonPropertyName("custoDaHoraFormnatado")]
        public string CustoDaHoraFormnatado { get; set; } 
    }
}