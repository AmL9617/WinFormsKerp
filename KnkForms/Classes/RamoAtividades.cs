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
    internal class RamoAtividades : Pai
    {
        protected string ramo;
        protected string ativo;

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\localKerp.mdf;Integrated Security=True;Connect Timeout=30";
        //"Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";

        public RamoAtividades()
        {
            ramo = "";
            ativo = "";
        }
        [JsonProperty("NomeRamo")]
        public string Ramo
        {
            get { return ramo; }
            set { ramo = value; }
        }

        public string Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        public async void SalvarBD(RamoAtividades oRamoAtividades)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string jsonItem = JsonConvert.SerializeObject(oRamoAtividades, Formatting.Indented);
                    HttpContent content = new StringContent(jsonItem, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await httpClient.PostAsync("https://localhost:7231/RamoAtividades", content);
                    response.EnsureSuccessStatusCode();

                    MessageBox.Show("Dados inseridos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro:{ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public async void AlterarBD(RamoAtividades oRamoAtividades)
        {
            int idEmp = 1;
            int id = oRamoAtividades.Cod;
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string jsonItem = JsonConvert.SerializeObject(oRamoAtividades);
                    HttpContent content = new StringContent(jsonItem, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await httpClient.PutAsync($"https://localhost:7231/RamoAtividades/{idEmp}/{id}", content);
                    response.EnsureSuccessStatusCode();

                    MessageBox.Show("Item Atualizado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro:{ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public async void ExcluirBD(int CodRamoAtividades)
        {
            int CodEmp = 1;
            using (HttpClient httpClient = new HttpClient())
            {

                RegiaoServices buscarRegiao = new RegiaoServices();
                try
                {
                    HttpResponseMessage response = await httpClient.DeleteAsync($"https://localhost:7231/RamoAtividades/{CodEmp}/{CodRamoAtividades}");

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
