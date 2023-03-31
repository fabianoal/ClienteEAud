using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Post.CamposPost;

namespace eAudStuffCSharp.EAudTypes.Post
{
    public class CamposEditarOrcamento {
        [JsonPropertyName("titulo")]
        public string Titulo { get; set; }

        [JsonPropertyName("Detalhamento")]
        public string Detalhamento { get; set; }

        [JsonPropertyName("supervisores")]
        public string SupervisoresJoinned => 
            (Supervisores != null && Supervisores.Length > 0) 
                ? string.Join(',', Supervisores) 
                : null;

        [JsonIgnore]
        public int[] Supervisores { get; set; }

        [JsonPropertyName("ptaa")]
        public int? Ptaa { get; set; }

        [JsonPropertyName("planoOperacionalOrcamento")]
        public int? PlanoOperacionalOrcamento { get; set; }

        [JsonPropertyName("sorcOrcamento")]
        public string SorcOrcamento => JsonSerializer.Serialize(SorcOrcamentoObj, Confs.JsonSerializerOptions);

        [JsonIgnore]
        public TabelaPost SorcOrcamentoObj { get; set; }

        [JsonPropertyName("comments")]
        public string Comentarios { get; set; }
    }
}