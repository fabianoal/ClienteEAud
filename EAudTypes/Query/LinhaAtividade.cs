using System.Text.Json.Serialization;

namespace eAudStuffCSharp.EAudTypes.Query {
    public class LinhaAtividade    {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("nome")]
        public string Nome { get; set; } 

        [JsonPropertyName("codigo")]
        public string Codigo { get; set; } 

        [JsonPropertyName("assunto")]
        public string Assunto { get; set; } 

        [JsonPropertyName("nomeAssunto")]
        public string NomeAssunto { get; set; } 

        [JsonPropertyName("ativo")]
        public bool Ativo { get; set; } 

        [JsonPropertyName("idTipoInteracaoCadastroViaGantt")]
        public object IdTipoInteracaoCadastroViaGantt { get; set; } 

        [JsonPropertyName("donoAtividade")]
        public bool DonoAtividade { get; set; } 
    }
}