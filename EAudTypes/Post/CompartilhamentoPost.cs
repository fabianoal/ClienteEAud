using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Post.CamposPost;

namespace eAudStuffCSharp.EAudTypes.Post
{
    public class CompartilhamentoPost    {
        [JsonPropertyName("idUsuario")]
        public int? IdUsuario { get; set; } 

        [JsonPropertyName("idUnidade")]
        public int? IdUnidade { get; set; } 

        [JsonPropertyName("idEquipe")]
        public int? IdEquipe { get; set; } 

        [JsonPropertyName("idPapel")]
        public int? IdPapel { get; set; } 

        [JsonPropertyName("hierarquico")]
        public bool Hierarquico { get; set; } 

        [JsonPropertyName("predefinido")]
        public bool Predefinido { get; set; } 
    }

}