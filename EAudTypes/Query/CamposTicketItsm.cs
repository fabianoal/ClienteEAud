using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.Campos;


namespace eAudStuffCSharp.EAudTypes.Query {
    public class CamposTicketItsm : CamposTarefa    {
        
        [JsonPropertyName("Detalhamento")]
        public CampoGenerico<string> Detalhamento { get; set; } 

        [JsonPropertyName("itsmAnotacaoInteracaoConclusao")]
        public CampoGenerico<string> ItsmAnotacaoInteracaoConclusao { get; set; } 

        [JsonPropertyName("itsmAreaRequisicao")]
        public CampoGenerico<string> ItsmAreaRequisicao { get; set; } 

        [JsonPropertyName("itsmCategoriaDaRequisicao")]
        public CampoGenerico<string> ItsmCategoriaDaRequisicao { get; set; } 

        [JsonPropertyName("itsmServicoAfetado")]
        public CampoGenerico<string> ItsmServicoAfetado { get; set; } 

        [JsonPropertyName("itsmSubAreaRequisicao")]
        public CampoGenerico<string> ItsmSubAreaRequisicao { get; set; } 
        
        [JsonPropertyName("itsmSubcategoriaRequisicao")]
        public CampoGenerico<string> ItsmSubcategoriaRequisicao { get; set; } 

        [JsonPropertyName("ticketItsm")]
        public CampoGenerico<string> TicketItsm { get; set; } 
    }
}