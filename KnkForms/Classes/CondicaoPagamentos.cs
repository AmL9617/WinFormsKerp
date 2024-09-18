using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class CondicaoPagamentos : Pai
    {
        protected string nome;
        protected bool ativo;
        protected string tipo;
        protected double taxaJuro;
        protected string operacaoDisponivel;
        protected DateTime prazo;

        //Placeholder
        protected int codParcela;

        //Agregação
        protected Parcelas parcelas;

        public CondicaoPagamentos()
        {
            nome = "";
            ativo = false;
            tipo = "";
            taxaJuro = 0.0f;
            operacaoDisponivel = "";
            prazo = DateTime.MinValue;
            parcelas = new Parcelas();
            codParcela = 0;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
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

        public DateTime Prazo
        {
            get { return prazo; }
            set { prazo = value; }
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
