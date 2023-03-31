using System;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Post.CamposPost;

namespace eAudStuffCSharp.EAudTypes.Records{
    public record NomeacaoRecord (
            string Titulo, 
            int Id, 
            int? IdUnidadeOrigem, 
            string UnidadeOrigem, 
            int IdUnidadeDestino, 
            string UnidadeDestino, 
            int IdServidor, 
            string Servidor, 
            int IdCargoFuncao,
            string CargoFuncao,
            DateTime? DataNomeacao,
            DateTime? DataExoneracao,
            string TipoNomeacao,
            string Estado); /*{
        public string Titulo { get; init; } = Titulo;
        public int Id { get; init; }
        public int? IdUnidadeOrigem { get; set; }

        public string UnidadeOrigem { get; set; }

        public int IdUnidadeDestino { get; set; }

        public string UnidadeDestino { get; set; }

        public int IdServidor { get; set; }
        public string Servidor { get; set; }

        public int IdCargoFuncao { get; set; }

        public string CargoFuncao { get; set; }

        public DateTime? DataNomeacao { get; set; }

        public DateTime? DataExoneracao { get; set; }

        public string TipoNomeacao { get; set; }

    }*/
}