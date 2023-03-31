using System.Text.Json.Serialization;
namespace eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares {
    public class Lotacao {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nomeExibicao")]
        public string NomeExibicao { get; set; }

        [JsonPropertyName("ehGestor")]
        public bool EhGestor { get; set; }

        [JsonPropertyName("estaLotadoFisicamente")]
        public bool EstaLotadoFisicamente { get; set; }

        [JsonPropertyName("equipes")]
        public Equipe[] Equipes { get; set; }
    }

}