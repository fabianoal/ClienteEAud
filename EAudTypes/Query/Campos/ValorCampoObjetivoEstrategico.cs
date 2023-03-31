using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace eAudStuffCSharp.EAudTypes.Query.Campos{
    public class ValorCampoObjetivoEstrategico    {
        [JsonPropertyName("objetivoEstrategico")]
        public ObjetivoEstrategico ObjetivoEstrategico { get; set; } 

        [JsonPropertyName("indicador")]
        public Indicador Indicador { get; set; } 

        [JsonPropertyName("valor")]
        public double? Valor { get; set; } 
    }

}