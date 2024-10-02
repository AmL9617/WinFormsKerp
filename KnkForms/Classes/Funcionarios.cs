using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class Funcionarios : Pai
    {
        protected string funcionario;
        protected bool ativo;
        protected string endereco;
        protected int numero;
        protected string complemento;
        protected string bairro;
        protected string cep;
        protected string telefone;
        protected string celular;
        protected string email;
        protected string observacoes;
        protected double salario;
        protected DateTime dataAdmissao;
        protected DateTime dataDemissao;
        protected string sexo;
        protected DateTime dataNascimento;
        protected string rg;
        protected string cpf;

        public Funcionarios()
        {
            funcionario = "";
            ativo = false;
            endereco = "";
            numero = 0;
            complemento = "";
            bairro = "";
            cep = "";
            telefone = "";
            celular = "";
            email = "";
            observacoes = "";
            salario = 0.0f;
            dataAdmissao = DateTime.MinValue;
            dataDemissao = DateTime.MinValue;
            sexo = "";
            dataNascimento = DateTime.MinValue;
            rg = "";
            cpf = "";
        }

        public string Funcionario
        {
            get { return funcionario; }
            set { funcionario = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
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

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public DateTime DataAdmissao
        {
            get { return dataAdmissao; }
            set { dataAdmissao = value; }
        }

        public DateTime DataDemissao
        {
            get { return dataDemissao; }
            set { dataDemissao = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
    }

}
