using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.Campos;
using eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares;

namespace eAudStuffCSharp.EAudTypes.Query {
    public class CamposControladoresPlanilhaHoras : CamposTarefa    {

        [JsonPropertyName("servidoresPlanilhaHoras")]
        public CampoGenerico<ValorCampoMultivalorado[]> Servidores { get; set; } 

        [JsonPropertyName("homologadores")]
        public CampoGenerico<ValorCampoMultivalorado[]> Homologadores { get; set; } 

        [JsonPropertyName("unidadeOrigem")]
        public CampoGenerico<LinhaUnidade> Unidade { get; set; } 

    }
}