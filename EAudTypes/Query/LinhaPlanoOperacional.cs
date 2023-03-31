using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.Campos;

namespace eAudStuffCSharp.EAudTypes.Query
{
    public class LinhaPlanoOperacional  {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("situacao")]
        public string Situacao { get; set; } 

        [JsonPropertyName("estado")]
        public string Estado { get; set; } 

        [JsonPropertyName("atividade")]
        public object Atividade { get; set; } 

        [JsonPropertyName("titulo")]
        public string Titulo { get; set; } 

        [JsonPropertyName("idTarefaAssociada")]
        public object IdTarefaAssociada { get; set; } 

        [JsonPropertyName("tituloTarefaAssociada")]
        public string TituloTarefaAssociada { get; set; } 

        [JsonPropertyName("dtPrevisaoInicio")]
        public string DtPrevisaoInicio { get; set; } 

        [JsonPropertyName("dtPrevisaoFim")]
        public string DtPrevisaoFim { get; set; } 

        [JsonPropertyName("dtRealizadaInicio")]
        public string DtRealizadaInicio { get; set; } 

        [JsonPropertyName("dtRealizadaFim")]
        public string DtRealizadaFim { get; set; } 

        [JsonPropertyName("prioridade")]
        public string Prioridade { get; set; } 

        [JsonPropertyName("favorita")]
        public bool Favorita { get; set; } 

        [JsonPropertyName("tags")]
        public List<object> Tags { get; set; } 

        [JsonPropertyName("pactuacaoPO")]
        public ValorPactuacaoPO PactuacaoPO { get; set; } 

        [JsonPropertyName("descPactuacaoPO")]
        public string DescPactuacaoPO { get; set; } 

        [JsonPropertyName("totalOrcamento")]
        public string TotalOrcamento { get; set; } 

        [JsonPropertyName("totalHomemHoraAlocado")]
        public int? TotalHomemHoraAlocado { get; set; } 

        [JsonPropertyName("quantidade")]
        public object Quantidade { get; set; } 

        [JsonPropertyName("mesOrcamento")]
        public object MesOrcamento { get; set; } 

        [JsonPropertyName("tipoOrcamento")]
        public int? TipoOrcamento { get; set; } 

        [JsonPropertyName("custoPrevistoPO")]
        public string CustoPrevistoPO { get; set; } 

        [JsonPropertyName("valorParaFiltragemDeFatiaDeGrafico")]
        public string ValorParaFiltragemDeFatiaDeGrafico { get; set; } 

        [JsonPropertyName("pendencias")]
        public List<Pendencia> Pendencias { get; set; } 
    }
}
