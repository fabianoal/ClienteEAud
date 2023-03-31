using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.Campos;

namespace eAudStuffCSharp.EAudTypes.Query.Atividade {
    public class TipoInteracao
    {
         [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }

        [JsonPropertyName("nomeIcone")]
        public string NomeIcone { get; set; }

        [JsonPropertyName("codAtividade")]
        public string CodAtividade { get; set; }

        [JsonPropertyName("campos")]
        public CampoFormularioInteracao[] Campos { get; set; }

        [JsonPropertyName("interacoesAutomaticas")]
        public RegistroInteracaoAutomatica[] InteracoesAutomaticas { get; set; }

        [JsonPropertyName("tarefasAutomaticas")]
        public Atividade[] TarefasAutomaticas { get; set; }

        [JsonPropertyName("papeisQueFicaraoComPendencias")]
        public string[] PapeisQueFicaraoComPendencias { get; set; }

        [JsonPropertyName("papeisQueSeraoNotificados")]
        public string[] PapeisQueSeraoNotificados { get; set; }

        [JsonPropertyName("idSituacaoDestino")]
        public int? IdSituacaoDestino { get; set; }

        [JsonPropertyName("situacaoDestino")]
        public string SituacaoDestino { get; set; }

        [JsonPropertyName("exigirTokenSeguranca")]
        public bool ExigirTokenSeguranca { get; set; }
    }
}