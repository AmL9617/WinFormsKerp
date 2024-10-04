using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class Contadores : Pai
    {
        protected string contador;
        protected string endereco;
        protected int numero;
        protected string complemento;
        protected string bairro;
        protected string cep;
        protected string telefone;
        protected string fax;
        protected string celular;
        protected string email;
        protected string cnpj;
        protected string crc;

        //Placeholder
        protected int codContatos;
        //Agregação
        protected Contatos contatos;

        public Contadores()
        {
            contador = "";
            endereco = "";
            numero = 0;
            complemento = "";
            bairro = "";
            cep = "";
            telefone = "";
            fax = "";
            celular = "";
            email = "";
            cnpj = "";
            crc = "";

            codContatos = 0;
            contatos = new Contatos();
        }

        public string Contador
        {
            get { return contador; }
            set { contador = value; }
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


        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public string Crc
        {
            get { return crc; }
            set { crc = value; }
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
