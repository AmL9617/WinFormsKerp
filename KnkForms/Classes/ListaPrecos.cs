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
        protected int codGrupo;

        //Agregação
        protected Marcas marcas;
        protected Grupos grupos;

        public ListaPrecos()
        {
            lista = "";
            descontoMaximo = 0.0f;
            margemLucro = 0.0f;
            percCom = 0.0f;
            todas = false;
            marcas = new Marcas();
            grupos = new Grupos();
            codMarca = 0;
            codGrupo = 0;
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
            set { CodMarca = value; }
        }

        public int CodGrupo
        {
            get { return codGrupo; }
            set { CodGrupo = value; }
        }

        public Marcas Marcas
        {
            get { return marcas; }
            set { marcas = value; }
        }

        public Grupos Grupos
        {
            get { return grupos; }
            set { grupos = value; }
        }
    }

}
