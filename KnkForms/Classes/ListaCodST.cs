using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    //ST é situação tributária
    internal class ListaCodST:Pai
    {
        protected string tipo;
        protected string descricao;
        protected bool ativo;

        public ListaCodST()
        {
            tipo = "";
            descricao = "";
            ativo = true;
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Descricao 
        {
            get { return descricao; } 
            set { descricao = value; } 
        }
        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }
    }
}
