using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.Campos;


namespace eAudStuffCSharp.EAudTypes.Query {
    public class CamposTarefa    {
       
        [JsonPropertyName("exportarPara")]
        public CampoGenerico<List<ValorCampoMultivalorado>> ExportarPara { get; set; } 

        [JsonPropertyName("tarefasPrecedentes")]
        public TarefasPrecedentes TarefasPrecedentes { get; set; } 

        [JsonPropertyName("titulo")]
        public CampoGenerico<string> Titulo { get; set; } 

        [JsonPropertyName("dataPrevisaoInicio")]
        public CampoGenericoData DataPrevisaoInicio { get; set; } 
        
        [JsonPropertyName("tags")]
        public CampoGenerico<object> Tags { get; set; } 

        [JsonPropertyName("dataPrevisaoFim")]
        public CampoGenericoData DataPrevisaoFim { get; set; } 

        [JsonPropertyName("tarefaAssociada")]
        public TarefaAssociada TarefaAssociada { get; set; } 

        [JsonPropertyName("dataRealizadaFim")]
        public CampoGenericoData DataRealizadaFim { get; set; } 

        [JsonPropertyName("dataRealizadaInicio")]
        public CampoGenericoData DataRealizadaInicio { get; set; } 

    }

}