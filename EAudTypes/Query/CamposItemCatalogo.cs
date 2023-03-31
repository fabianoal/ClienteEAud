using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.Campos;
using eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares;

namespace eAudStuffCSharp.EAudTypes.Query {
    public class CamposItemCatalogo : CamposTarefa    {
        
        [JsonPropertyName("dadosSensiveisPessoa")]
        public CampoGenerico<ValorCampoMultivalorado> DadosSensiveisPessoa { get; set; } 

        [JsonPropertyName("basePrincipal")]
        public CampoGenerico<ValorCampoMultivalorado> BasePrincipal { get; set; } 

        [JsonPropertyName("periodicidadeAtualizacao")]
        public CampoGenerico<ValorCampoMultivalorado> PeriodicidadeAtualizacao { get; set; } 

        [JsonPropertyName("baseLegalPublicacaoSemDescaracterizacao")]
        public CampoGenerico<string> BaseLegalPublicacaoSemDescaracterizacao { get; set; } 

        [JsonPropertyName("Detalhamento")]
        public CampoGenerico<string> Detalhamento { get; set; } 

        [JsonPropertyName("localDeHospedagem")]
        public CampoGenerico<ValorCampoMultivalorado> LocalDeHospedagem { get; set; } 
        
        [JsonPropertyName("dadosSensiveisIdentificaveis")]
        public CampoGenerico<ValorCampoMultivalorado> DadosSensiveisIdentificaveis { get; set; } 

        [JsonPropertyName("situacaoDaBaseOuSolucao")]
        public CampoGenerico<ValorCampoMultivalorado> SituacaoDaBaseOuSolucao { get; set; } 

        [JsonPropertyName("indicadorCDB")]
        public CampoGenericoBoolean IndicadorCDB { get; set; } 

        [JsonPropertyName("mecanismoDeDisponibilizacaoAltaGestao")]
        public CampoGenerico<string> MecanismoDeDisponibilizacaoAltaGestao { get; set; } 

        [JsonPropertyName("informacoesSigilosas")]
        public CampoGenerico<ValorCampoMultivalorado> InformacoesSigilosas { get; set; } 

        [JsonPropertyName("disponibilizaAcessoDocumentos")]
        public CampoGenerico<ValorCampoMultivalorado> DisponibilizaAcessoDocumentos { get; set; } 

        [JsonPropertyName("haInformacoesPublicas")]
        public CampoGenerico<ValorCampoMultivalorado> HaInformacoesPublicas { get; set; } 

        [JsonPropertyName("grauSigilo")]
        public CampoGenerico<ValorCampoMultivalorado> GrauSigilo { get; set; } 

        [JsonPropertyName("linkDadosAbertos")]
        public CampoGenerico<object> LinkDadosAbertos { get; set; } 

        [JsonPropertyName("nomeBaseDados")]
        public CampoGenerico<object> NomeBaseDados { get; set; } 

        [JsonPropertyName("docPreparatorioGeraInfoClassificada")]
        public CampoGenerico<ValorCampoMultivalorado> DocPreparatorioGeraInfoClassificada { get; set; } 

        [JsonPropertyName("tipoDaBaseDeDados")]
        public CampoGenerico<ValorCampoMultivalorado> TipoDaBaseDeDados { get; set; } 

        [JsonPropertyName("aderenteLGPD")]
        public CampoGenerico<ValorCampoMultivalorado> AderenteLGPD { get; set; } 

        [JsonPropertyName("mecanismoDeAcessoBaseDeDados")]
        public CampoGenerico<string> MecanismoDeAcessoBaseDeDados { get; set; } 

        [JsonPropertyName("unidadesGestoraDoItem")]
        public CampoGenerico<Unidade[]> UnidadesGestoraDoItem { get; set; } 

        [JsonPropertyName("siglaDaBaseDeDados")]
        public CampoGenerico<string> SiglaDaBaseDeDados { get; set; } 

        [JsonPropertyName("detalhamentoDoItem")]
        public CampoGenerico<string> DetalhamentoDoItem { get; set; } 

        [JsonPropertyName("publicadorDados")]
        public CampoGenerico<Unidade> PublicadorDados { get; set; } 

        [JsonPropertyName("gestoresBaseDados")]
        public CampoGenerico<ValorCampoMultivalorado[]> GestoresBaseDados { get; set; } 
        
        [JsonPropertyName("suportaTomadaDecisoes")]
        public CampoGenerico<ValorCampoMultivalorado> SuportaTomadaDecisoes { get; set; } 

        [JsonPropertyName("idHPSM")]
        public CampoGenerico<string> IdHPSM { get; set; } 

        [JsonPropertyName("propriedadeDoItem")]
        public CampoGenerico<ValorCampoMultivalorado> PropriedadeDoItem { get; set; } 

        [JsonPropertyName("referenciaBasePrincipal")]
        public CampoGenerico<TarefaReferenciada> ReferenciaBasePrincipal { get; set; } 

        [JsonPropertyName("legislacaoSigilo")]
        public CampoGenerico<string> LegislacaoSigilo { get; set; } 

        [JsonPropertyName("baseCompartilhada")]
        public CampoGenerico<ValorCampoMultivalorado> BaseCompartilhada { get; set; } 

        [JsonPropertyName("dadosIdentificaveisPessoa")]
        public CampoGenerico<ValorCampoMultivalorado> DadosIdentificaveisPessoa { get; set; } 
                
        [JsonPropertyName("baseDadosDestino")]
        public CampoGenerico<TarefaReferenciada> BaseDadosDestino { get; set; } 

        [JsonPropertyName("interesseIniciativaPrivada")]
        public CampoGenerico<ValorCampoMultivalorado> InteresseIniciativaPrivada { get; set; } 
    }
}