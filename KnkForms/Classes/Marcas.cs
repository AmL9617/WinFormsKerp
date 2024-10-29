using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class Marcas : Pai
    {
        protected string marca;
        protected char ativo;

        public Marcas()
        {
            marca = "";
            ativo = '\0';
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public char Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }
    }

}
