using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class Subgrupos:Grupos
    {
        protected string subgrupo;
        protected char ativo;
        protected Grupos grupos;

        public Subgrupos()
        {
            grupo = "";
            ativo = '\0';
            grupos = new Grupos();
        }

        public string Subgrupo
        {
            get { return subgrupo; }
            set { subgrupo = value; }
        }

        public char Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }
        public Grupos Grupos
        {
            get { return grupos; }
            set {  grupos = value; }
        }
    }
}
