using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Post.CamposPost;
using System.Linq;

namespace eAudStuffCSharp.EAudTypes.Post
{
    public class CamposSolicitacaoOrcamentoPost    {

        [JsonPropertyName("titulo")]
        public string Titulo { get; set; } 

        [JsonPropertyName("prioridade")]
        public string Prioridade { get; set; } 

        [JsonPropertyName("tarefaAssociada")]
        public int IdTarefaAssociada { get; set; }

        [JsonPropertyName("unidEnvolvidas")]
        public int[] UnidadesEnvolvidas { get; set; } 

        [JsonPropertyName("Detalhamento")]
        public string Detalhamento { get; set; } 

        [JsonPropertyName("sorcOrcamento")]
        public string TabelaSolicitacaoOrcamento => JsonSerializer.Serialize(TabelaSolicitacaoOrcamentoObj, Confs.JsonSerializerOptions);

        [JsonIgnore]
        public TabelaPost TabelaSolicitacaoOrcamentoObj { get; set; } 

        [JsonPropertyName("ptaa")]
        public int? PlanoTrabalhoAssociado { get; set; } 

        [JsonPropertyName("etapaOrcamento")]
        public int? EtapaOrcamento { get; set; } 

        [JsonPropertyName("planoOperacionalOrcamento")]
        public int ProgramaOrcamento { get; set; } 

        [JsonPropertyName("gerenteInteracao")]
        public int? GerenteInteracao { get; set; } 

        [JsonPropertyName("EquipeGeral")]
        public string EquipeGeral { get; set; } 

        [JsonPropertyName("supervisores")]
        public string Supervisores { get; set; } 

        [JsonPropertyName("CoordenadorEquipe")]
        public string Coordenadores { get; set; } 

        [JsonPropertyName("gerentePrograma")]
        public int[] GerentesPrograma { get; set; } 
    }

}