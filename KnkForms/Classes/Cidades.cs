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
        protected int codEstado; // Temporarily using int for future implementation

        public Cidades()
        {
            nomeCidade = "";
            ddd = 0;
            ativo = false;
            codEstado = 0; // Initialize with a default value
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

        // Placeholder for future implementation
        // public Paises Pais { get; set; }
    }

}
