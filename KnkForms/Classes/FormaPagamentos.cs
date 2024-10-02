using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class FormaPagamentos : Pai
    {
        protected string formaPag;
        protected string operacaoDisponivel;
        protected string nfce;

        public FormaPagamentos()
        {
            formaPag = "";
            operacaoDisponivel = "";
            nfce = "";
        }

        public string FormaPag
        {
            get { return formaPag; }
            set { formaPag = value; }
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
