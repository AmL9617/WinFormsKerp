using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    public class ListaPrecos:Pai
    {
        public string NomeLista { get; set; }
        public float DescontoMaximo {  get; set; }
        public float MargemLucro { get; set; }
        public bool Todas {  get; set; }

        public Marcas marcas { get; set; }
        public Grupos grupos { get; set; }
    }
}
