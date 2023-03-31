using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace eAudStuffCSharp.EAudTypes.Post.CamposPost
{
    public class CampoTarefasPOPost  {
        [JsonPropertyName("informacoesGantt")]
        public object InformacoesGantt { get; set; } 

        [JsonPropertyName("custoDaHora")]
        public double CustoDaHora { get; set; } 

        [JsonPropertyName("tarefasPlanoOperacional")]
        public LinhaTarefaPlanoOperacionalPost[] TarefasPlanoOperacional { get; set; } 
    }

}