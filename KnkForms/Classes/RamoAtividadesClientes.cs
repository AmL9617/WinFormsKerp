using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class RamoAtividadesClientes:RamoAtividades
    {
        protected int idCliente;
        protected int prioridade;

        public RamoAtividadesClientes()
        {
            idCliente = 0;
            prioridade = 0;
        }

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public int Prioridade
        {
            get { return prioridade; }
            set { prioridade = value; }
        }
    }
}
