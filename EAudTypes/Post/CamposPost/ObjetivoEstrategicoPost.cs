using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace eAudStuffCSharp.EAudTypes.Post.CamposPost {
    public class ObjetivoEstrategicoPost    {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("nome")]
        public string Nome { get; set; } 
    }

}