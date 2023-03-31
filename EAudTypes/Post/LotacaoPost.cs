using System;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Post.CamposPost;

namespace eAudStuffCSharp.EAudTypes.Post{
    public class LotacaoPost {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nomeExibicao")]
        public string NomeExibicao { get; set; }

        [JsonPropertyName("ehGestor")]
        public bool EhGestor { get; set; }

        [JsonPropertyName("estaLotadoFisicamente")]
        public bool EstaLotadoFisicamente { get; set; }

        [JsonPropertyName("equipes")]
        public int[] Equipes { get; set; }
    }
}