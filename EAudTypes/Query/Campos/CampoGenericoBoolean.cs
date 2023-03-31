using System;
using System.Text.Json.Serialization;
using System.Collections;
using System.Collections.Generic;
namespace eAudStuffCSharp.EAudTypes.Query.Campos {
        public class CampoGenericoBoolean : CampoGenerico<bool?>    {

        [JsonPropertyName("valor")]
        [JsonConverter(typeof(Util.BooleanConverter))]
        public override bool? Valor { get; set; } 
    }
}