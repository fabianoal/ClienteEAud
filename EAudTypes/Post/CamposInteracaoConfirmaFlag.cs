using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Post.CamposPost;

namespace eAudStuffCSharp.EAudTypes.Post
{
    public class CamposInteracaoConfirmaFlag {
        [JsonPropertyName("flagProgramaProximoExercicioGerado")]
        public bool FlagProgramaProximoExercicioGerado { get; set; } 

    }
}