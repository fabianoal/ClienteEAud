using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Post.CamposPost;

namespace eAudStuffCSharp.EAudTypes.Post
{
    public class CamposInteracaoItemCadastro {
            [JsonPropertyName("tituloBase")]
            public string TextoBase { get; set; }

            [JsonPropertyName("descricaoItem")]
            public string Descricao { get; set; }
    }
}