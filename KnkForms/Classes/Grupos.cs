using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class Grupos : Pai
    {
        protected string nomeGrupo;
        protected bool ativo;

        public Grupos()
        {
            nomeGrupo = "";
            ativo = false;
        }

        public string NomeGrupo
        {
            get { return nomeGrupo; }
            set { nomeGrupo = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }
    }

}
