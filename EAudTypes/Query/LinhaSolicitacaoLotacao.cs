using System;
using System.Text;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace eAudStuffCSharp.EAudTypes.Query {
// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class LinhaSolicitacaoLotacao    {
        [JsonPropertyName("cpfUsuario")]
        public string CpfUsuario { get; set; } 

        [JsonPropertyName("nomeUsuario")]
        public string NomeUsuario { get; set; } 

        [JsonPropertyName("unidade")]
        public string Unidade { get; set; } 

        [JsonPropertyName("situacao")]
        public string Situacao { get; set; } 

        [JsonPropertyName("dataSolicitacao")]
        [JsonConverter(typeof(Util.DateTimeConverter))]
        public DateTime? DataSolicitacao { get; set; } 

        [JsonPropertyName("atendimento")]
        public string Atendimento { get; set; } 

        private string token;

        [JsonPropertyName("token")]
        public string Token { 
            get => token; 
            set {
                token = value;
                var valueBytes = System.Convert.FromBase64String(token);
                var tokenDecoded = Encoding.UTF8.GetString(valueBytes);
                id = int.Parse(tokenDecoded.Split("=")[1]);
            } 
        } 

        private int? id;
            
        public int Id => id.Value;
    }
}