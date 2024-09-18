using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class Cidades : Pai
    {
        protected string nomeCidade;
        protected int ddd;
        protected bool ativo;

        //Placeholder
        protected int codEstado;
        //Agregação
        protected Estados estado;

        public Cidades()
        {
            nomeCidade = "";
            ddd = 0;
            ativo = false;
            estado = new Estados();
            codEstado = 0; 
        }

        public string NomeCidade
        {
            get { return nomeCidade; }
            set { nomeCidade = value; }
        }

        public int DDD
        {
            get { return ddd; }
            set { ddd = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        public int CodEstado
        {
            get { return codEstado; }
            set { codEstado = value; }
        }

        public Estados Estado
        { 
            get { return estado; } 
            set { estado = value; } 
        }
    }

}
