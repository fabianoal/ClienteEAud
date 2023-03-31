using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.Campos;

namespace eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares {
    ///<summary>
    /// No campo TarefaAssociada, os valores dos campos são trazidos em um array desse tipo.
    /// Isso difere bastante de quando se consulta uma tarefa onde os campos vem num Dictionary, o que permite 
    /// uma melhor tipagem por tipo de tarefa (feito através do generics Tarefa<Campos...>)
    ///</summary>
    public class ItemValorCampo    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("campo")]
        public CampoConfiguracao Campo { get; set; }

        [JsonPropertyName("interacao")]
        public object Interacao { get; set; }

        [JsonPropertyName("valorInteiro")]
        public int? ValorInteiro { get; set; }

        [JsonPropertyName("valorDecimal")]
        public object ValorDecimal { get; set; }

        [JsonPropertyName("valorString")]
        public string ValorString { get; set; }

        [JsonPropertyName("valorData")]
        public object ValorData { get; set; }

        [JsonPropertyName("dominioDoCampoLista")]
        public DominioCampoLista DominioCampoLista { get; set; }

        [JsonPropertyName("alteradoNaInteracao")]
        public bool AlteradoNaInteracao { get; set; }

        [JsonPropertyName("valor")]
        public object Valor { get; set; }
    }

}