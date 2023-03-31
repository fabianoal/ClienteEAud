using System.Text.Json.Serialization;
namespace eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares {
    public class TipoGenericoIdDescricao    {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; } 
    }
}