using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.Campos;
using eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares;

namespace eAudStuffCSharp.EAudTypes.Query {
    public class CamposOrcamento : CamposTarefa    {
        
        [JsonPropertyName("sorcOrcamento")]
        public CampoGenericoTabela TabelaSolicitacaoOrcamento { get; set; } 

        [JsonPropertyName("orcInfra")]
        public CampoGenericoTabela TabelaOrcamentoInfra { get; set; } 

        [JsonPropertyName("solinfrdti")]
        public CampoGenericoTabela TabelaOrcamentoInfraTI { get; set; } 

        [JsonPropertyName("unidEnvolvidas")]
        public CampoGenerico<List<Unidade>> UnidadesEnvolvidas { get; set; } 

        [JsonPropertyName("apoiadm")]
        public CampoGenerico<Unidade> UnidadeApoioAdministrativo { get; set; } 

        [JsonPropertyName("tabdesccred")]
        public CampoGenericoTabela TabelaDescentralizacaoCredito { get; set; } 

        [JsonPropertyName("anexosGerais")]
        public CampoGenerico<List<Anexo>> AnexosGerais { get; set; } 

        [JsonPropertyName("Detalhamento")]
        public CampoGenerico<string> Detalhamento { get; set; } 
        
        [JsonPropertyName("codpisiafi")]
        public CampoGenerico<string> CodPISiafi { get; set; } 

        [JsonPropertyName("ptaa")]
        public CampoGenerico<TarefaReferenciada> PlanoTrabalhoAssociado { get; set; } 
        
        [JsonPropertyName("superR")]
        public CampoGenerico<ValorCampoMultivalorado> SuperintendenteRegional { get; set; } 

        [JsonPropertyName("etapaOrcamento")]
        public CampoGenerico<ValorCampoMultivalorado> EtapaOrcamento { get; set; } 

        [JsonPropertyName("planoOperacionalOrcamento")]
        public CampoGenerico<TarefaReferenciada> ProgramaOrcamento { get; set; } 

        [JsonPropertyName("gerenteInteracao")]
        public CampoGenerico<ValorCampoMultivalorado> GerenteInteracao { get; set; } 

        [JsonPropertyName("EquipeGeral")]
        public CampoGenerico<ValorCampoMultivalorado[]> EquipeGeral { get; set; } 

        [JsonPropertyName("equipesdetrab")]
        public CampoGenerico<ValorCampoMultivalorado[]> EquipesDeTrabalho { get; set; } 

        [JsonPropertyName("supervisores")]
        public CampoGenerico<ValorCampoMultivalorado[]> Supervisores { get; set; } 

        [JsonPropertyName("gerentePrograma")]
        public CampoGenerico<ValorCampoMultivalorado[]> GerentesPrograma { get; set; } 

        [JsonPropertyName("plorcament")]
        public CampoGenerico<ValorCampoMultivalorado> PlanoOrcamentario { get; set; } 
    }
}