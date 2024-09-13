using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    public class Clientes:Pai
    {
        public string Nome { get; set; }
        public string RazaoSocial { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public bool FisicaJuridica { get; set; }
        public bool Ativo { get; set; }
        public string ConsumidorRevenda { get; set; }
        
        public string InscricaoEstadual { get; set; }
        public string InscMunicipalSuframa { get; set; }
        public string CNPJ { get; set; }
        public string RegimeTributarioDaEmpresa { get; set; }
        public DateTime DataFundacao { get; set; }
        public string RegimeSemSt { get; set; }
        public string ProdutorRural { get; set; }
        public string TipoContato { get; set; }
        public string Contato { get; set; }
        public string Observacao { get; set; }
        public bool VerEmFornecedores { get; set; }
        public string PessoasAutorizadas { get; set; }
        public string Observacoes { get; set; }
        public string Contato2 { get; set; }
        public DateTime UltimaCompra { get; set; }
        public bool EnviarWeb { get; set; }
        public string CodigoWeb { get; set; }

        //Agreggation part
        public RamoAtividades ramoAtividades { get; set; }
        public Regioes regioes { get; set; }
        public Vendedores vendedores { get; set; }
        public Funcionarios funcionarios { get; set; }
        public CondicaoPagamentos condicaoPagamentos { get; set; }
        public Cidades cidades { get; set; }
        public Transportadoras transportadoras { get; set; }
        public Contadores contadores { get; set; }
        public Fornecedores fornecedores { get; set; }
        public ListaPrecos listaPrecos { get; set; }
    }
}
