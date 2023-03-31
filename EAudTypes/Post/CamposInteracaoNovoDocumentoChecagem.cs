using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Post.CamposPost;

namespace eAudStuffCSharp.EAudTypes.Post
{
    public class CamposInteracaoNovoDocumentoChecagem {

            [JsonIgnore]
            public static string IdTipoInteracao => "10458";

            [JsonIgnore]
            public static int[] IdsTarefas => new int[]{1209246};

            [JsonIgnore]
            public static int IdCampoAnexo => 270;

            [JsonIgnore]
            public IEnumerable<int> IdsAnexosTarefa  { get; set; }
            
            [JsonPropertyName("anexosTarefa")]
            public string AnexosTarefa => String.Join(',', IdsAnexosTarefa.ToArray());

            [JsonPropertyName("cpfCandidato")]
            public string CpfCandidato { get; set; }

            [JsonPropertyName("idRespostaQuestionario")]
            public int IdRespostaQuestionario { get; set; }

            [JsonPropertyName("identificadorFila")]
            public string IdentificadorFila { get; set; }

            [JsonPropertyName("nomeCandidato")]
            public string NomeCandidato { get; set; }
    }
}