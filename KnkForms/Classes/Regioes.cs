using KnkForms.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnkForms.Classes
{
    internal class Regioes : Pai
    {
        protected string regiao;
        protected char ativo;
        protected string descricao;
        protected int codUsuario;

            
        public Regioes()
        {
            regiao = "";
            ativo = '\0';
            descricao = "";
            codUsuario = 0;
        }

        public string Regiao
        {
            get { return regiao; }
            set { regiao = value; }
        }

        public char Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        [JsonProperty("IdUsuario")]
        public int CodUsuario
        {
            get { return codUsuario; }
            set { codUsuario = value; }
        }
        public async void SalvarBD(Regioes aRegiao)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string jsonItem = JsonConvert.SerializeObject(aRegiao, Formatting.Indented);
                    HttpContent content = new StringContent(jsonItem, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await httpClient.PostAsync("https://localhost:7231/Regiao", content);
                    response.EnsureSuccessStatusCode();

                    MessageBox.Show("Dados inseridos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro:{ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public async void AlterarBD(Regioes aRegiao)
        {
            int idEmp = 1;
            int id = aRegiao.Cod;
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string jsonItem = JsonConvert.SerializeObject(aRegiao);
                    HttpContent content = new StringContent(jsonItem, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await httpClient.PutAsync($"https://localhost:7231/Regiao/{idEmp}/{id}", content);
                    response.EnsureSuccessStatusCode();

                    MessageBox.Show("Item Atualizado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro:{ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public async void ExcluirBD(int CodRegiao)
        {
            int CodEmp = 1;
            using (HttpClient httpClient = new HttpClient())
            {

                RegiaoServices buscarRegiao = new RegiaoServices();
                try
                {
                    HttpResponseMessage response = await httpClient.DeleteAsync($"https://localhost:7231/Regiao/{CodEmp}/{CodRegiao}");

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
