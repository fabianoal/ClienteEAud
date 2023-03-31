using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Post.CamposPost;
using System.Linq;

namespace eAudStuffCSharp.EAudTypes.Post
{
    public class CamposPlanoOperacionalPost    {

        [JsonPropertyName("titulo")]
        public string Titulo { get; set; } 

        [JsonPropertyName("prioridade")]
        public string Prioridade { get; set; } 

        [JsonPropertyName("pactuacaoPO")]
        public string PactuacaoPO { get; set; } 

        [JsonPropertyName("unidadesPO")]
        public string StrUnidadesPO { get => String.Join(',', UnidadesPO); }

        [JsonIgnore]
        public int[] UnidadesPO { get; set; }

        [JsonIgnore]
        public List<int> ListaTarefasPrecedentes {get; set; }

        [JsonPropertyName("tarefasPrecedentes")]
        public string TarefasPrecedentes { 
            get => String.Join(",", ListaTarefasPrecedentes.Select(x => x.ToString()));
            set => ListaTarefasPrecedentes = value.Split(',').Select(x => int.Parse(x)).ToList();
        } 


        [JsonPropertyName("tarefasDoPo")]
        public string TarefasDoPo { 
            get => JsonSerializer.Serialize(TarefasDoPoObj, Confs.JsonSerializerOptions);
            set => JsonSerializer.Deserialize<CampoTarefasPOPost>(value, Confs.JsonSerializerOptions); 
        } 

        [JsonIgnore]
        public CampoTarefasPOPost TarefasDoPoObj { get; set; }

    }
}