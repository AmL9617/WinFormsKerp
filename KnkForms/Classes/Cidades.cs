using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KnkForms.Services;

namespace KnkForms.Classes
{
    internal class Cidades : Pai
    {
        protected string cidade;
        protected string ddd;
        protected char ativo;

        //Placeholder
        protected int codEstado;
        protected Estados estados;
        protected string estado;
        
        
        public Cidades()
        {
            cidade = "";
            ddd = "";
            ativo = '\0';
            estado = "";
            estados = new Estados();
            codEstado = 0;
            
        }

        [JsonProperty("Cidade")]
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        [JsonProperty("Ddd")]
        public string DDD
        {
            get { return ddd; }
            set { ddd = value; }
        }

        [JsonProperty("Ativo")]
        public char Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        [JsonProperty("IdEstado")]
        public int CodEstado
        {
            get { return codEstado; }
            set { codEstado = value; }
        }
        [JsonProperty("Estado")]
        public string Estado
        {
            get { return estado; }
            set {  estado = value; }
        }
        [JsonIgnore]
        public Estados Estados
        {
            get { return estados; }
            set { estados = value; }
        }
        public async Task SalvarBD(Cidades aCidade)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string jsonItem = JsonConvert.SerializeObject(aCidade, Formatting.Indented);
                    HttpContent content = new StringContent(jsonItem, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await httpClient.PostAsync("https://localhost:7231/Cidade", content);
                    response.EnsureSuccessStatusCode();

                    MessageBox.Show("Dados inseridos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro:{ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public async void AlterarBD(Cidades aCidade)
        {
            int idEmp = 1;
            int id = aCidade.Cod;
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string jsonItem = JsonConvert.SerializeObject(aCidade);
                    HttpContent content = new StringContent(jsonItem, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await httpClient.PutAsync($"https://localhost:7231/Cidade/{idEmp}/{id}", content);
                    response.EnsureSuccessStatusCode();

                    MessageBox.Show("Item Atualizado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro:{ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public async void ExcluirBD(int CodCidade)
        {
            int CodEmp = 1;
            using (HttpClient httpClient = new HttpClient())
            {
                
                CidadeServices buscaCidade = new CidadeServices();
                try
                {
                    HttpResponseMessage response = await httpClient.DeleteAsync($"https://localhost:7231/Cidade/{CodEmp}/{CodCidade}");

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
