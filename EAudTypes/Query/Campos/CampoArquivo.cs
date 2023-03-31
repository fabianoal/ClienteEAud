using System;
using System.Text.Json.Serialization;
namespace eAudStuffCSharp.EAudTypes.Query.Campos {

    public class CampoArquivo {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("indexado")]
        public bool Indexado { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("nomeExibicao")]
        public string NomeExibicao { get; set; }

        [JsonPropertyName("tamanho")]
        public int Tamanho { get; set; }

        [JsonPropertyName("tipo")]
        public string Tipo { get; set; }

        [JsonPropertyName("caminho")]
        public string Caminho { get; set; } 

        [JsonPropertyName("codigo")]
        public string Codigo { get; set; } 

        [JsonPropertyName("dataArquivo")]
        public DateTime DataArquivo { get; set; } 

        [JsonPropertyName("dataInclusao")]
        public DateTime DataInclusao { get; set; } 

        [JsonPropertyName("hash")]
        public string Hash { get; set; } 


    }

}