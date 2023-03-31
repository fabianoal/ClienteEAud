using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.Campos;


namespace eAudStuffCSharp.EAudTypes.Query {
    public class CamposPrograma : CamposTarefa    {
        
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
        public CampoGenerico<string> CodPISiafi { get; set; } 
       
        [JsonPropertyName("exercicio")]
        public CampoGenerico<int?> Exercicio { get; set; } 

        [JsonPropertyName("descriResultados")]
        public CampoGenerico<string> DescriResultados { get; set; } 

        [JsonPropertyName("flagProgramaProximoExercicioGerado")]
        public CampoGenerico<int?> FlagProgramaProximoExercicioGerado { get; set; } 

        [JsonPropertyName("tarefasDoPo")]
        public CampoGenerico<ValorTarefasDoPO[]> TarefasDoPo { get; set; } 

        [JsonPropertyName("gerentePrograma")]
        public CampoGenerico<ValorCampoMultivalorado[]> GerentePrograma { get; set; } 

        [JsonPropertyName("unidadesPO")]
        public CampoGenerico<Unidade[]> UnidadesPO { get; set; } 

        [JsonPropertyName("nomeCompleto")]
        public CampoGenerico<string> NomeCompleto { get; set; } 

        [JsonPropertyName("prioridade")]
        public CampoGenerico<ValorCampoMultivalorado> Prioridade { get; set; }

        [JsonPropertyName("tipoTabelaOrcamento")]
        public CampoGenerico<ValorCampoMultivalorado> TipoTabelaOrcamento { get; set; }

        [JsonPropertyName("flagDescentralizacaoEmSeparado")]
        //[JsonConverter(typeof(Util.BooleanConverter))]
        public CampoGenerico<int?> FlagDescentralizacaoEmSeparado { get; set; }

        [JsonPropertyName("unidadeAnaliseTecnica")]
        public CampoGenerico<Unidade> UnidadeAnaliseTecnica { get; set; }

        [JsonPropertyName("Cvprograma")]
        public CampoGenerico<ValorCampoMultivalorado[]> CadeiaDeValor { get; set; } 

        [JsonPropertyName("unidadeApoioGerentePrograma")]
        public CampoGenerico<Unidade> UnidadeApoioGerentePrograma { get; set; }


        [JsonPropertyName("itensPermitidos")]
        public CampoGenerico<string> ItensPermitidos { get; set; }

        [JsonPropertyName("valorCusteioPO")]
        public CampoGenerico<double?> ValorCusteioPO { get; set; }

        [JsonPropertyName("valorInvestimentoPO")]
        public CampoGenerico<double?> ValorInvestimentoPO { get; set; }

        [JsonPropertyName("PrelimPloacusteio")]
        public CampoGenerico<double?> PrelimPloacusteio { get; set; }

        [JsonPropertyName("PrelimPloaInvest")]
        public CampoGenerico<double?> PrelimPloaInvest { get; set; }
        
        [JsonPropertyName("PropostaUnidadeCusteio")]
        public CampoGenerico<double?> PropostaUnidadeCusteio { get; set; }

        [JsonPropertyName("MetodologiaCalculoPropostaCusteio")]
        public CampoGenerico<string> MetodologiaCalculoPropostaCusteio { get; set; }

    }

}