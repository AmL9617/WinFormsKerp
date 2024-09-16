using KnkForms.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnkForms.Forms
{
    public partial class FormCadCidade : KnkForms.FormCadPai
    {
        public FormCadCidade()
        {
            InitializeComponent();
        }

        public async Task Salvar()
        {
            Cidades novaCidade = new Cidades();

            novaCidade.Id = Convert.ToInt32(txtId.Text);
            DateTime dataCadastro;
            DateTime dataModificacao;

            if (DateTime.TryParse(txtDataCad.Text, out dataCadastro))
            {
                novaCidade.DataCadastro = dataCadastro;
            }
            else
            {
                MessageBox.Show("Data de cadastro inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DateTime.TryParse(txtDataAlt.Text, out dataModificacao))
            {
                novaCidade.DataModificacao = dataModificacao;
            }
            else
            {
                MessageBox.Show("Data de modificação inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            novaCidade.NomeCidade = txtNomeCidade.Text;
            novaCidade.DDD = Convert.ToChar(txtDDD.Text);
            novaCidade.estado = Convert.ToInt32(txtIdEstado.Text);
            novaCidade.Ativo = chkAtivo.Checked;

            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string jsonItem = JsonConvert.SerializeObject(novaCidade);
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
