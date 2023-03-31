using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.Campos;

namespace eAudStuffCSharp.EAudTypes.Query.Atividade {
    public class RegistroInteracaoAutomatica
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("obrigatorio")]
        public bool Obrigatorio { get; set; }

        [JsonPropertyName("tipoInteracaoDe")]
        public TipoInteracaoResumido TipoInteracaoDe { get; set; }

        [JsonPropertyName("tipoInteracaoPara")]
        public TipoInteracaoResumido TipoInteracaoPara { get; set; }

        [JsonPropertyName("campoComTarefaAlvo")]
        public CampoTarefaAlvo CampoComTarefaAlvo { get; set; }

        [JsonPropertyName("checarPermissoesECondicoes")]
        public bool ChecarPermissoesECondicoes { get; set; }

        [JsonPropertyName("exibir")]
        public bool Exibir { get; set; }
    }
}