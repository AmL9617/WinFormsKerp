using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class Estados : Pai
    {
        protected string estado;
        protected char sigla;
        protected bool ativo;
        protected double per_icms;
        protected int icms;

        //Placeholder
        protected int codPais;

        //Agregação
        protected Paises oPais;

        public Estados():base()
        {
            estado = "";
            sigla = '\0'; 
            ativo = false;
            codPais = 0;
            per_icms = 0;
            icms = 0;
            oPais = new Paises();
        }

        public Estados(int cod, int codEmpresa, DateTime dataCadastro, DateTime dataModificacao, string estado, char sigla, bool Ativo, int codPais, double per_icms, int icms, Paises oPais) : base(cod, codEmpresa, dataCadastro, dataModificacao)
        {
            estado = Estado;
            sigla = sigla;
            ativo = ativo;
            per_icms = per_icms;
            icms = icms;
            codPais = codPais;
            oPais = oPais;
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
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
        public double Per_icms
        {
            get { return per_icms; }
            set { per_icms = value; }
        }

        public int Icms
        {
            get { return icms; }
            set { icms = value; }
        }
        public Paises Pais
        {
            get { return oPais; }
            set { oPais = value; }
        }

    }

}
