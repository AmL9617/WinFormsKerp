using KnkForms.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnkForms.Classes
{
    internal class Fornecedores : Pai
    {
        protected string industria; //ConsumidorRevenda
        protected string fisicaJuridica;
        protected string ativo;
        protected string razaoSocial;
        protected string nomeFantasia;
        protected string endereco;
        protected string numero;
        protected string complemento;
        protected string bairro;
        protected string cep;
        protected string cnpj;
        protected string inscricaoEstadual;
        protected string trade;
        protected string codProdIgual;
        protected double? limiteCredito;
        protected string observacoes;
        protected string verEmClientes;
        protected DateTime? ultimoMovimento;

        //Placeholder
        protected int? codCidades;
        protected int? codRegioes;
        protected int? codListaPrecos;
        protected int? codCondPag;
        protected string nomeCidade;
        protected string nomeRegiao;

        //Agregação
        protected Cidades cidades;
        protected Regioes regioes;
        protected ListaPrecos listaPrecos;
        protected CondicaoPagamentos condicaoPagamentos;

        public Fornecedores()
        {
            industria = "";
            fisicaJuridica = "";
            ativo = "";
            razaoSocial = "";
            nomeFantasia = "";
            endereco = "";
            numero = "";
            complemento = "";
            bairro = "";
            cep = "";
            cnpj = "";
            inscricaoEstadual = "";
            trade = "";
            codProdIgual = "";
            limiteCredito = 0.0f;
            observacoes = "";
            verEmClientes = "";
            ultimoMovimento = DateTime.MinValue;

            codCidades = 0;
            nomeCidade = "";
            cidades = new Cidades();
            codRegioes = 0;
            nomeRegiao = "";
            regioes = new Regioes();
            codListaPrecos = 0;
            listaPrecos = new ListaPrecos();
            codCondPag = 0;
            condicaoPagamentos = new CondicaoPagamentos();
        }
        [JsonProperty("ConsumidorRevenda")]
        public string Industria
        {
            get { return industria; }
            set { industria = value; }
        }

        public string FisicaJuridica
        {
            get { return fisicaJuridica; }
            set { fisicaJuridica = value; }
        }

        public string Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        public string RazaoSocial
        {
            get { return razaoSocial; }
            set { razaoSocial = value; }
        }

        public string NomeFantasia
        {
            get { return nomeFantasia; }
            set { nomeFantasia = value; }
        }
        [JsonProperty("Logradouro")]
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Numero
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
        [JsonProperty("CpfCnpj")]
        public string CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public string InscricaoEstadual
        {
            get { return inscricaoEstadual; }
            set { inscricaoEstadual = value; }
        }

        public string Trade
        {
            get { return trade; }
            set { trade = value; }
        }
        [JsonIgnore]
        public string CodProdIgual
        {
            get { return codProdIgual; }
            set { codProdIgual = value; }
        }

        public double? LimiteCredito
        {
            get { return limiteCredito; }
            set { limiteCredito = value; }
        }
        [JsonProperty("Observacao")]
        public string Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }
        [JsonProperty("Tipo")]
        public string VerEmClientes
        {
            get { return verEmClientes; }
            set { verEmClientes = value; }
        }
        [JsonIgnore]
        public DateTime? UltimoMovimento
        {
            get { return ultimoMovimento; }
            set { ultimoMovimento = value; }
        }

        [JsonProperty("IdCidade")]
        public int? CodCidades
        {
            get { return codCidades; }
            set { codCidades = value; }
        }
        [JsonProperty("IdRegiao")]
        public int? CodRegioes
        {
            get { return codRegioes; }
            set { codRegioes = value; }
        }
        [JsonIgnore]
        public int? CodListaPrecos
        {
            get { return codListaPrecos; }
            set { codListaPrecos = value; }
        }
        [JsonIgnore]
        public int? CodCondPag
        {
            get { return codCondPag; }
            set { codCondPag = value; }
        }
        [JsonProperty("Cidade")]
        public string NomeCidade
        {
            get { return nomeCidade; }
            set { nomeCidade = value; }
        }
        [JsonProperty("Regiao")]
        public string NomeRegiao
        {
            get { return nomeRegiao; }
            set { nomeRegiao = value; }
        }
        [JsonIgnore]
        public Cidades Cidades
        {
            get { return cidades; }
            set { cidades = value; }
        }
        [JsonIgnore]
        public Regioes Regioes
        {
            get { return regioes; }
            set { regioes = value; }
        }
        [JsonIgnore]
        public ListaPrecos ListaPrecos
        {
            get { return listaPrecos; }
            set { listaPrecos = value; }
        }
        [JsonIgnore]
        public CondicaoPagamentos CondicaoPagamentos
        {
            get { return condicaoPagamentos; }
            set { condicaoPagamentos = value; }
        }

        public async void SalvarBD(Fornecedores oFornecedor)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string jsonItem = JsonConvert.SerializeObject(oFornecedor, Formatting.Indented);
                    HttpContent content = new StringContent(jsonItem, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await httpClient.PostAsync("https://localhost:7231/Fornecedor", content);
                    response.EnsureSuccessStatusCode();

                    MessageBox.Show("Dados inseridos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro:{ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public async void AlterarBD(Fornecedores oFornecedor)
        {
            int idEmp = 1;
            int id = oFornecedor.Cod;
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string jsonItem = JsonConvert.SerializeObject(oFornecedor);
                    HttpContent content = new StringContent(jsonItem, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await httpClient.PutAsync($"https://localhost:7231/Fornecedor/{idEmp}/{id}", content);
                    response.EnsureSuccessStatusCode();

                    MessageBox.Show("Item Atualizado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro:{ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public async void ExcluirBD(int CodFornecedor)
        {
            int CodEmp = 1;
            using (HttpClient httpClient = new HttpClient())
            {

                RegiaoServices buscarRegiao = new RegiaoServices();
                try
                {
                    HttpResponseMessage response = await httpClient.DeleteAsync($"https://localhost:7231/Fornecedor/{CodEmp}/{CodFornecedor}");

                    response.EnsureSuccessStatusCode();
                    MessageBox.Show($"Deletado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro:{ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

}
