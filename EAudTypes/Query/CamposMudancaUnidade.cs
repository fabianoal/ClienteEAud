using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.Campos;
using eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares;

namespace eAudStuffCSharp.EAudTypes.Query {
    public class CamposMudancaUnidade : CamposLotacao    {
        
        [JsonPropertyName("MudancaEquipamentos")]
        public CampoGenerico<List<ValorCampoMultivalorado>> MudancaEquipamentos { get; set; } 

        [JsonPropertyName("MudancaMobilia")]
        public CampoGenerico<List<ValorCampoMultivalorado>> MudancaMobilia { get; set; } 

        [JsonPropertyName("cpfServidor")]
        public CampoGenerico<string> CpfServidor { get; set; } 

        [JsonPropertyName("flagPedidoMudancaComplementado")]
        public CampoGenerico<int?> FlagPedidoMudancaComplementado { get; set; } 

        [JsonPropertyName("listaEquipamentosInformatica")]
        public CampoGenerico<string> ListaEquipamentosInformatica { get; set; } 
        
        [JsonPropertyName("listaMobiliarioUsuario")]
        public CampoGenerico<string> ListaMobiliarioUsuario { get; set; } 

        [JsonPropertyName("ramalDoSolicitante")]
        public CampoGenerico<string> RamalDoSolicitante { get; set; } 
        
        [JsonPropertyName("unidadeOrigem")]
        public CampoGenerico<Unidade> UnidadeOrigem { get; set; } 

        [JsonPropertyName("identificador")]
        public CampoGenerico<int?> Identificador { get; set; }

        [JsonPropertyName("nomeacaoVinculada")]
        public CampoGenerico<TarefaReferenciada> NomeacaoVinculada { get; set; }


    }
}