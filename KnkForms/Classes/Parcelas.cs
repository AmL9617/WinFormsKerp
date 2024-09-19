using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class Parcelas : FormaPagamentos
    {
        protected int quantidade;
        protected double valor;

        public Parcelas()
        {
            quantidade = 0;
            valor = 0.0f;
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }

}
