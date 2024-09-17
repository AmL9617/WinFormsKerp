using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class Paises : Pai
    {
        protected string nomePais;
        protected string tipoPais;
        protected char sigla;
        protected int ddi;
        protected bool ativo;

        public Paises()
        {
            nomePais = "";
            tipoPais = "";
            sigla = '\0'; // Default value for char
            ddi = 0;
            ativo = false;
        }

        public string NomePais
        {
            get { return nomePais; }
            set { nomePais = value; }
        }

        public string TipoPais
        {
            get { return tipoPais; }
            set { tipoPais = value; }
        }

        public char Sigla
        {
            get { return sigla; }
            set { sigla = value; }
        }

        public int DDI
        {
            get { return ddi; }
            set { ddi = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }
    }

}
