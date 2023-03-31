using System.Text.Json.Serialization;
using System.Collections;
using System.Collections.Generic;

namespace eAudStuffCSharp.EAudTypes.Query.Campos {

    public class TarefaAssociada    {
        [JsonPropertyName("campo")]
        public CampoConfiguracao Campo { get; set; } 

        [JsonPropertyName("ordem")]
        public int Ordem { get; set; } 

        [JsonPropertyName("tamanhoFormulario")]
        public int TamanhoFormulario { get; set; } 

        [JsonPropertyName("valor")]
        public ValorTarefaAssociada Valor { get; set; } 

        [JsonPropertyName("tipoExibicaoDetalhamento")]
        public string TipoExibicaoDetalhamento { get; set; } 

        [JsonPropertyName("tipoExibicaoCadastroOuInteracao")]
        public string TipoExibicaoCadastroOuInteracao { get; set; } 

        [JsonPropertyName("grupo")]
        public GrupoConfiguracao Grupo { get; set; } 

        [JsonPropertyName("configuracaoUtilizada")]
        public object ConfiguracaoUtilizada { get; set; } 

        [JsonPropertyName("textoAjuda")]
        public string TextoAjuda { get; set; } 

        [JsonPropertyName("camposOcultosPorCampo")]
        public List<object> CamposOcultosPorCampo { get; set; } 
    }

}