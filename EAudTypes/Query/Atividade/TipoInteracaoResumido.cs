using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.Campos;

namespace eAudStuffCSharp.EAudTypes.Query.Atividade {
    public class TipoInteracaoResumido
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("ativo")]
        public bool Ativo { get; set; }

        [JsonPropertyName("todosCamposPreenchimentoAutomatico")]
        public bool TodosCamposPreenchimentoAutomatico { get; set; }

        [JsonPropertyName("ordem")]
        public int? Ordem { get; set; }

        [JsonPropertyName("cadastrarViaGantt")]
        public bool CadastrarViaGantt { get; set; }

        [JsonPropertyName("corIcone")]
        public string CorIcone { get; set; }

        [JsonPropertyName("nomeIcone")]
        public string NomeIcone { get; set; }
    }
}