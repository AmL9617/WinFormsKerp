using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KnkForms.Classes;
using Newtonsoft.Json;

namespace KnkForms
{
    public partial class FormPai : Form
    {
        public FormPai()
        {
            InitializeComponent();
        }

        public async Task Salvar()
        {
            Pai novoPai = new Pai();

            novoPai.Id = Convert.ToInt32(txtId.Text);
            novoPai.IdEmpresa = Convert.ToInt32(txtIdEmp.Text);
            DateTime dataCadastro;
            DateTime dataModificacao;

            if (DateTime.TryParse(txtDataCad.Text, out dataCadastro))
            {
                novoPai.DataCadastro = dataCadastro;
            }
            else
            {
                MessageBox.Show("Data de cadastro inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (DateTime.TryParse(txtDataAlt.Text, out dataModificacao))
            {
                novoPai.DataModificacao = dataModificacao;
            }
            else
            {
                MessageBox.Show("Data de modificação inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string jsonItem = JsonConvert.SerializeObject(novoPai);
                    HttpContent content = new StringContent(jsonItem, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await httpClient.PostAsync("https://localhost:7077/ativ3", content);
                    response.EnsureSuccessStatusCode();

                    MessageBox.Show("Dados inseridos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
