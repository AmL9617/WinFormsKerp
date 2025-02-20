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
    internal class ListaPrecos : Pai
    {
        protected string lista;
        protected double descontoMaximo;
        protected double margemLucro;
        protected double percCom;
        protected string todas;

        //Placeholder
        protected int codMarca;
        protected int codSubgrupo;

        //Agregação
        protected Marcas marcas;
        protected Subgrupos subgrupos;
        
        public ListaPrecos()
        {
            lista = "";
            descontoMaximo = 0.0f;
            margemLucro = 0.0f;
            percCom = 0.0f;
            todas = "";
            marcas = new Marcas();
            subgrupos = new Subgrupos();
            codMarca = 0;
            codSubgrupo = 0;
        }

        public string Lista
        {
            get { return lista; }
            set { lista = value; }
        }
        [JsonProperty("DescMax")]
        public double DescontoMaximo
        {
            get { return descontoMaximo; }
            set { descontoMaximo = value; }
        }

        public double MargemLucro
        {
            get { return margemLucro; }
            set { margemLucro = value; }
        }
        [JsonProperty("PerComissao")]
        public double PercCom
        {
            get { return percCom; }
            set { percCom = value; }
        }

        public string Todas
        {
            get { return todas; }
            set { todas = value; }
        }
        [JsonIgnore]
        public int CodMarca
        {
            get { return codMarca; }
            set { codMarca = value; }
        }
        [JsonIgnore]
        public int CodSubgrupo
        {
            get { return codSubgrupo; }
            set { codSubgrupo = value; }
        }
        [JsonIgnore]
        public Marcas Marcas
        {
            get { return marcas; }
            set { marcas = value; }
        }
        [JsonIgnore]
        public Subgrupos Subgrupos
        {
            get { return subgrupos; }
            set { subgrupos = value; }
        }
        public async void SalvarBD(ListaPrecos aLista)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string jsonItem = JsonConvert.SerializeObject(aLista, Formatting.Indented);
                    HttpContent content = new StringContent(jsonItem, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await httpClient.PostAsync("https://localhost:7231/Lista", content);
                    response.EnsureSuccessStatusCode();

                    MessageBox.Show("Dados inseridos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro:{ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public async void AlterarBD(ListaPrecos aLista)
        {
            int idEmp = 1;
            int id = aLista.Cod;
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string jsonItem = JsonConvert.SerializeObject(aLista);
                    HttpContent content = new StringContent(jsonItem, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await httpClient.PutAsync($"https://localhost:7231/Lista/{idEmp}/{id}", content);
                    response.EnsureSuccessStatusCode();

                    MessageBox.Show("Item Atualizado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro:{ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public async void ExcluirBD(int CodLista)
        {
            int CodEmp = 1;
            using (HttpClient httpClient = new HttpClient())
            {

                ListaPrecoServices buscaLista = new ListaPrecoServices();
                try
                {
                    HttpResponseMessage response = await httpClient.DeleteAsync($"https://localhost:7231/Lista/{CodEmp}/{CodLista}");

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
