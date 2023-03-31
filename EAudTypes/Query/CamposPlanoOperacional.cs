using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Linq;

using eAudStuffCSharp.EAudTypes.Query.Campos;

namespace eAudStuffCSharp.EAudTypes.Query {
    public class CamposPlanoOperacional : CamposTarefa    {
        
        [JsonPropertyName("pactuacaoPO")]
        public CampoGenerico<ValorPactuacaoPO> PactuacaoPO { get; set; } 

        [JsonPropertyName("resultadosEsperadosPlanoOperacional")]
        public CampoGenerico<List<ValorCampoObjetivoEstrategico>> ResultadosEsperadosPlanoOperacional { get; set; } 

        [JsonPropertyName("custoPrevistoPO")]
        public CampoGenerico<double?> CustoPrevistoPO { get; set; } 

        [JsonPropertyName("anexosGerais")]
        public CampoGenerico<object> AnexosGerais { get; set; } 

        [JsonPropertyName("Detalhamento")]
        public CampoGenerico<string> Detalhamento { get; set; } 
        
        [JsonPropertyName("codpisiafi")]
        public CampoGenerico<string> Codpisiafi { get; set; } 
       
        [JsonPropertyName("exercicio")]
        public CampoGenerico<int?> Exercicio { get; set; } 

        [JsonPropertyName("descriResultados")]
        public CampoGenerico<string> DescriResultados { get; set; } 

        [JsonPropertyName("tarefasDoPo")]
        public CampoGenerico<List<ValorTarefasDoPO>> TarefasDoPo { get; set; } 

        [JsonPropertyName("unidadesPO")]
        public CampoGenerico<List<Unidade>> UnidadesPO { get; set; } 

        [JsonIgnore]
        private IEnumerable<Unidade> UnidadesOrdenadas => UnidadesPO?.Valor?
                .OrderBy(x => x.Hierarquia.Where(z => z.Equals('|')).Count())
                .ThenBy(x => x.Id);

        [JsonIgnore]
        public Unidade UnidadePrincipal => UnidadesOrdenadas?.First();

        [JsonIgnore]
        public bool HasConflitoUnidadesPrincipais =>

            (UnidadesOrdenadas?
                .Select(x => new { 
                        Nivel = x.Hierarquia.Where(z => z.Equals('|')).Count(),
                        Id = x.Id
                    })
                .GroupBy(x => x.Nivel)
                .Select(x => new {
                    Nivel = x.Key,
                    Qtd = x.Count()
                })
                .OrderBy(x => x.Nivel)
                .First()
                .Qtd) > 1;

        [JsonIgnore]
        public bool IsPoRegional => 
            UnidadePrincipal != null 
                ? UnidadePrincipal.SiglaSimples.StartsWith("CGU") && 
                  UnidadePrincipal.SiglaSimples.Length == 5 && 
                  !UnidadePrincipal.SiglaSimples.EndsWith("NE") 
                  && UnidadePrincipal.Codigo.StartsWith("SIAPE")
                : false;

        [JsonPropertyName("prioridade")]
        public CampoGenerico<ValorCampoMultivalorado> Prioridade { get; set; }

    }

}