using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.Campos;
using eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares;

namespace eAudStuffCSharp.EAudTypes.Query {
    public class CamposPlanilhaHoras : CamposTarefa    {
        
        [JsonPropertyName("servidorGestaoDemandas")]
        public CampoGenerico<ValorCampoMultivalorado> Servidor { get; set; } 

        [JsonPropertyName("planilhaGestaoDemandas")]
        public CampoGenerico<Planilha> Planilha { get; set; } 

        [JsonPropertyName("gerentesGestaoDemandas")]
        public CampoGenerico<ValorCampoMultivalorado[]> Gerentes { get; set; } 

        [JsonPropertyName("flagNovaPlanilhaGerada")]
        public CampoGenericoBoolean FlagNovaPlanilhaGerada { get; set; } 

        [JsonPropertyName("homologadores")]
        public CampoGenerico<ValorCampoMultivalorado[]> Homologadores { get; set; } 

    }
}