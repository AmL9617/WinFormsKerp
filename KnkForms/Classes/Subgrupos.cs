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
        protected bool ativo;
        protected Grupos grupos;

        public Subgrupos()
        {
            grupo = "";
            ativo = false;
            grupos = new Grupos();
        }

        public string Subgrupo
        {
            get { return subgrupo; }
            set { subgrupo = value; }
        }

        public bool Ativo
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
