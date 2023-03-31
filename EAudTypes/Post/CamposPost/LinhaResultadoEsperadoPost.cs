using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace eAudStuffCSharp.EAudTypes.Post.CamposPost
{
    public class LinhaResultadoEsperadoPost    {
        [JsonPropertyName("objetivoEstrategico")]
        public ObjetivoEstrategicoPost ObjetivoEstrategico { get; set; } 

        [JsonPropertyName("indicador")]
        public IndicadorPost Indicador { get; set; } 

        [JsonPropertyName("valor")]
        public double? Valor { get; set; } 
    }
}