using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Post.CamposPost;
namespace eAudStuffCSharp.EAudTypes.Post
{
    public class CamposInteracaoSetTarefasPrecedentes {
        [JsonIgnore]
        public List<int> ListaTarefasPrecedentes {get; set; }
        [JsonPropertyName("tarefasPrecedentes")]
        public string TarefasPrecedentes { 
            get => String.Join(",", ListaTarefasPrecedentes.Select(x => x.ToString()));
        } 
    }
}