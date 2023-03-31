using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Post.CamposPost;

namespace eAudStuffCSharp.EAudTypes.Post
{
    public class CamposInteracaoFixaNomeacao {
        [JsonPropertyName("cargoOuFuncao")]
        public int IdCargoFuncao { get; set; }
    }
}