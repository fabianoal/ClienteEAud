using System;
using System.Collections;
using System.Linq;
using System.Text.Json.Serialization;
using System.Reflection;

namespace eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares {
    public class CelulaTabela {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("valor")]
        public object Valor { get; set; } 

        [JsonPropertyName("nova")]
        public bool? Nova { get; set; } 

        [JsonPropertyName("descricao")]
        public object Descricoes { get; set; } 

        [JsonIgnore]
        public string Descricao 
        { 
            get => (Descricoes.GetType() == typeof(IEnumerable)) ? string.Join(',', Descricoes) : Descricoes.ToString();
            set => Descricoes = new string []{ value };
        }
    }
}