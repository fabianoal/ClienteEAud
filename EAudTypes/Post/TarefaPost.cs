using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Post.CamposPost;

namespace eAudStuffCSharp.EAudTypes.Post
{
    public class TarefaPost<T>    {
        [JsonPropertyName("id")]
        public string Id { get; set; } 

        [JsonPropertyName("codigoAtividade")]
        public string CodigoAtividade { get; set; } 

        [JsonPropertyName("campos")]
        public T Campos { get; set; } 

        [JsonPropertyName("compartilhamentos")]
        public List<CompartilhamentoPost> Compartilhamentos { get; set; } 

        [JsonPropertyName("recarregaDadosUsuario")]
        public bool RecarregaDadosUsuario { get; set; } 

        [JsonIgnore]
        public int IdTarefaGerada { get; set; }

        [JsonIgnore]
        public bool FlagEmPredecessoraMarcada { get; set; }

        [JsonIgnore]
        public bool PredecessoraAtualizada {get ;set; } 
    }
}