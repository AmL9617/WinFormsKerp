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

        //Placeholder
        protected int codPais;

        //Agregação
        protected Paises pais;

        public Estados()
        {
            nomeEstado = "";
            sigla = '\0'; 
            ativo = false;
            codPais = 0; 
            pais = new Paises();
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
        public Paises Pais
        {
            get { return pais; }
            set { pais = value; }
        }

    }

}
