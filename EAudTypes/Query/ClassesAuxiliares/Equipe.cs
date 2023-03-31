using System.Text.Json.Serialization;
namespace eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares {
    public class Equipe    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("ativo")]
        public bool Ativo { get; set; }

        [JsonPropertyName("chefia")]
        public bool Chefia { get; set; }

        [JsonPropertyName("usoExterno")]
        public bool UsoExterno { get; set; }

        [JsonPropertyName("nomeExibicao")]
        public string NomeExibicao { get; set; }
    }

}