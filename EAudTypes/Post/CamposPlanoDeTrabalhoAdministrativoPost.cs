using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Post.CamposPost;
using System.Linq;

namespace eAudStuffCSharp.EAudTypes.Post
{
    public class CamposPlanoDeTrabalhoAdministrativoPost    {
        [JsonPropertyName("titulo")]
        public string Titulo { get; set; } 

        [JsonPropertyName("tarefaAssociada")]
        public int TarefaAssociada { get; set; }


        [JsonPropertyName("envolvidosPlanoTrabalho")]
        public string UnidadesEnvolvidasStr => String.Join(",", UnidadesEnvolvidas);

        [JsonIgnore]
        public int[] UnidadesEnvolvidas { get; set; } 

        [JsonPropertyName("responsavelPlanoTrabalho")]
        public int UnidadeResponsavel { get; set; }

        [JsonPropertyName("gerentesPlanoTrabalho")]
        public string GerentesPlanoTrabalho { get; set; } 


    }

}