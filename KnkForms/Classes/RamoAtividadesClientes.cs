using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class RamoAtividadesClientes:RamoAtividades
    {
        protected int codClienteFornecedor;
        protected int prioridade;

        protected Clientes clientes;
        public RamoAtividadesClientes()
        {
            codClienteFornecedor = 0;
            prioridade = 0;
            clientes = new Clientes();
        }

        public int CodClienteFornecedor
        {
            get { return codClienteFornecedor; }
            set { codClienteFornecedor = value; }
        }

        public int Prioridade
        {
            get { return prioridade; }
            set { prioridade = value; }
        }
        public Clientes Clientes
        {
            get { return clientes; }
            set { clientes = value; }
        }
    }
}
