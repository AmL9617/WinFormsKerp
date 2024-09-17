using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    internal class Clientes : Pai
    {
        protected string nome;
        protected string razaoSocial;
        protected string endereco;
        protected int numero;
        protected string complemento;
        protected string bairro;
        protected string cep;
        protected bool fisicaJuridica;
        protected bool ativo;
        protected string consumidorRevenda;
        protected string inscricaoEstadual;
        protected string inscMunicipalSuframa;
        protected string cnpj;
        protected string regimeTributarioDaEmpresa;
        protected DateTime dataFundacao;
        protected string regimeSemSt;
        protected string produtorRural;
        protected string tipoContato;
        protected string contato;
        protected string observacao;
        protected bool verEmFornecedores;
        protected string pessoasAutorizadas;
        protected string observacoes;
        protected DateTime ultimaCompra;

        // Aggregation parts
        protected RamoAtividades ramoAtividades;
        protected Regioes regioes;
        protected Vendedores vendedores;
        protected Funcionarios funcionarios;
        protected CondicaoPagamentos condicaoPagamentos;
        protected Cidades cidades;
        protected Transportadoras transportadoras;
        protected Contadores contadores;
        protected Fornecedores fornecedores;
        protected ListaPrecos listaPrecos;

        public Clientes()
        {
            nome = "";
            razaoSocial = "";
            endereco = "";
            numero = 0;
            complemento = "";
            bairro = "";
            cep = "";
            fisicaJuridica = false;
            ativo = false;
            consumidorRevenda = "";
            inscricaoEstadual = "";
            inscMunicipalSuframa = "";
            cnpj = "";
            regimeTributarioDaEmpresa = "";
            dataFundacao = DateTime.MinValue;
            regimeSemSt = "";
            produtorRural = "";
            tipoContato = "";
            contato = "";
            observacao = "";
            verEmFornecedores = false;
            pessoasAutorizadas = "";
            observacoes = "";
            ultimaCompra = DateTime.MinValue;

            // Initialize aggregation parts
            ramoAtividades = null;
            regioes = null;
            vendedores = null;
            funcionarios = null;
            condicaoPagamentos = null;
            cidades = null;
            transportadoras = null;
            contadores = null;
            fornecedores = null;
            listaPrecos = null;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string RazaoSocial
        {
            get { return razaoSocial; }
            set { razaoSocial = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public bool FisicaJuridica
        {
            get { return fisicaJuridica; }
            set { fisicaJuridica = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        public string ConsumidorRevenda
        {
            get { return consumidorRevenda; }
            set { consumidorRevenda = value; }
        }

        public string InscricaoEstadual
        {
            get { return inscricaoEstadual; }
            set { inscricaoEstadual = value; }
        }

        public string InscMunicipalSuframa
        {
            get { return inscMunicipalSuframa; }
            set { inscMunicipalSuframa = value; }
        }

        public string CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public string RegimeTributarioDaEmpresa
        {
            get { return regimeTributarioDaEmpresa; }
            set { regimeTributarioDaEmpresa = value; }
        }

        public DateTime DataFundacao
        {
            get { return dataFundacao; }
            set { dataFundacao = value; }
        }

        public string RegimeSemSt
        {
            get { return regimeSemSt; }
            set { regimeSemSt = value; }
        }

        public string ProdutorRural
        {
            get { return produtorRural; }
            set { produtorRural = value; }
        }

        public string TipoContato
        {
            get { return tipoContato; }
            set { tipoContato = value; }
        }

        public string Contato
        {
            get { return contato; }
            set { contato = value; }
        }

        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }

        public bool VerEmFornecedores
        {
            get { return verEmFornecedores; }
            set { verEmFornecedores = value; }
        }

        public string PessoasAutorizadas
        {
            get { return pessoasAutorizadas; }
            set { pessoasAutorizadas = value; }
        }

        public string Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }


        public DateTime UltimaCompra
        {
            get { return ultimaCompra; }
            set { ultimaCompra = value; }
        }


        // Aggregation properties
        public RamoAtividades RamoAtividades
        {
            get { return ramoAtividades; }
            set { ramoAtividades = value; }
        }

        public Regioes Regioes
        {
            get { return regioes; }
            set { regioes = value; }
        }

        public Vendedores Vendedores
        {
            get { return vendedores; }
            set { vendedores = value; }
        }

        public Funcionarios Funcionarios
        {
            get { return funcionarios; }
            set { funcionarios = value; }
        }

        public CondicaoPagamentos CondicaoPagamentos
        {
            get { return condicaoPagamentos; }
            set { condicaoPagamentos = value; }
        }

        public Cidades Cidades
        {
            get { return cidades; }
            set { cidades = value; }
        }

        public Transportadoras Transportadoras
        {
            get { return transportadoras; }
            set { transportadoras = value; }
        }

        public Contadores Contadores
        {
            get { return contadores; }
            set { contadores = value; }
        }

        public Fornecedores Fornecedores
        {
            get { return fornecedores; }
            set { fornecedores = value; }
        }

        public ListaPrecos ListaPrecos
        {
            get { return listaPrecos; }
            set { listaPrecos = value; }
        }
    }

}
