using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class Pai
    {
        protected int cod;
        protected int codEmpresa;
        protected DateTime dataCadastro;
        protected DateTime dataModificacao;

        public Pai()
        {
            cod = 0;
            codEmpresa = 0;
            dataCadastro = DateTime.MinValue;
            dataModificacao = DateTime.MinValue;
        }

        public int Cod
        {
            get { return cod; }
            set { cod = value; }
        }

        public int CodEmpresa
        {
            get { return codEmpresa; }
            set { codEmpresa = value; }
        }

        public DateTime DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }

        public DateTime DataModificacao
        {
            get { return dataModificacao; }
            set { dataModificacao = value; }
        }
    }
}
