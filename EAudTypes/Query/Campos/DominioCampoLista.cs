using System.Text.Json.Serialization;

namespace eAudStuffCSharp.EAudTypes.Query.Campos{
    public class DominioCampoLista    {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("ordem")]
        public int Ordem { get; set; } 

        [JsonPropertyName("valor")]
        public string Valor { get; set; } 

        [JsonIgnore]
        public string ValorLower => Valor.ToLower().Trim();
    }

}