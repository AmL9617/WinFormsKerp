using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    public class Paises : Pai
    {
        public string NomePais {  get; set; }
        public string TipoPais { get; set; }
        public char Sigla { get; set; }
        public int DDI { get; set; }
        public bool Ativo { get; set; }
    }
}
