using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.Campos;

namespace eAudStuffCSharp.EAudTypes.Query.Atividade {
    public class CampoTarefaAlvo
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("formato")]
        public string Formato { get; set; }

        [JsonPropertyName("formatoBasico")]
        public string FormatoBasico { get; set; }

        [JsonPropertyName("mascara")]
        public object Mascara { get; set; }

        [JsonPropertyName("tooltip")]
        public string Tooltip { get; set; }

        [JsonPropertyName("alias")]
        public string Alias { get; set; }

        [JsonPropertyName("situacao")]
        public string Situacao { get; set; }

        [JsonPropertyName("assunto")]
        public string Assunto { get; set; }

        [JsonPropertyName("campoPadrao")]
        public bool CampoPadrao { get; set; }

        [JsonPropertyName("idSistema")]
        public int IdSistema { get; set; }
    }
}