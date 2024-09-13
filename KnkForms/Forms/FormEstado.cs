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

namespace KnkForms.Classes
{
    public partial class FormEstado : KnkForms.FormPai
    {
        public FormEstado()
        {
            InitializeComponent();
        }

        public async Task Salvar()
        {
            Estados novoEstado = new Estados();

            novoEstado.Id = Convert.ToInt32(txtId.Text);
            novoEstado.IdEmpresa = Convert.ToInt32(txtIdEmp.Text);
            DateTime dataCadastro;
            DateTime dataModificacao;

            if (DateTime.TryParse(txtDataCad.Text, out dataCadastro))
            {
                novoEstado.DataCadastro = dataCadastro;
            }
            else
            {
                MessageBox.Show("Data de cadastro inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DateTime.TryParse(txtDataAlt.Text, out dataModificacao))
            {
                novoEstado.DataModificacao = dataModificacao;
            }
            else
            {
                MessageBox.Show("Data de modificação inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            novoEstado.NomeEstado = txtNomeEstado.Text;
            novoEstado.Sigla = Convert.ToChar(txtSigla.Text);
            novoEstado.pais = Convert.ToInt32(txtIdPais.Text);
            novoEstado.Ativo = chkAtivo.Checked;

            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string jsonItem = JsonConvert.SerializeObject(novoEstado);
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
