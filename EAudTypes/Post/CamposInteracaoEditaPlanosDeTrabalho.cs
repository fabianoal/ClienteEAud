using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Post.CamposPost;

namespace eAudStuffCSharp.EAudTypes.Post
{
    public class CamposInteracaoEditaPlanosDeTrabalho {
        [JsonPropertyName("tarefasDoPo")]
        public string TarefasDoPo { 
            get => JsonSerializer.Serialize(TarefasDoPoObj, Confs.JsonSerializerOptions);
            set => JsonSerializer.Deserialize<CampoTarefasPOPost>(value, Confs.JsonSerializerOptions); 
        } 

        [JsonIgnore]
        public CampoTarefasPOPost TarefasDoPoObj { get; set; }
    }
}