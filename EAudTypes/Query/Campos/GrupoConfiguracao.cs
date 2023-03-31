using System.Text.Json.Serialization;

namespace eAudStuffCSharp.EAudTypes.Query.Campos{
    public class GrupoConfiguracao    {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("nome")]
        public string Nome { get; set; } 

        [JsonPropertyName("textoExplicativo")]
        public string TextoExplicativo { get; set; } 

        [JsonPropertyName("ordem")]
        public int Ordem { get; set; } 
    }

}