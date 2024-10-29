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
        protected char ativo;

        public ListaCodST()
        {
            tipo = "";
            descricao = "";
            ativo = '\0';
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
        public char Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }
    }
}
