using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace eAudStuffCSharp.EAudTypes.Post.InteracaoPO
{
    public class Campos    {
        [JsonPropertyName("tarefasDoPo")]
        public string TarefasDoPo { get; set; } 
    }

    public class Compartilhamento    {
        [JsonPropertyName("idUsuario")]
        public int? IdUsuario { get; set; } 

        [JsonPropertyName("idUnidade")]
        public int? IdUnidade { get; set; } 

        [JsonPropertyName("idEquipe")]
        public object IdEquipe { get; set; } 

        [JsonPropertyName("idPapel")]
        public int? IdPapel { get; set; } 

        [JsonPropertyName("hierarquico")]
        public bool Hierarquico { get; set; } 

        [JsonPropertyName("predefinido")]
        public bool Predefinido { get; set; } 
    }

    public class InteracaoPO    {
        [JsonPropertyName("idsTarefas")]
        public List<int> IdsTarefas { get; set; } 

        [JsonPropertyName("idTipoInteracao")]
        public string IdTipoInteracao { get; set; } 

        [JsonPropertyName("campos")]
        public Campos Campos { get; set; } 

        [JsonPropertyName("compartilhamentos")]
        public List<Compartilhamento> Compartilhamentos { get; set; } 

        [JsonPropertyName("interacoesAutomaticasOpcionaisARegistrar")]
        public List<object> InteracoesAutomaticasOpcionaisARegistrar { get; set; } 

        [JsonPropertyName("tarefasAutomaticasOpcionaisARegistrar")]
        public List<object> TarefasAutomaticasOpcionaisARegistrar { get; set; } 
    }

}