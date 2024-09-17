using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class RamoAtividades : Pai
    {
        protected string nomeRamo;
        protected bool ativo;

        public RamoAtividades()
        {
            nomeRamo = "";
            ativo = false;
        }

        public string NomeRamo
        {
            get { return nomeRamo; }
            set { nomeRamo = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }
    }

}
