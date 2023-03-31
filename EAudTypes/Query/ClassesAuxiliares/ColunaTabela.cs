using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using eAudStuffCSharp.EAudTypes.Query.Campos;

namespace eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares {
    public class ColunaTabela    {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("ordem")]
        public int Ordem { get; set; } 

        [JsonPropertyName("nome")]
        public string Nome { get; set; } 

        [JsonPropertyName("formato")]
        public string Formato { get; set; } 

        [JsonPropertyName("entidadeReferenciada")]
        public string EntidadeReferenciada { get; set; } 

        [JsonPropertyName("mascara")]
        public string Mascara { get; set; } 

        [JsonPropertyName("exibirSomatorio")]
        public bool ExibirSomatorio { get; set; } 

        [JsonPropertyName("valorMaximo")]
        public object ValorMaximo { get; set; } 

        [JsonPropertyName("dominioListaFormatoTabela")]
        public List<DominioCampoLista> DominioListaFormatoTabela { get; set; } 
    }

}