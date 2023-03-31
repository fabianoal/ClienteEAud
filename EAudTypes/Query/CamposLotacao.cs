using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.Campos;
using eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares;

namespace eAudStuffCSharp.EAudTypes.Query {
    public class CamposLotacao : CamposTarefa    {
        
        [JsonPropertyName("unidadeDestino")]
        public CampoGenerico<Unidade> UnidadeDestino { get; set; } 
        
        [JsonPropertyName("usuarioAlvoSei")]
        public CampoGenerico<ValorCampoMultivalorado> UsuarioAlvoSei { get; set; } 

        [JsonPropertyName("cargoOuFuncao")]
        public CampoGenerico<ValorCampoMultivalorado> CargoOuFuncao { get; set; } 

        [JsonIgnore]
        public virtual ValorCampoMultivalorado Usuario => UsuarioAlvoSei.Valor;
    }
}