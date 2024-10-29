using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class Vendedores : Pai
    {
        protected string vendedor;
        protected char ativo;
        protected string tipo;
        protected double comissao;
        protected DateTime comissaoPrazo;
        protected string observacao;

        public Vendedores()
        {
            vendedor = "";
            ativo = '\0';
            tipo = "";
            comissao = 0.0f;
            comissaoPrazo = DateTime.MinValue;
            observacao = "";
        }

        public string Vendedor
        {
            get { return vendedor; }
            set { vendedor = value; }
        }

        public char Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public double Comissao
        {
            get { return comissao; }
            set { comissao = value; }
        }

        public DateTime ComissaoPrazo
        {
            get { return comissaoPrazo; }
            set { comissaoPrazo = value; }
        }

        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }
    }

}
