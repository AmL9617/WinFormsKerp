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
        protected char ativo;

        public Grupos()
        {
            grupo = "";
            ativo = '\0';
        }

        public string Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }

        public char Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }
    }

}
