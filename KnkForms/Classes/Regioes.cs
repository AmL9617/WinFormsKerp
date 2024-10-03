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
        protected string descricao;

        public Regioes()
        {
            regiao = "";
            ativo = false;
            descricao = "";
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
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
    }

}
