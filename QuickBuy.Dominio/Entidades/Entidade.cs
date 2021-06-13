using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagensValidacao { get; set; }
        private List<string> MensagensValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        protected void LimparMensagensValidacao()
        {
            MensagensValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            MensagensValidacao.Add(mensagem);
        }


        public abstract void Validate();

        protected bool EhValidado
        {
            get { return !MensagensValidacao.Any(); }
        }
    }
}
