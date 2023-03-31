using System.Text.Json.Serialization;

namespace eAudStuffCSharp.EAudTypes.Query {
    public class Pendencia    {
        [JsonPropertyName("nomeUsuarioUnidade")]
        public string NomeUsuarioUnidade { get; set; } 

        [JsonPropertyName("tipo")]
        public string Tipo { get; set; } 
    }
}