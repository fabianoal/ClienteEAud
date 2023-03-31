using System;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares;

namespace eAudStuffCSharp.EAudTypes.Query.Campos {

    public class ValorTarefasDoPO    {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("custoDaHora")]
        public double? CustoDaHora { get; set; } 

        [JsonPropertyName("hhDisponivelNasUnidades")]
        public double? HhDisponivelNasUnidades { get; set; } 

        [JsonPropertyName("valorCusteio")]
        public double? ValorCusteio { get; set; } 

        [JsonPropertyName("valorInvestimento")]
        public double? ValorInvestimento { get; set; } 
        
        [JsonPropertyName("idTarefa")]
        public int IdTarefa { get; set; } 

        [JsonPropertyName("tituloTarefa")]
        public string TituloTarefa { get; set; } 

        [JsonIgnore]
        public string TituloTarefaSanitizado => Util.TextFunctions.SanitizaTexto(TituloTarefa);

        [JsonPropertyName("dataRealizadaInicioTarefa")]
        [JsonConverter(typeof(Util.DateTimeConverter))]


        private static Regex r = new Regex(".*\\[([A-Z]*)\\]$");

        [JsonIgnore]
        public bool HasSufixoUnidade => r.IsMatch(this.TituloTarefa);

        [JsonIgnore]
        public string UnidadeDoTitulo =>
                HasSufixoUnidade
                    ? r.Match(this.TituloTarefa).Groups[1].Value
                    : null;
        public DateTime? DataRealizadaInicioTarefa { get; set; } 

        [JsonPropertyName("dataRealizadaFimTarefa")]
        [JsonConverter(typeof(Util.DateTimeConverter))]
        public DateTime? DataRealizadaFimTarefa { get; set; } 

        [JsonPropertyName("idTarefaPai")]
        public int? IdTarefaPai { get; set; } 

        [JsonPropertyName("tituloTarefaPai")]
        public string TituloTarefaPai { get; set; } 

        [JsonIgnore]
        public string TituloTarefaPaiSanitizado => Util.TextFunctions.SanitizaTexto(TituloTarefaPai);

        [JsonPropertyName("tarefaPai")]
        public string TarefaPai { get; set; } 

        [JsonPropertyName("hhTotal")]
        public double? HhTotal { get; set; } 

        [JsonPropertyName("recursosFinanceirosTarefa")]
        public double? RecursosFinanceirosTarefa { get; set; } 

        [JsonPropertyName("situacao")]
        public string Situacao { get; set; } 

        [JsonPropertyName("hhTotalAlocado")]
        public double? HhTotalAlocado { get; set; } 

        [JsonPropertyName("idTipoAlocacao")]
        public int? IdTipoAlocacao { get; set; } 

        [JsonPropertyName("impacto")]
        public string Impacto { get; set; } 

        [JsonPropertyName("alocacoesTarefaPlanoOperacional")]
        public AlocacaoPO[] AlocacoesTarefaPlanoOperacional { get; set; } 
    }
}