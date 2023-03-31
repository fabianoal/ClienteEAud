using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.Campos;

namespace eAudStuffCSharp.EAudTypes.Query
{
    public class LinhaPlanoOperacionalDePlanoDeTrabalho  {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("titulo")]
        public string Titulo { get; set; }

        [JsonPropertyName("dataInicioFim")]
        public string DataInicioFim { get; set; }

        [JsonPropertyName("homemHora")]
        public int HomemHora { get; set; }

        [JsonPropertyName("recurso")]
        public string Recurso { get; set; }
    }
}
