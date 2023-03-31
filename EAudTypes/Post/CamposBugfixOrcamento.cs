using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Post.CamposPost;

namespace eAudStuffCSharp.EAudTypes.Post
{
    public class CamposBugfixOrcamento {

        [JsonPropertyName("sorcOrcamento")]
        public string SorcOrcamento => JsonSerializer.Serialize(SorcOrcamentoObj, Confs.JsonSerializerOptions);

        [JsonIgnore]
        public TabelaPost SorcOrcamentoObj { get; set; }

    }
}