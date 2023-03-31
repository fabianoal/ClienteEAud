using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.Campos;
using eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares;

namespace eAudStuffCSharp.EAudTypes.Query {
    public class CamposCadastroNomeacao: CamposLotacao    {

        [JsonPropertyName("servidoresNomeacaoAtiva")]
        public CampoGenerico<TipoGenericoReferencia[]> ServidoresComNomeacaoAtiva { get; set; } 

    }
}