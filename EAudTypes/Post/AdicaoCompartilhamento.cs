using System;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Post.CamposPost;

namespace eAudStuffCSharp.EAudTypes.Post{
    public class AdicaoCompartilhamento {
            [JsonPropertyName("compartilhamentosForm")]
            public CompartilhamentoForm[] CompartilhamentosForm { get; set; } 

            [JsonPropertyName("idsTarefas")]
            public int[] IdsTarefas { get; set; } 
    }
}