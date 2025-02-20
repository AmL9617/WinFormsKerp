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
    //ST é situação tributária
    internal class ListaCodST:Pai
    {
        protected string codCst;
        protected string tipo;
        protected string descricao;
        protected char ativo;

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\localKerp.mdf;Integrated Security=True;Connect Timeout=30";
        //"Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";
        public ListaCodST()
        {
            codCst = "";
            tipo = "";
            descricao = "";
            ativo = '\0';
        }
        public string CodCst
        {
            get { return codCst; }
            set { codCst = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Descricao 
        {
            get { return descricao; } 
            set { descricao = value; } 
        }
        public char Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        public async void SalvarBD(ListaCodST aListaCST)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string jsonItem = JsonConvert.SerializeObject(aListaCST, Formatting.Indented);
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
        public async void AlterarBD(ListaCodST aListaCST)
        {
            int idEmp = 1;
            int id = aListaCST.Cod;
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string jsonItem = JsonConvert.SerializeObject(aListaCST);
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

                EstadoServices buscaEstado = new EstadoServices();
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
