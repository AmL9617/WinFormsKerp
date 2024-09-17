using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class Empresas : Pai
    {
        protected string razaoSocial;
        protected string nomeFantasia;
        protected string cnpj;
        protected string cep;

        public Empresas()
        {
            razaoSocial = "";
            nomeFantasia = "";
            cnpj = "";
            cep = "";
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

        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
    }

}
