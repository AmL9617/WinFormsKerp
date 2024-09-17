using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class Marcas : Pai
    {
        protected string nomeMarca;
        protected bool ativo;

        public Marcas()
        {
            nomeMarca = "";
            ativo = false;
        }

        public string NomeMarca
        {
            get { return nomeMarca; }
            set { nomeMarca = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }
    }

}
