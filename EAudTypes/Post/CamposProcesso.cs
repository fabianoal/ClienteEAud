using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Post.CamposPost;
using System.Linq;

namespace eAudStuffCSharp.EAudTypes.Post
{
    public class CamposProcesso    {
        [JsonPropertyName("titulo")]
        public string Titulo { get; set; } 

        [JsonPropertyName("tarefaAssociada")]
        public int? TarefaAssociada { get; set; }

        [JsonPropertyName("Detalhamento")]
        public string Descricao { get; set; }

        [JsonPropertyName("UniGesPT")]
        public int UnidadeGestoraDoPlanoDeTrabalho { get; set; }

        [JsonPropertyName("CV")]
        public string CadeiaDeValorStr => (ItemsCadeiaDeValor?.Count() ?? 0) > 0 ? String.Join(",", ItemsCadeiaDeValor) : null;

        [JsonIgnore]
        public int[] ItemsCadeiaDeValor { get; set; }

        [JsonPropertyName("envolvidosPlanoTrabalho")]
        public string UnidadesEnvolvidasStr => (UnidadesEnvolvidas?.Count() ?? 0) > 0 ? String.Join(",", UnidadesEnvolvidas) : null;

        [JsonIgnore]
        public int[] UnidadesEnvolvidas { get; set; } 

        [JsonPropertyName("gerentesPlanoTrabalho")]
        public string GerentesPlanoTrabalhoStr => (GerentesPlanoTrabalho?.Count() ?? 0) > 0 ? String.Join(",", GerentesPlanoTrabalho) : null;
        
        [JsonIgnore]
        public int[] GerentesPlanoTrabalho { get; set; } 


    }

}