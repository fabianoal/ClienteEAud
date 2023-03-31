using System;
using System.Text.Json.Serialization;
namespace eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares {
    public class ItemOrcamento    {
        [JsonPropertyName("idOrcamento")]
        public int IdOrcamento { get; set; } 

        [JsonPropertyName("tituloOrcamento")]
        public string TituloOrcamento { get; set; } 

        [JsonPropertyName("etapa")]
        public object Etapa { get; set; } 

        [JsonPropertyName("mesAno")]
        public string MesAno { get; set; } 

        [JsonPropertyName("valor")]
        public string Valor { get; set; } 

        [JsonPropertyName("tipoOrcamento")]
        public string TipoOrcamento { get; set; } 
    }
}