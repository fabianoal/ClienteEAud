using System;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares;


namespace eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares {
    public class Planilha {
        [JsonPropertyName("dataBaseInicio")]
        [JsonConverter(typeof(Util.DateTimeConverter))]
        public DateTime? DataBaseInicio { get; set; }

        [JsonPropertyName("dataBaseFim")]
        [JsonConverter(typeof(Util.DateTimeConverter))]
        public DateTime? DataBaseFim { get; set; }

        [JsonPropertyName("idServidor")]
        public int IdServidor { get; set; }

        [JsonPropertyName("possuiHorasNoFimDeSemanaEFeriados")]
        public bool PossuiHorasNoFimDeSemanaEFeriados { get; set; }

        [JsonPropertyName("feriados")]
        public object[] Feriados { get; set; }

        [JsonPropertyName("linhas")]
        public LinhaPlanilha[] Linhas { get; set; }
    }

}