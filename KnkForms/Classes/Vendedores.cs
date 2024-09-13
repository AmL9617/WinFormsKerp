using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    public class Vendedores : Pai
    {
        public string NomeVendedor {get; set;}
        public bool Ativo {get; set;}
        public string Tipo {get; set;}
        public float Comissao {get; set;}
        public DateTime ComissaoPrazo {get; set;}
        public string Observacao {get; set;}
}
}
