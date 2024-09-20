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
        protected Paises oPais;

        public Estados():base()
        {
            nomeEstado = "";
            sigla = '\0'; 
            ativo = false;
            codPais = 0; 
            oPais = new Paises();
        }

        public Estados(int cod, int codEmpresa, DateTime dataCadastro, DateTime dataModificacao, string nomeEstado, char sigla, bool Ativo, int codPais, Paises oPais) : base(cod, codEmpresa, dataCadastro, dataModificacao)
        {
            nomeEstado = nomeEstado;
            sigla = sigla;
            ativo = ativo;
            codPais = codPais;
            oPais = oPais;
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
            get { return oPais; }
            set { oPais = value; }
        }

    }

}
