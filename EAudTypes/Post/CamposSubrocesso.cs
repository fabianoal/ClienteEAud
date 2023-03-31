using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Post.CamposPost;
using System.Linq;

namespace eAudStuffCSharp.EAudTypes.Post
{
    public class CamposSubrocesso {
        [JsonPropertyName("titulo")]
        public string Titulo { get; set; } 

        [JsonPropertyName("TituloSubp")]
        public string TituloSubprocesso => Titulo;

        [JsonPropertyName("tarefaAssociada")]
        public int? TarefaAssociada { get; set; }

        [JsonPropertyName("DescSub")]
        public string Descricao { get; set; }

        [JsonPropertyName("UniGesPT")]
        public int UnidadeGestoraDoProcesso { get; set; }

        [JsonPropertyName("UniGesSub")]
        public int UnidadeGestoraDoSubprocesso { get; set; }

        [JsonPropertyName("CV")]
        public string CadeiaDeValorStr => (ItemsCadeiaDeValor?.Count() ?? 0) > 0 ? String.Join(",", ItemsCadeiaDeValor) : null;

        [JsonIgnore]
        public int[] ItemsCadeiaDeValor { get; set; }

        [JsonPropertyName("UniEnvSub")]
        public string UnidadesEnvolvidasStr => (UnidadesEnvolvidasSubprocesso?.Count() ?? 0) > 0 ? String.Join(",", UnidadesEnvolvidasSubprocesso) : null;

        [JsonIgnore]
        public int[] UnidadesEnvolvidasSubprocesso { get; set; } 

        [JsonPropertyName("gerentesPlanoTrabalho")]
        public string GerentesPlanoTrabalhoStr => (GerentesPlanoTrabalho?.Count() ?? 0) > 0 ? String.Join(",", GerentesPlanoTrabalho) : null;

        [JsonIgnore]
        public int[] GerentesPlanoTrabalho { get; set; }

        [JsonPropertyName("gerentesDoProcesso")]
        public string GerentesDoProcessoStr => (GerentesDoProcesso?.Count() ?? 0) > 0 ? String.Join(",", GerentesDoProcesso) : null;

        [JsonIgnore]
        public int[] GerentesDoProcesso { get; set; }

    }

}