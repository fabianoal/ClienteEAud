using System.Text.Json.Serialization;

namespace eAudStuffCSharp.EAudTypes.Post
{
    public class ConsultaOrcamentos    {
        [JsonPropertyName("idPlanoOperacional")]
        public int IdPlanoOperacional { get; set; } 

        [JsonPropertyName("idsTarefas")]
        public int[] IdsTarefas { get; set; } 
    }
}
