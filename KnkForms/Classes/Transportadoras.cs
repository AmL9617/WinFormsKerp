using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    public class Transportadoras:Pai
    {
        public string TransportadoraCliente { get; set; }
        public string FisicaJuridica { get; set; }
        public bool Ativo { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string Fax { get; set; }
        public string Celular { get; set; }
        public string Contato { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string Observacao { get; set; }
        public DateTime UltimaCompra { get; set; }
        public string InscricaoEstadual { get; set; }
        public string CNPJ { get; set; }
    }
}
