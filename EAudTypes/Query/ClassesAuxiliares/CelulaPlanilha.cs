using System;
using System.Text.Json.Serialization;

namespace eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares {
    
    public class CelulaPlanilha {
        
        [JsonPropertyName("dataExecucao")]
        [JsonConverter(typeof(Util.DateTimeConverter))]
        public DateTime? DataExecucao { get; set; }

        [JsonPropertyName("tempoExecucaoMinutos")]
        public int TempoExecucaoMinutos { get; set; }    
    }

}