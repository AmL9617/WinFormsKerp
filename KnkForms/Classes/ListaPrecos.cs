using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class ListaPrecos : Pai
    {
        protected string nomeLista;
        protected float descontoMaximo;
        protected float margemLucro;
        protected bool todas;

        // Aggregation part
        protected Marcas marcas;
        protected Grupos grupos;

        public ListaPrecos()
        {
            nomeLista = "";
            descontoMaximo = 0.0f;
            margemLucro = 0.0f;
            todas = false;
            marcas = null;
            grupos = null;
        }

        public string NomeLista
        {
            get { return nomeLista; }
            set { nomeLista = value; }
        }

        public float DescontoMaximo
        {
            get { return descontoMaximo; }
            set { descontoMaximo = value; }
        }

        public float MargemLucro
        {
            get { return margemLucro; }
            set { margemLucro = value; }
        }

        public bool Todas
        {
            get { return todas; }
            set { todas = value; }
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
