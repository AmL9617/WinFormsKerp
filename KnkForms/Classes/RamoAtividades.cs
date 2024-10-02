using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class RamoAtividades : Pai
    {
        protected string ramo;
        protected bool ativo;

        public RamoAtividades()
        {
            ramo = "";
            ativo = false;
        }

        public string Ramo
        {
            get { return ramo; }
            set { ramo = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }
    }

}
