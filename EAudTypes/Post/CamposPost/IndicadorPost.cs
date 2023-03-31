using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace eAudStuffCSharp.EAudTypes.Post.CamposPost {
    
    public class IndicadorPost    {
        [JsonPropertyName("id")]
        public string Id { get; set; } 

        [JsonPropertyName("nome")]
        public string Nome { get; set; } 

        [JsonPropertyName("unidadeMedida")]
        public string UnidadeMedida { get; set; } 
    }

}