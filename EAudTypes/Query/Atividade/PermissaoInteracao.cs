using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.Campos;

namespace eAudStuffCSharp.EAudTypes.Query.Atividade {
    public class PermissaoInteracao
    {
        [JsonPropertyName("idTipoInteracao")]
        public int IdTipoInteracao { get; set; }

        [JsonPropertyName("idPapel")]
        public int IdPapel { get; set; }

        [JsonPropertyName("idSituacao")]
        public int IdSituacao { get; set; }
    }
}