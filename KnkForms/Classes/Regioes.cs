using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class Regioes : Pai
    {
        protected string regiao;
        protected bool ativo;

        public Regioes()
        {
            regiao = "";
            ativo = false;
        }

        public string Regiao
        {
            get { return regiao; }
            set { regiao = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }
    }

}
