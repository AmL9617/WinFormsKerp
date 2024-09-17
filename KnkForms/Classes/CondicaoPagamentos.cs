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
        protected float taxaJuro;
        protected string operacaoDisponivel;
        protected DateTime prazo;

        // Aggregation part
        protected Parcelas parcelas;

        public CondicaoPagamentos()
        {
            nome = "";
            ativo = false;
            tipo = "";
            taxaJuro = 0.0f;
            operacaoDisponivel = "";
            prazo = DateTime.MinValue;
            parcelas = null;
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

        public float TaxaJuro
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

        public Parcelas Parcelas
        {
            get { return parcelas; }
            set { parcelas = value; }
        }
    }

}
