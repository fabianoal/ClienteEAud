using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace eAudStuffCSharp.EAudTypes.Query.Campos{
    public class ObjetivoEstrategico    {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("nome")]
        public string Nome { get; set; } 
    }
}