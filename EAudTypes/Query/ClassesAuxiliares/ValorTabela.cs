using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares {
    public class ValorTabela {

        [JsonPropertyName("config")]
        public ConfigCampoTabela[] ConfiguracaoColunas { get; set; }

        [JsonPropertyName("dados")]
        public Dictionary<string, CelulaTabela>[] Dados { get; set; }

    }
}