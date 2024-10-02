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
        protected bool ativo;

        public Marcas()
        {
            marca = "";
            ativo = false;
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }
    }

}
