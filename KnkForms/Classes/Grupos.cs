using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class Grupos : Pai
    {
        protected string grupo;
        protected bool ativo;

        public Grupos()
        {
            grupo = "";
            ativo = false;
        }

        public string Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }
    }

}
