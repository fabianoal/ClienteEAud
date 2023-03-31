using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Post.CamposPost;

namespace eAudStuffCSharp.EAudTypes.Post{
    public class UnidadePost {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("idUnidadeOrgao")]
        public int IdUnidadeOrgao { get; set; }

        [JsonPropertyName("idUnidadeSuperior")]
        public int? IdUnidadeSuperior { get; set; }

        [JsonPropertyName("tipos")]
        public string[] Tipos { get; set; }

        [JsonPropertyName("contrapartes")]
        public object[] Contrapartes { get; set; }

        [JsonPropertyName("codigo")]
        public string Codigo { get; set; }

        [JsonPropertyName("codigoSiorg")]
        public string CodigoSiorg { get; set; }

        [JsonPropertyName("siglaSimples")]
        public string SiglaSimples { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("telefone")]
        public string Telefone { get; set; }

        [JsonPropertyName("idLocalidade")]
        public int IdLocalidade { get; set; }

        [JsonPropertyName("usuarios")]
        public string Usuarios { get; set; }

        [JsonPropertyName("lotacoes")]
        public LotacaoPost[] Lotacoes { get; set; }

        [JsonPropertyName("permiteLotacaoPrincipal")]
        public bool PermiteLotacaoPrincipal { get; set; }

        [JsonPropertyName("envioEmailMembros")]
        public bool EnvioEmailMembros {get; set; }

        [JsonPropertyName("envioEmailUnidade")]
        public bool EnvioEmailUnidade {get; set; }

        [JsonIgnore]
        public static Dictionary<string, string> DicionarioTipos = new Dictionary<string, string>() {
            {"Unidade de Auditoria Interna Governamental", "UAIG"},
            {"Unidade Auditada", "UAUD"},
            {"Unidade Pagadora", "UPAG"},
            {"Unidade Interna da CGU", "UICGU"},
            {"Unidade Gestora", "UG"},
            {"Unidade de Corregedoria", "UC"},
            {"Administração Direta", "ADMINISTRACAO_DIRETA"},
            {"Agência Reguladora", "AGENCIA_REGULADORA"},
            {"Autarquia", "AUTARQUIA"},
            {"Fundação", "FUNDACAO"},
            {"Estatal", "ESTATAL"},
            {"Instituição de Ensino", "INSTITUICAO_ENSINO" },
        };
    }
}