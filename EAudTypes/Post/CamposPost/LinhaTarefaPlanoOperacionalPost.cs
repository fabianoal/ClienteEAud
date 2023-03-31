using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares;

namespace eAudStuffCSharp.EAudTypes.Post.CamposPost
{
    public class LinhaTarefaPlanoOperacionalPost    {
        [JsonPropertyName("idPlanoOperacional")]
        public int IdPlanoOperacional { get; set; }

        [JsonPropertyName("id")]
        public object Id { get; set; } 

        [JsonPropertyName("idTarefa")]
        public int IdTarefa { get; set; } 

        [JsonPropertyName("idTarefaPai")]
        public int? IdTarefaPai { get; set; } 

        [JsonPropertyName("tituloTarefaPai")]
        public string TituloTarefaPai { get; set; } 

        [JsonPropertyName("tituloTarefa")]
        public string TituloTarefa { get; set; } 

        [JsonPropertyName("hhTotal")]
        public int HhTotal { get; set; } 

        [JsonPropertyName("hhTotalAlocado")]
        public int HhTotalAlocado { get; set; } 

        [JsonPropertyName("hhDisponivelNasUnidades")]
        public int HhDisponivelNasUnidades { get; set; } 

        [JsonPropertyName("hhTotalRealizado")]
        public int HhTotalRealizado { get; set; } 

        [JsonPropertyName("valorCusteio")]
        public string ValorCusteio { get; set; } 

        [JsonPropertyName("totalAlocadoValorCusteio")]
        public int TotalAlocadoValorCusteio { get; set; }

        [JsonPropertyName("valorInvestimento")]
        public string ValorInvestimento { get; set; } 

        [JsonPropertyName("totalAlocadoValorInvestimento")]
        public int TotalAlocadoValorInvestimento { get; set; }

        [JsonPropertyName("recursosFinanceirosTarefa")]
        public int RecursosFinanceirosTarefa { get; set; } 

        [JsonPropertyName("idTipoAlocacao")]
        public int IdTipoAlocacao { get; set; } 

        [JsonPropertyName("alocacoesTarefaPlanoOperacional")]
        public AlocacaoPO[] AlocacoesTarefaPlanoOperacional { get; set; } 

        [JsonPropertyName("situacao")]
        public string Situacao { get; set; } 

        [JsonPropertyName("impacto")]
        public string Impacto { get; set; } 

    }
}