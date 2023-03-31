using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.Campos;

namespace eAudStuffCSharp.EAudTypes.Query.Atividade {
    public class SituacaoAtividade
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("ordem")]
        public int Ordem { get; set; }

        [JsonPropertyName("nomEstado")]
        public string NomEstado { get; set; }

        [JsonPropertyName("nomSituacao")]
        public string NomSituacao { get; set; }

        [JsonPropertyName("inicial")]
        public bool Inicial { get; set; }

        [JsonPropertyName("finalizada")]
        public bool Finalizada { get; set; }

        [JsonPropertyName("exclusao")]
        public bool Exclusao { get; set; }
    }
}