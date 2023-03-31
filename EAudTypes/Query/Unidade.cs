using System.Linq;
using System.Text.Json.Serialization;
using System.Collections;
using System.Collections.Generic;
using eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares;

namespace eAudStuffCSharp.EAudTypes.Query {

    public class Unidade {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("telefone")]
        public string Telefone { get; set; }

        [JsonPropertyName("ativo")]
        public bool Ativo { get; set; }

        [JsonPropertyName("idOrgaoUnidade")]
        public int IdOrgaoUnidade { get; set; }

        [JsonIgnore]
        private string StrSiglaSimples;

        [JsonPropertyName("siglaSimples")]
        public string SiglaSimples { 
            get => StrSiglaSimples ?? Sigla.Split('/').First(); 
            set => StrSiglaSimples = value;
        }

        [JsonPropertyName("sigla")]
        public string Sigla { get; set; }

        [JsonPropertyName("codigo")]
        public string Codigo { get; set; }

        [JsonPropertyName("codigoSiorg")]
        public string CodigoSiorg { get; set; }

        [JsonPropertyName("idUnidadeSuperior")]
        public int? IdUnidadeSuperior { get; set; }

        [JsonPropertyName("localidade")]
        public Localidade Localidade { get; set; }

        [JsonPropertyName("hierarquia")]
        public string Hierarquia { get; set; }

        [JsonPropertyName("dispensaPonto")]
        public bool DispensaPonto { get; set; }

        [JsonPropertyName("permiteLotacaoPrincipal")]
        public bool PermiteLotacaoPrincipal { get; set; }

        [JsonPropertyName("datUltimaModificacao")]
        public string DatUltimaModificacao { get; set; }

        [JsonPropertyName("numProfundidadeHierarquia")]
        public int NumProfundidadeHierarquia { get; set; }

        [JsonPropertyName("nomeExibicao")]
        public string NomeExibicao { get; set; }

        [JsonPropertyName("envioEmailMembros")]
        public bool EnvioEmailMembros {get; set; }

        [JsonPropertyName("envioEmailUnidade")]
        public bool EnvioEmailUnidade {get; set; }
        
    }
}