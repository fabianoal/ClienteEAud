using System.Text.Json.Serialization;
namespace eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares {
    public class TarefaReferenciada    {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("titulo")]
        public string Titulo { get; set; } 
    }
}