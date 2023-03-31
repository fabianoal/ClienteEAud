using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.Campos;
using eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares;

namespace eAudStuffCSharp.EAudTypes.Query {
    public class CamposAtendimentoRequisicao : CamposTarefa    {
        
        [JsonPropertyName("Detalhamento")]
        public CampoGenerico<string> Detalhamento { get; set; } 

        [JsonPropertyName("unidadeOrigem")]
        public CampoGenerico<Unidade> UnidadeOrigem { get; set; } 

        [JsonPropertyName("unidadeDestino")]
        public CampoGenerico<Unidade> UnidadeDestino { get; set; } 
        
        [JsonPropertyName("usuarioAlvoSei")]
        public CampoGenerico<ValorCampoMultivalorado> UsuarioAlvoSei { get; set; } 

        [JsonPropertyName("nomeacaoVinculada")]
        public CampoGenerico<TarefaReferenciada> NomeacaoVinculada { get; set; }

        [JsonPropertyName("cargoOuFuncao")]
        public CampoGenerico<ValorCampoMultivalorado> CargoOuFuncao { get; set; } 
    }
}