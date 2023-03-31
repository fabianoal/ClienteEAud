using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Post.CamposPost;
using System.Linq;

namespace eAudStuffCSharp.EAudTypes.Post
{
    public class CamposProgramaPost    {
        [JsonPropertyName("titulo")]
        public string Titulo { get; set; } 

        [JsonPropertyName("prioridade")]
        public string Prioridade { get; set; } 

        [JsonPropertyName("pactuacaoPO")]
        public string PactuacaoPO { get; set; } 

        [JsonPropertyName("gerentePrograma")]
        public string GerentePrograma { get; set; } 

        [JsonPropertyName("codpisiafi")]
        public string Codpisiafi { get; set; } 

        [JsonPropertyName("Detalhamento")]
        public string Detalhamento { get; set; } 

        [JsonPropertyName("descriResultados")]
        public string DescriResultados { get; set; } 

        [JsonPropertyName("resultadosEsperadosPlanoOperacional")]
        public string ResultadosEsperadosPlanoOperacional { 
            get => JsonSerializer.Serialize(ResultadosEsperadosPlanoOperacionalObject, Confs.JsonSerializerOptions);
            set => ResultadosEsperadosPlanoOperacionalObject = JsonSerializer.Deserialize<LinhaResultadoEsperadoPost[]>(value, Confs.JsonSerializerOptions);
        } 

        [JsonIgnore]
        public LinhaResultadoEsperadoPost[] ResultadosEsperadosPlanoOperacionalObject { get; set; }

        [JsonPropertyName("tarefasDoPo")]
        public string TarefasDoPo { 
            get => JsonSerializer.Serialize(TarefasDoPoObj, Confs.JsonSerializerOptions);
            set => JsonSerializer.Deserialize<CampoTarefasPOPost>(value, Confs.JsonSerializerOptions); 
        } 

        [JsonIgnore]
        public CampoTarefasPOPost TarefasDoPoObj { get; set; }

        [JsonPropertyName("tarefaAssociada")]
        public string TarefaAssociada { get; set; } 

        [JsonIgnore]
        public List<int> ListaTarefasPrecedentes {get; set; }

        [JsonPropertyName("tarefasPrecedentes")]
        public string TarefasPrecedentes { 
            get => String.Join(",", ListaTarefasPrecedentes.Select(x => x.ToString()));
            set => ListaTarefasPrecedentes = value.Split(',').Select(x => int.Parse(x)).ToList();
        } 

        [JsonPropertyName("unidadeAnaliseTecnica")]
        public string UnidadeAnaliseTecnica => UnidadeAnaliseTecnicaObj?.Id.ToString() ?? null;

        [JsonIgnore]
        public Query.Unidade UnidadeAnaliseTecnicaObj { get; set; } 

        [JsonPropertyName("flagDescentralizacaoEmSeparado")]
        public bool FlagDescentralizacaoEmSeparado { get; set; }

        [JsonPropertyName("tipoTabelaOrcamento")]
        public string TipoTabelaOrcamento => TipoTabelaOrcamentoObj?.Id.ToString() ?? null; 

        [JsonIgnore]
        public Query.Campos.ValorCampoMultivalorado TipoTabelaOrcamentoObj { get; set; }

        [JsonIgnore]
        public int[] ItensCadeiaDeValor { get; set; }

        [JsonPropertyName("Cvprograma")]
        public string StrItensCadeiaValor { get => ItensCadeiaDeValor?.Count() > 0 ? String.Join(',', ItensCadeiaDeValor) : null; }

        [JsonPropertyName("unidadeApoioGerentePrograma")]
        public string UnidadeApoioGerentePrograma { get; set; }

        [JsonPropertyName("itensPermitidos")]
        public string ItensPermitidos { get; set; }
    }

}