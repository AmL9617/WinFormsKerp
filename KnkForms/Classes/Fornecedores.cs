using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    public class Fornecedores:Pai
    {
        public string Industria { get; set; }
        public bool FisicaJuridica { get; set; }
        public bool Ativo { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string TipoContato { get; set; }
        public string Contato { get; set; }
        public string Observacao { get; set; }
        public string CNPJ { get; set; }
        public string InscricaoEstadual { get; set; }
        public string Trade { get; set; }
        public int CodProdIgual { get; set; }
        public float LimiteCredito { get; set; }
        public string Observacoes { get; set; }
        public bool VerEmClientes { get; set; }
        public DateTime UltimoMovimento { get; set; }
    }
}
