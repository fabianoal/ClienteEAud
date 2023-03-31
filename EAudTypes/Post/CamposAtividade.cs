using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Post.CamposPost;
using System.Linq;

namespace eAudStuffCSharp.EAudTypes.Post
{
    public class CamposAtividade {
        [JsonPropertyName("titulo")]
        public string Titulo { get; set; } 

        [JsonPropertyName("tarefaAssociada")]
        public int TarefaAssociada { get; set; }

        [JsonPropertyName("Detalhamento")]
        public string Descricao { get; set; }

        [JsonPropertyName("UniGesPT")]
        public int UnidadeGestoraDoProcesso { get; set; }

        [JsonPropertyName("UniGesSub")]
        public int UnidadeGestoraDoSubprocesso { get; set; }

        [JsonPropertyName("UniEnvSub")]
        public string UnidadesEnvolvidasStr => (UnidadesEnvolvidasSubprocesso?.Count() ?? 0) > 0 ? String.Join(",", UnidadesEnvolvidasSubprocesso) : null;

        [JsonIgnore]
        public int[] UnidadesEnvolvidasSubprocesso { get; set; } 

        [JsonPropertyName("GerSubProc")]
        public string GerentesDoSubprocessoStr => (GerentesDoSubprocesso?.Count() ?? 0) > 0 ? String.Join(",", GerentesDoSubprocesso) : null;

        [JsonIgnore]
        public int[] GerentesDoSubprocesso { get; set; }

        [JsonPropertyName("gerentesDoProcesso")]
        public string GerentesDoProcessoStr => (GerentesDoProcesso?.Count() ?? 0) > 0 ? String.Join(",", GerentesDoProcesso) : null;

        [JsonIgnore]
        public int[] GerentesDoProcesso { get; set; }

    }

}