using System;
using System.Text.Json.Serialization;
using System.Collections;
using System.Collections.Generic;
using eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares;

namespace eAudStuffCSharp.EAudTypes.Query.Campos {
        public class CampoGenericoTabela : CampoGenerico<ValorTabela>    {

        [JsonPropertyName("valor")]
        [JsonConverter(typeof(Util.TabelaConverter))]
        public override ValorTabela Valor { get; set; } 
    }

}