using System.Text.Json.Serialization;
namespace eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares {
    public class Localidade    {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; } 

        [JsonPropertyName("tipo")]
        public TipoGenericoIdDescricao Tipo { get; set; } 

        [JsonPropertyName("gruposLocalidade")]
        public string GruposLocalidade { get; set; } 

        [JsonPropertyName("nomeExibicao")]
        public string NomeExibicao { get; set; } 
    }

}