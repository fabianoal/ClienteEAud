using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using eAudStuffCSharp.EAudTypes.Query.Campos;

namespace eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares {
    public class ConfigCampoTabela    {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("ordem")]
        public int? Ordem { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; } 

        [JsonPropertyName("alias")]
        public string Alias { get; set; } 

        [JsonPropertyName("html")]
        public string Html { get; set; } 

        [JsonPropertyName("formato")]
        public string Formato { get; set; } 

        [JsonPropertyName("mascara")]
        public string Mascara { get; set; } 

        [JsonPropertyName("obrigatorio")]
        public bool Obrigatorio { get; set; } 

        [JsonPropertyName("somenteLeitura")]
        public bool SomenteLeitura { get; set; } 

        [JsonPropertyName("exibirSomatorio")]
        public bool ExibirSomatorio { get; set; } 

        [JsonPropertyName("entidadeReferenciada")]
        public string EntidadeReferenciada { get; set; } 

        ///<summary>
        ///Quando o campo é consultado via API no contexto de alguma tarefa, o domínio que vem preenchido é esse.
        ///</summary>
        [JsonPropertyName("dominioCampoLista")]
        public DominioCampoLista[] DominioCampoLista { get; set; } 

        ///<summary>
        ///Quando o campo é consultado via API no endpoint decampo, o domínio que vem preenchido é esse.
        ///</summary>
        [JsonPropertyName("dominioListaFormatoTabela")]
        public DominioCampoLista[] DominioListaFormatoTabela { get; set; } 

        [JsonPropertyName("valor")]
        public string Valor { get; set; } 

        [JsonPropertyName("valorMaximo")]
        public object ValorMaximo { get; set; } 
    }
}