using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class ListaPrecos : Pai
    {
        protected string lista;
        protected double descontoMaximo;
        protected double margemLucro;
        protected double percCom;
        protected bool todas;

        //Placeholder
        protected int codMarca;
        protected int codSubgrupo;

        //Agregação
        protected Marcas marcas;
        protected Subgrupos subgrupos;

        public ListaPrecos()
        {
            lista = "";
            descontoMaximo = 0.0f;
            margemLucro = 0.0f;
            percCom = 0.0f;
            todas = false;
            marcas = new Marcas();
            subgrupos = new Subgrupos();
            codMarca = 0;
            codSubgrupo = 0;
        }

        public string Lista
        {
            get { return lista; }
            set { lista = value; }
        }

        public double DescontoMaximo
        {
            get { return descontoMaximo; }
            set { descontoMaximo = value; }
        }

        public double MargemLucro
        {
            get { return margemLucro; }
            set { margemLucro = value; }
        }

        public double PercCom
        {
            get { return percCom; }
            set { percCom = value; }
        }

        public bool Todas
        {
            get { return todas; }
            set { todas = value; }
        }

        public int CodMarca
        {
            get { return codMarca; }
            set { codMarca = value; }
        }

        public int CodSubgrupo
        {
            get { return codSubgrupo; }
            set { codSubgrupo = value; }
        }

        public Marcas Marcas
        {
            get { return marcas; }
            set { marcas = value; }
        }

        public Subgrupos Subgrupos
        {
            get { return subgrupos; }
            set { subgrupos = value; }
        }
    }

}
