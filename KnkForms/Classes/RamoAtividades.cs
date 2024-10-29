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
        protected char ativo;

        public RamoAtividades()
        {
            ramo = "";
            ativo = '\0';
        }

        public string Ramo
        {
            get { return ramo; }
            set { ramo = value; }
        }

        public char Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }
    }

}
