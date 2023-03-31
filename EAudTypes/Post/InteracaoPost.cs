using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using eAudStuffCSharp.EAudTypes.Post.CamposPost;

namespace eAudStuffCSharp.EAudTypes.Post
{
    public class InteracaoPost<T>    {
        public InteracaoPost(int[] idsTarefas, int idTipoInteracao)
        {
            this.idsTarefas = idsTarefas;
            this.idTipoInteracao = idTipoInteracao.ToString();
            IniciaPropriedadesAcessorias();

        }

        public InteracaoPost(int idTarefa, int idTipoInteracao){
            idsTarefas = new int[] { idTarefa };
            this.idTipoInteracao = idTipoInteracao.ToString();
            IniciaPropriedadesAcessorias();
        }

        public InteracaoPost(int idTarefa, string idTipoInteracao){
            idsTarefas = new int[] { idTarefa };
            this.idTipoInteracao = idTipoInteracao;
            IniciaPropriedadesAcessorias();
        }

        public InteracaoPost(int[] idsTarefas, string idTipoInteracao)
        {
            this.idsTarefas = idsTarefas;
            this.idTipoInteracao = idTipoInteracao;
            IniciaPropriedadesAcessorias();

        }


        private void IniciaPropriedadesAcessorias(){
            Compartilhamentos = new List<CompartilhamentoPost>();
            InteracoesAutomaticasOpcionaisARegistrar = new List<object>();
            TarefasAutomaticasOpcionaisARegistrar = new List<object>();

        }

        

        private readonly int [] idsTarefas ;
        private readonly string idTipoInteracao;

        [JsonPropertyName("idsTarefas")]
        public int[] IdsTarefas { get => idsTarefas; } 

        [JsonPropertyName("idTipoInteracao")]
        public string IdTipoInteracao { get => idTipoInteracao; } 

        [JsonPropertyName("codigoToken")]
        public string CodigoToken => "";

        [JsonPropertyName("campos")]
        public T Campos { get; set; } 

        [JsonPropertyName("compartilhamentos")]
        public List<CompartilhamentoPost> Compartilhamentos { get; set; } 

        [JsonPropertyName("interacoesAutomaticasOpcionaisARegistrar")]
        public List<object> InteracoesAutomaticasOpcionaisARegistrar { get; set; } 

        [JsonPropertyName("tarefasAutomaticasOpcionaisARegistrar")]
        public List<object> TarefasAutomaticasOpcionaisARegistrar { get; set; } 

    }

}