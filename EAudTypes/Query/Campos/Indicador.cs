using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace eAudStuffCSharp.EAudTypes.Query.Campos{
    public class Indicador    {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("nome")]
        public string Nome { get; set; } 

        [JsonPropertyName("unidadeMedida")]
        public string UnidadeMedida { get; set; } 
    }
}