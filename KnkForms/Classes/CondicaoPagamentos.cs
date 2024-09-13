using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    public class CondicaoPagamentos:Pai
    {
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public string Tipo { get; set; }
        public float TaxaJuro { get; set; }
        public string OperacaoDisponivel { get; set; }
        public DateTime Prazo { get; set; }

        public Parcelas parcelas { get; set; }
    }
}
