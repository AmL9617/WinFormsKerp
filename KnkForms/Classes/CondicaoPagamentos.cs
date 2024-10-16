using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class CondicaoPagamentos : Pai
    {
        protected string condPag;
        protected bool ativo;
        protected string tipo;
        protected double taxaJuro;
        protected string operacaoDisponivel;
        protected int numeroParcelas;
        protected string dia;

        //Placeholder
        protected int codParcela;

        //Agregação
        protected Parcelas parcelas;

        public CondicaoPagamentos()
        {
            condPag = "";
            ativo = false;
            tipo = "";
            taxaJuro = 0.0f;
            operacaoDisponivel = "";
            numeroParcelas = 0;
            dia = "";
            parcelas = new Parcelas();
            codParcela = 0;
        }

        public string CondPag
        {
            get { return condPag; }
            set { condPag = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public double TaxaJuro
        {
            get { return taxaJuro; }
            set { taxaJuro = value; }
        }

        public string OperacaoDisponivel
        {
            get { return operacaoDisponivel; }
            set { operacaoDisponivel = value; }
        }

        public int NumeroParcelas
        {
            get { return numeroParcelas; }
            set { numeroParcelas = value; }
        }
        public string Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        public int CodParcela
        {
            get { return codParcela; }
            set { codParcela = value; }
        }
        public Parcelas Parcelas
        {
            get { return parcelas; }
            set { parcelas = value; }
        }
    }

}
