using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.Campos;

namespace eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares {

    public class LinhaPlanilha {
        [JsonPropertyName("idTarefaExecutada")]
        public int IdTarefaExecutada { get; set; }

        [JsonPropertyName("tituloTarefaExecutada")]
        public string TituloTarefaExecutada { get; set; }

        [JsonPropertyName("situacaoTarefaExecutada")]
        public string SituacaoTarefaExecutada { get; set; }

        [JsonPropertyName("estadoTarefaExecutada")]
        public string EstadoTarefaExecutada { get; set; }

        [JsonPropertyName("tarefaExecutadaCancelada")]
        public bool TarefaExecutadaCancelada { get; set; }

        [JsonPropertyName("tarefaExecutadaConcluida")]
        public bool TarefaExecutadaConcluida { get; set; }

        [JsonPropertyName("tempoEstimadoConclusao")]
        public float? TempoEstimadoConclusao { get; set; }

        [JsonPropertyName("dispensaPonto")]
        public bool DispensaPonto { get; set; }

        [JsonPropertyName("celulas")]
        public CelulaPlanilha[] Celulas { get; set; }

        [JsonPropertyName("percentualAceite")]
        public int PercentualAceite { get; set; }

        [JsonPropertyName("autorAceite")]
        public ValorCampoMultivalorado AutorAceite { get; set; }
    }

}