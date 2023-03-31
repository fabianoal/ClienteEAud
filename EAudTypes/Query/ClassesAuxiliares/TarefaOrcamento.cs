using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares {
    public class TarefaOrcamento {
        [JsonPropertyName("idPrograma")]
        public int IdPrograma {get; set; }

        [JsonPropertyName("idTarefa")]
        public int IdTarefa { get; set; } 

        [JsonPropertyName("totalOrcamento")]
        public double TotalOrcamento { get; set; } 

        [JsonPropertyName("itensOrcamento")]
        public List<ItemOrcamento> ItensOrcamento { get; set; } 
    }
}