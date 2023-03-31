using System.Text.Json.Serialization;

namespace eAudStuffCSharp.EAudTypes.Query
{
    public class AbasAtividade    {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; } 

        [JsonPropertyName("visivel")]
        public bool Visivel { get; set; } 
    }

}