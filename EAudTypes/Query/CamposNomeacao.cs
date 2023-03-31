using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.Campos;
using eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares;

namespace eAudStuffCSharp.EAudTypes.Query {
    public class CamposNomeacao : CamposLotacao    {

        [JsonPropertyName("servidor")]
        public CampoGenerico<ValorCampoMultivalorado> Servidor { get; set; } 

        [JsonIgnore]
        public override ValorCampoMultivalorado Usuario => Servidor.Valor;

        [JsonPropertyName("unidadeOrigem")]
        public CampoGenerico<Unidade> UnidadeOrigem { get; set; } 

        [JsonPropertyName("tipoNomeacao")]
        public CampoGenerico<ValorCampoMultivalorado> TipoNomeacao { get; set; }

        [JsonPropertyName("tarefaMudancaVinculada")]
        public CampoGenerico<TarefaReferenciada> TarefaMudancaVinculada { get; set; }

        [JsonPropertyName("equipeEquivalente")]
        public CampoGenerico<ValorCampoMultivalorado> EquipeEquivalente { get; set; }

        [JsonPropertyName("codigoCargo")]
        public CampoGenerico<ValorCampoMultivalorado> CodigoCargo { get; set; }

        [JsonPropertyName("designacaoCargo")]
        public CampoGenerico<ValorCampoMultivalorado> Designacao { get; set; }


    }
}