using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class Estados : Pai
    {
        protected string nomeEstado;
        protected char sigla;
        protected bool ativo;
        protected int codPais; // Temporarily using int for future implementation

        public Estados()
        {
            nomeEstado = "";
            sigla = '\0'; // Default value for char
            ativo = false;
            codPais = 0; // Default value for int
        }

        public string NomeEstado
        {
            get { return nomeEstado; }
            set { nomeEstado = value; }
        }

        public char Sigla
        {
            get { return sigla; }
            set { sigla = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        public int CodPais
        {
            get { return codPais; }
            set { codPais = value; }
        }

        // Placeholder for future implementation
        // public Paises Pais { get; set; }
    }

}
