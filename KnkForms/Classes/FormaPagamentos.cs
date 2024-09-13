using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    public class FormaPagamentos:Pai
    {
        public string Nome { get; set; }
        public string OperacaoDisponivel { get; set; }
        public string Nfce { get; set; }
    }
}
