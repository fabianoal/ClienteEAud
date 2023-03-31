using System;
using System.Text.Json.Serialization;
namespace eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares {
    public class AlocacaoPO    {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("idUsuario")]
        public int IdUsuario { get; set; } 

        [JsonPropertyName("nomeUsuario")]
        public string NomeUsuario { get; set; } 

        [JsonPropertyName("idUnidadePrincipal")]
        public int? IdUnidadePrincipal { get; set; } 

        [JsonPropertyName("dataInicioAlocacao")]
        [JsonConverter(typeof(Util.DateInternationalConverter))]
        public DateTime? DataInicioAlocacao { get; set; } 

        [JsonPropertyName("dataFimAlocacao")]
        [JsonConverter(typeof(Util.DateInternationalConverter))]
        public DateTime? DataFimAlocacao { get; set; } 

        [JsonPropertyName("hhTotalPeriodo")]
        public double? HhTotalPeriodo { get; set; } 

        [JsonPropertyName("hhOutrasTarefas")]
        public double? HhOutrasTarefas { get; set; } 

        [JsonPropertyName("qtdHomensHoraAlocacao")]
        public double? QtdHomensHoraAlocacao { get; set; } 

        [JsonPropertyName("hhDisponivel")]
        public double? HhDisponivel { get; set; }
    }

}