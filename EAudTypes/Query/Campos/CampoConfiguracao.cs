using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares;

namespace eAudStuffCSharp.EAudTypes.Query.Campos {
    public class CampoConfiguracao{

        [JsonPropertyName("alias")]
        public string Alias { get; set; } 

        [JsonPropertyName("assuntoCampoPadrao")]
        public string AssuntoCampoPadrao { get; set; } 

        [JsonPropertyName("ativo")]
        public bool Ativo { get; set; } 

        [JsonPropertyName("campoDaEntidadeConcreta")]
        public bool CampoDaEntidadeConcreta { get; set; } 

        [JsonPropertyName("colunasFormatoTabela")]
        public ConfigCampoTabela[] ColunasFormatoTabela { get; set; } 

        [JsonPropertyName("configuracaoDisponivel")]
        public string ConfiguracaoDisponivel { get; set; } 

        [JsonPropertyName("configuracaoTotalizacaoFormatoTabela")]
        public object ConfiguracaoTotalizacaoFormatoTabela { get; set; } 

        [JsonPropertyName("criar")]
        public bool Criar { get; set; } 

        [JsonPropertyName("dominioCampoLista")]
        public List<DominioCampoLista> DominioCampoLista { get; set; } 

        [JsonPropertyName("entidadeReferenciada")]
        public string EntidadeReferenciada { get; set; } 

        [JsonPropertyName("formato")]
        public string Formato { get; set; } 

        [JsonPropertyName("formatoReferenciaOuReferencias")]
        public bool FormatoReferenciaOuReferencias { get; set; } 

        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("mascara")]
        public object Mascara { get; set; } 

        [JsonPropertyName("nodosDoCampoArvore")]
        public List<object> NodosDoCampoArvore { get; set; } 

        [JsonPropertyName("nome")]
        public string Nome { get; set; } 

        [JsonPropertyName("permissaoEdicaoCampo")]
        public string PermissaoEdicaoCampo { get; set; } 

        [JsonPropertyName("permiteBuscaAvancada")]
        public bool PermiteBuscaAvancada { get; set; } 

        [JsonPropertyName("permiteMapearAutomatismo")]
        public bool PermiteMapearAutomatismo { get; set; } 

        [JsonPropertyName("permiteMapearCopiaDados")]
        public bool PermiteMapearCopiaDados { get; set; } 

        [JsonPropertyName("tooltip")]
        public string Tooltip { get; set; } 

        [JsonPropertyName("valorMaximo")]
        public object ValorMaximo { get; set; } 
    }

}