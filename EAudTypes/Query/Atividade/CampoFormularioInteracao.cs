using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.Campos;

namespace eAudStuffCSharp.EAudTypes.Query.Atividade {
    public class CampoFormularioInteracao
    {
        //Bizarro, mas é isso memso.
        [JsonPropertyName("campo")]
        public CampoConfiguracao Campo { get; set; }

        [JsonPropertyName("tipoExibicaoDetalhamento")]
        public string TipoExibicaoDetalhamento { get; set; }

        [JsonPropertyName("tipoExibicaoCadastroOuInteracao")]
        public string TipoExibicaoCadastroOuInteracao { get; set; }

        [JsonPropertyName("textoAjuda")]
        public string TextoAjuda { get; set; }

        [JsonPropertyName("valorMinimo")]
        public double? ValorMinimo { get; set; }

        [JsonPropertyName("valorMaximo")]
        public double? ValorMaximo { get; set; }

        [JsonPropertyName("visualizarAba")]
        public bool VisualizarAba { get; set; }

        [JsonPropertyName("obrigatorio")]
        public bool Obrigatorio { get; set; }

        [JsonPropertyName("ordem")]
        public int Ordem { get; set; }

        [JsonPropertyName("tamanhoFormulario")]
        public int TamanhoFormulario { get; set; }

        [JsonPropertyName("grupo")]
        public GrupoConfiguracao Grupo { get; set; }

        [JsonPropertyName("configuracaoUtilizada")]
        public string ConfiguracaoUtilizada { get; set; }

        [JsonPropertyName("dominioCampoListaSelecionado")]
        public DominioCampoLista[] DominioCampoListaSelecionado { get; set; }

        [JsonPropertyName("tipoPreenchimentoAutomatico")]
        public string TipoPreenchimentoAutomatico { get; set; }

        [JsonPropertyName("valorPreenchimentoAutomatico")]
        public string ValorPreenchimentoAutomatico { get; set; }

        [JsonPropertyName("camposOcultosPorCampo")]
        public object[] CamposOcultosPorCampo { get; set; }

        [JsonPropertyName("tipoInteracao")]
        public int? TipoInteracao { get; set; }

    }
}