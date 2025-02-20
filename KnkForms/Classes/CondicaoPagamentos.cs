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
    internal class CondicaoPagamentos : Pai
    {
        protected string condPag;
        protected char ativo;
        protected string tipo;
        protected decimal? taxaJuro;
        protected string operacaoDisponivel;
        protected int? numeroParcelas;
        protected string dia;
        protected string porParcela;

        public CondicaoPagamentos()
        {
            condPag = "";
            ativo = '\0';
            tipo = "";
            taxaJuro = 0;
            operacaoDisponivel = "";
            numeroParcelas = 0;
            dia = "";
            porParcela = "";
        }
        [JsonProperty("CondicaoPagamento")]
        public string CondPag
        {
            get { return condPag; }
            set { condPag = value; }
        }

        public char Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        [JsonProperty("TaxaJuros")]
        public decimal? TaxaJuro
        {
            get { return taxaJuro; }
            set { taxaJuro = value; }
        }
        [JsonProperty("Operacao")]
        public string OperacaoDisponivel
        {
            get { return operacaoDisponivel; }
            set { operacaoDisponivel = value; }
        }

        public int? NumeroParcelas
        {
            get { return numeroParcelas; }
            set { numeroParcelas = value; }
        }
        public string Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        public string PorParcela
        {
            get { return porParcela; }
            set { porParcela = value; }
        }
        public async void SalvarBD(CondicaoPagamentos aCondPag)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string jsonItem = JsonConvert.SerializeObject(aCondPag, Formatting.Indented);
                    HttpContent content = new StringContent(jsonItem, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await httpClient.PostAsync("https://localhost:7231/CondPag", content);
                    response.EnsureSuccessStatusCode();

                    MessageBox.Show("Dados inseridos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro:{ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public async void AlterarBD(CondicaoPagamentos aCondPag)
        {
            int idEmp = 1;
            int id = aCondPag.Cod;
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string jsonItem = JsonConvert.SerializeObject(aCondPag);
                    HttpContent content = new StringContent(jsonItem, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await httpClient.PutAsync($"https://localhost:7231/CondPag/{idEmp}/{id}", content);
                    response.EnsureSuccessStatusCode();

                    MessageBox.Show("Item Atualizado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro:{ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public async void ExcluirBD(int CodCondPag)
        {
            int CodEmp = 1;
            using (HttpClient httpClient = new HttpClient())
            {

                EstadoServices buscaEstado = new EstadoServices();
                try
                {
                    HttpResponseMessage response = await httpClient.DeleteAsync($"https://localhost:7231/CondPag/{CodEmp}/{CodCondPag}");

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
