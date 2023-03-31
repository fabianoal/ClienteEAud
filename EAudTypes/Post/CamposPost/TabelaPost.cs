using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Linq;
using System.Dynamic;

namespace eAudStuffCSharp.EAudTypes.Post.CamposPost {
    
    public class TabelaPost {
        [JsonPropertyName("config")]
        public object[] Config { get; set; } 

        [JsonPropertyName("dados")]
        public dynamic[] Dados { 
            get =>
                ArrayLinhas.Select(linha => {
                    dynamic itemTabela = new ExpandoObject();
                    itemTabela.colunaAcao = new {
                        valor = linha.First(x => x.Id <= 0).Valor,
                        nova = linha.First(x => x.Id <= 0).Nova
                    };
                    //var confColunas = (tabela.Campo.ColunasFormatoTabela ?? tabela.Valor.ConfiguracaoColunas).Where(x => x.Id > 0);
                    //var confColunas = tabela.Campo.ColunasFormatoTabela.Where(x => x.Id > 0);
                    foreach (var col in linha.Where(x => x.Id > 0)){
                        var cell = itemTabela as IDictionary<String, object>;
                        cell[$"coluna_{col.Id}"] = string.IsNullOrEmpty(col.Descricao) && col.Valor == null ? new {} : new {
                            id = col.Id,
                            valor = col.Valor,
                            descricao = col.Descricao
                        };
                    }
                    return itemTabela;

                }).ToArray();
        } 

        [JsonIgnore]
        public Query.ClassesAuxiliares.CelulaTabela[][] ArrayLinhas { get; set; } 
    }

}