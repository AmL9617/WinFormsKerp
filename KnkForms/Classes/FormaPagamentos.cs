using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class FormaPagamentos : Pai
    {
        protected string nome;
        protected string operacaoDisponivel;
        protected string nfce;

        public FormaPagamentos()
        {
            nome = "";
            operacaoDisponivel = "";
            nfce = "";
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string OperacaoDisponivel
        {
            get { return operacaoDisponivel; }
            set { operacaoDisponivel = value; }
        }

        public string Nfce
        {
            get { return nfce; }
            set { nfce = value; }
        }
    }

}
