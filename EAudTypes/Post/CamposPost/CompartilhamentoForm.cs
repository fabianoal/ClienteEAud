using System;
using System.Text.Json.Serialization;

namespace eAudStuffCSharp.EAudTypes.Post.CamposPost{
    public class CompartilhamentoForm {
            [JsonPropertyName("idUsuario")]
            public int? IdUsuario { get; set; } 

            [JsonPropertyName("idUnidade")]
            public int? IdUnidade { get; set; } 

            [JsonPropertyName("idPapel")]
            public int IdPapel { get; set; } 

            [JsonPropertyName("hierarquico")]
            public bool Hierarquico { get; set; } 


            [JsonPropertyName("predefinido")]
            public bool Predefinido { get; set; } 
    }
}