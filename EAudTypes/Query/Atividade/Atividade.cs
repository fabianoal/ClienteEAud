using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.Campos;

namespace eAudStuffCSharp.EAudTypes.Query.Atividade {
    public class Atividade
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("codigo")]
        public string Codigo { get; set; }

        [JsonPropertyName("assunto")]
        public string Assunto { get; set; }

        [JsonPropertyName("descricao")]
        public object Descricao { get; set; }

        [JsonPropertyName("campos")]
        public CampoFormulario[] Campos { get; set; }

        [JsonPropertyName("grupos")]
        public GrupoConfiguracao[] Grupos { get; set; }

        [JsonPropertyName("papeisDaAtividade")]
        public PapelDaAtividade[] PapeisDaAtividade { get; set; }

        [JsonPropertyName("exibePainelCompartilhamento")]
        public bool ExibePainelCompartilhamento { get; set; }

        [JsonPropertyName("idSistemaTarefa")]
        public object IdSistemaTarefa { get; set; }

        [JsonPropertyName("opcoesDaAtividade")]
        public object OpcoesDaAtividade { get; set; }
    }
}