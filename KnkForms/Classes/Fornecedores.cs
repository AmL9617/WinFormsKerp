using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class Fornecedores : Pai
    {
        protected string industria;
        protected bool fisicaJuridica;
        protected bool ativo;
        protected string razaoSocial;
        protected string nomeFantasia;
        protected string endereco;
        protected int numero;
        protected string complemento;
        protected string bairro;
        protected string cep;
        protected string tipoContato;
        protected string contato;
        protected string observacao;
        protected string cnpj;
        protected string inscricaoEstadual;
        protected string trade;
        protected int codProdIgual;
        protected double limiteCredito;
        protected string observacoes;
        protected bool verEmClientes;
        protected DateTime ultimoMovimento;

        public Fornecedores()
        {
            industria = "";
            fisicaJuridica = false;
            ativo = false;
            razaoSocial = "";
            nomeFantasia = "";
            endereco = "";
            numero = 0;
            complemento = "";
            bairro = "";
            cep = "";
            tipoContato = "";
            contato = "";
            observacao = "";
            cnpj = "";
            inscricaoEstadual = "";
            trade = "";
            codProdIgual = 0;
            limiteCredito = 0.0f;
            observacoes = "";
            verEmClientes = false;
            ultimoMovimento = DateTime.MinValue;
        }

        public string Industria
        {
            get { return industria; }
            set { industria = value; }
        }

        public bool FisicaJuridica
        {
            get { return fisicaJuridica; }
            set { fisicaJuridica = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        public string RazaoSocial
        {
            get { return razaoSocial; }
            set { razaoSocial = value; }
        }

        public string NomeFantasia
        {
            get { return nomeFantasia; }
            set { nomeFantasia = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public string TipoContato
        {
            get { return tipoContato; }
            set { tipoContato = value; }
        }

        public string Contato
        {
            get { return contato; }
            set { contato = value; }
        }

        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }

        public string CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public string InscricaoEstadual
        {
            get { return inscricaoEstadual; }
            set { inscricaoEstadual = value; }
        }

        public string Trade
        {
            get { return trade; }
            set { trade = value; }
        }

        public int CodProdIgual
        {
            get { return codProdIgual; }
            set { codProdIgual = value; }
        }

        public double LimiteCredito
        {
            get { return limiteCredito; }
            set { limiteCredito = value; }
        }

        public string Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }

        public bool VerEmClientes
        {
            get { return verEmClientes; }
            set { verEmClientes = value; }
        }

        public DateTime UltimoMovimento
        {
            get { return ultimoMovimento; }
            set { ultimoMovimento = value; }
        }
    }

}
