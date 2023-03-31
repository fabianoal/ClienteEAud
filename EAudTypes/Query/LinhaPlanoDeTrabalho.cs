using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.Campos;

namespace eAudStuffCSharp.EAudTypes.Query
{
    public class LinhaPlanoDeTrabalho  {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("situacao")]
        public string Situacao { get; set; }

        [JsonPropertyName("titulo")]
        public string Titulo { get; set; }

        [JsonPropertyName("idTarefaAssociada")]
        public int IdTarefaAssociada { get; set; }

        [JsonPropertyName("tituloTarefaAssociada")]
        public string TituloTarefaAssociada { get; set; }

        [JsonPropertyName("dtPrevisaoInicio")]
        public string DtPrevisaoInicio { get; set; }

        [JsonPropertyName("dtPrevisaoFim")]
        public string DtPrevisaoFim { get; set; }

        [JsonPropertyName("dtRealizadaInicio")]
        public string DtRealizadaInicio { get; set; }

        [JsonPropertyName("dtRealizadaFim")]
        public string DtRealizadaFim { get; set; }

        [JsonPropertyName("prioridade")]
        public string Prioridade { get; set; }

        [JsonPropertyName("favorita")]
        public bool Favorita { get; set; }


        [JsonPropertyName("tags")]
        public List<object> Tags { get; set; }

        [JsonPropertyName("localidade")]
        public object Localidade { get; set; }

        [JsonPropertyName("duracaoMeses")]
        public int DuracaoMeses { get; set; }

        [JsonPropertyName("homemHora")]
        public int HomemHora { get; set; }

        [JsonPropertyName("recursoFinanceiro")]
        public string RecursoFinanceiro { get; set; }

        [JsonPropertyName("processoTrabalho")]
        public string ProcessoTrabalho { get; set; }

        [JsonPropertyName("indicador")]
        public object Indicador { get; set; }

        [JsonPropertyName("mesConclusao")]
        public object MesConclusao { get; set; }

        [JsonPropertyName("mesConclusaoPrevisto")]
        public object MesConclusaoPrevisto { get; set; }

        [JsonPropertyName("mesConclusaoRealizado")]
        public object MesConclusaoRealizado { get; set; }

        [JsonPropertyName("recursoFinanceiroSomatorio")]
        public string RecursoFinanceiroSomatorio { get; set; }

        [JsonPropertyName("quantidade")]
        public object Quantidade { get; set; }

        [JsonPropertyName("homemHoraSomatorio")]
        public object HomemHoraSomatorio { get; set; }

        [JsonPropertyName("valorIndicadorSomatorio")]
        public string ValorIndicadorSomatorio { get; set; }

        [JsonPropertyName("etapa")]
        public string Etapa { get; set; }

        [JsonPropertyName("objetivo")]
        public string Objetivo { get; set; }

        [JsonPropertyName("tipo")]
        public string Tipo { get; set; }

        [JsonPropertyName("valorParaFiltragemDeFatiaDeGrafico")]
        public string ValorParaFiltragemDeFatiaDeGrafico { get; set; }

        [JsonPropertyName("gerente")]
        public string Gerente { get; set; }

        [JsonPropertyName("unidadesEnvolvidasGrafico")]
        public string UnidadesEnvolvidasGrafico { get; set; }

        [JsonPropertyName("unidadesEnvolvidas")]
        public List<string> UnidadesEnvolvidas { get; set; }

        [JsonPropertyName("pendencias")]
        public List<object> Pendencias { get; set; }

        [JsonPropertyName("localidades")]
        public List<string> Localidades { get; set; }
    }
}
