using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Post.CamposPost;

namespace eAudStuffCSharp.EAudTypes.Post
{
    public class CamposInteracaoNomeacao {
        [JsonPropertyName("servidor")]
        public int IdServidor { get; set; } 

        [JsonPropertyName("cargoOuFuncao")]
        public int IdCargoFuncao { get; set; }

        [JsonPropertyName("unidadeOrigem")]
        public int? IdUnidadeOrigem { get; set; }        

        [JsonPropertyName("unidadeDestino")]
        public int IdUnidadeDestino { get; set; }

        [JsonPropertyName("tipoNomeacao")]
        public int IdTipoNomeacao { get; set; }
        
        [JsonPropertyName("dataPublicacaoDOU")]
        //[JsonConverter(typeof(Util.DateTimeConverter))]
        public string DataNomeacao { get; set; }

    }
}