using System;
using System.Text.Json.Serialization;
using System.Collections;
using System.Collections.Generic;
namespace eAudStuffCSharp.EAudTypes.Query.Campos {
        public class CampoGenericoData : CampoGenerico<DateTime?>    {

        [JsonPropertyName("valor")]
        [JsonConverter(typeof(Util.DateTimeConverter))]
        public override DateTime? Valor { get; set; } 
    }

}