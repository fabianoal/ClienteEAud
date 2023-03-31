using System;
using System.Text.Json.Serialization;

namespace eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares {
    public class Anexo    {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("caminho")]
        public string Caminho { get; set; } 

        [JsonPropertyName("tamanho")]
        public int Tamanho { get; set; } 

        [JsonPropertyName("nome")]
        public string Nome { get; set; } 

        [JsonPropertyName("descricao")]
        public object Descricao { get; set; } 

        [JsonPropertyName("tipo")]
        public string Tipo { get; set; } 

        [JsonPropertyName("dataInclusao")]
        public DateTime? DataInclusao { get; set; } 

        [JsonPropertyName("dataArquivo")]
        public DateTime? DataArquivo { get; set; } 

        [JsonPropertyName("dataProcessamento")]
        public DateTime? DataProcessamento { get; set; } 

        [JsonPropertyName("codigo")]
        public string Codigo { get; set; } 

        [JsonPropertyName("indexado")]
        public bool Indexado { get; set; } 

        [JsonPropertyName("hash")]
        public string Hash { get; set; } 

        [JsonPropertyName("nomeExibicao")]
        public string NomeExibicao { get; set; } 
    }

}