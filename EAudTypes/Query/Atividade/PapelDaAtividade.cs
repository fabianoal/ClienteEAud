using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.Campos;

namespace eAudStuffCSharp.EAudTypes.Query.Atividade {
    public class PapelDaAtividade
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("tipoPermissaoCompartilhamento")]
        public string TipoPermissaoCompartilhamento { get; set; }

        [JsonPropertyName("compartilhavelNaTarefa")]
        public bool CompartilhavelNaTarefa { get; set; }

        [JsonPropertyName("tipoPapel")]
        public string TipoPapel { get; set; }
    }
}