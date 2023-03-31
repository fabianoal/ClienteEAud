using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace eAudStuffCSharp.EAudTypes.Query{
    public class QueryTarefasContainer<T>    {
        [JsonPropertyName("draw")]
        public int Draw { get; set; } 

        [JsonPropertyName("recordsTotal")]
        public int RecordsTotal { get; set; } 

        [JsonPropertyName("recordsFiltered")]
        public int RecordsFiltered { get; set; } 

        [JsonPropertyName("data")]
        public List<T> Data { get; set; } 

        [JsonPropertyName("error")]
        public object Error { get; set; } 
    }
    
}