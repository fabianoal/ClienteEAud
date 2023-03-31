using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace eAudStuffCSharp.EAudTypes.Query {
// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class LinhaUsuario    {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("nome")]
        public string Nome { get; set; } 

        [JsonPropertyName("cpf")]
        public string Cpf { get; set; } 

        [JsonPropertyName("siape")]
        public string Siape { get; set; } 

        [JsonPropertyName("email")]
        public string Email { get; set; } 

        [JsonPropertyName("ativo")]
        public bool Ativo { get; set; } 

        [JsonPropertyName("nota")]
        public object Nota { get; set; } 

        [JsonPropertyName("unidadePrincipal")]
        public string UnidadePrincipal { get; set; } 
    }
}