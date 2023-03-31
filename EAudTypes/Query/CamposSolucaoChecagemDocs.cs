using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Query.Campos;
using eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares;

namespace eAudStuffCSharp.EAudTypes.Query {
    public class CamposSolucaoChecagemDocs : CamposTarefa  {

        [JsonIgnore]
        public static int IdTarefaSolucao => 1209246;
        
        [JsonPropertyName("listaRespostasImportadas")]
        public CampoGenerico<string> StrListaRespostasImportadas { get; set; } 

        [JsonIgnore]
        public Tuple<int,string>[] ListaRespostasImportadas => StrListaRespostasImportadas.Valor?.Split(',')
            .Select(x => x.Split('|'))
            .Select(x => new Tuple<int, string>(int.Parse(x[0]), x.Count() > 1 ? x[1] : ""))
            .ToArray()
            ?? new Tuple<int,string>[]{};

        [JsonPropertyName("mapaFilas")]
        public CampoGenericoTabela MapaFilas { get; set; }
    }
}