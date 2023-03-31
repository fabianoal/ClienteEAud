using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace eAudStuffCSharp.EAudTypes.Query {
// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class LinhaUnidade    {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("nome")]
        public string Nome { get; set; } 

        [JsonPropertyName("orgao")]
        public string Orgao { get; set; } 

        [JsonPropertyName("unidadeSuperior")]
        public string UnidadeSuperior { get; set; } 

        [JsonPropertyName("tipos")]
        public string[] Tipos { get; set; } 

        [JsonPropertyName("codigo")]
        public string Codigo { get; set; } 

        [JsonPropertyName("codigoSiorg")]
        public string CodigoSiorg { get; set; } 

        [JsonPropertyName("siglaSimples")]
        public string SiglaSimples { get; set; } 

        [JsonPropertyName("sigla")]
        public string Sigla { get; set; } 

        [JsonPropertyName("email")]
        public string Email { get; set; } 

        [JsonPropertyName("telefone")]
        public string Telefone { get; set; } 

        [JsonPropertyName("localidade")]
        public string Localidade { get; set; } 

        [JsonPropertyName("ativo")]
        public bool Ativo { get; set; } 

        [JsonPropertyName("quantidadeSolicitacoesPendentes")]
        public int QuantidadeSolicitacoesPendentes { get; set; } 

        [JsonPropertyName("gestores")]
        public List<object> Gestores { get; set; } 

        [JsonPropertyName("podeGerenciar")]
        public bool PodeGerenciar { get; set; } 

        [JsonPropertyName("hierarquia")]
        public string Hierarquia { get; set; } 
    }
}