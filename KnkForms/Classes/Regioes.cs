using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class Regioes : Pai
    {
        protected string nomeRegiao;
        protected bool ativo;

        public Regioes()
        {
            nomeRegiao = "";
            ativo = false;
        }

        public string NomeRegiao
        {
            get { return nomeRegiao; }
            set { nomeRegiao = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }
    }

}
