using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class Contatos : Pai
    {
        protected string tipo;
        protected string contato;
        protected string observacao;

        public Contatos()
        {
            tipo = "";
            contato = "";
            observacao = "";
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Contato
        { 
            get { return contato; } 
            set { contato = value; } 
        }
        public string Observacao
        {
            get{ return observacao; }
            set { observacao = value; }
        }
    }
}