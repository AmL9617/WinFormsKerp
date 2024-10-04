using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class Transportadoras : Pai
    {
        protected string transportadoraCliente;
        protected string fisicaJuridica;
        protected bool ativo;
        protected string razaoSocial;
        protected string nomeFantasia;
        protected string endereco;
        protected int numero;
        protected string complemento;
        protected string bairro;
        protected string cep;
        protected string telefone;
        protected string fax;
        protected string celular;
        protected string website;
        protected string email;
        protected string observacao;
        protected DateTime ultimaCompra;
        protected string inscricaoEstadual;
        protected string cnpj;

        //Placeholder
        protected int codContatos;
        //Agregação
        protected Contatos contatos;
        public Transportadoras()
        {
            transportadoraCliente = "";
            fisicaJuridica = "";
            ativo = false;
            razaoSocial = "";
            nomeFantasia = "";
            endereco = "";
            numero = 0;
            complemento = "";
            bairro = "";
            cep = "";
            telefone = "";
            fax = "";
            celular = "";
            website = "";
            email = "";
            observacao = "";
            ultimaCompra = DateTime.MinValue;
            inscricaoEstadual = "";
            cnpj = "";

            codContatos = 0;
            contatos = new Contatos();
        }

        public string TransportadoraCliente
        {
            get { return transportadoraCliente; }
            set { transportadoraCliente = value; }
        }

        public string FisicaJuridica
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

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public string Website
        {
            get { return website; }
            set { website = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }

        public DateTime UltimaCompra
        {
            get { return ultimaCompra; }
            set { ultimaCompra = value; }
        }

        public string InscricaoEstadual
        {
            get { return inscricaoEstadual; }
            set { inscricaoEstadual = value; }
        }

        public string CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public int CodContatos
        {
            get { return codContatos; }
            set { codContatos = value; }
        }
        public Contatos Contatos
        {
            get { return contatos; }
            set { contatos = value; }
        }
    }

}
