using System.Text.Json.Serialization;
namespace eAudStuffCSharp.EAudTypes.Query.Campos {

    
    public class ValorCampoMultivalorado    {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("ordem")]
        public int Ordem { get; set; } 

        [JsonPropertyName("valor")]
        public string Valor { get; set; } 

        [JsonPropertyName("nome")]
        public string Nome { get; set; } 

        [JsonPropertyName("nomeExibicao")]
        public string NomeExibicao { get; set; } 

        [JsonIgnore]
        public string ValorNomeOuNomeExibicao => Valor ?? Nome ?? NomeExibicao;
    }

}