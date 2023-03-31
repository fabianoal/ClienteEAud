using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Post.CamposPost;
using System.Linq;

namespace eAudStuffCSharp.EAudTypes.Post
{
    public class PostRecalculaCompartilhamentos    {
        [JsonPropertyName("compartilhamentosForm")]
        public object[] CompartilhamentosForm { get; set; }

        [JsonPropertyName("idsTarefas")]
        public int[] IdsTarefas { get; set; }

    }

}