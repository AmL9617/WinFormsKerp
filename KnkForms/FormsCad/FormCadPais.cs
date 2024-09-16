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
    public partial class FormCadPais : KnkForms.FormCadPai
    {
        public FormCadPais()
        {
            InitializeComponent();
        }
        public async Task Salvar()
        {
            Paises novoPais = new Paises();

            novoPais.Id = Convert.ToInt32(txtId.Text);

            DateTime dataCadastro;
            DateTime dataModificacao;

            if (DateTime.TryParse(txtDataCad.Text, out dataCadastro))
            {
                novoPais.DataCadastro = dataCadastro;
            }
            else
            {
                MessageBox.Show("Data de cadastro inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DateTime.TryParse(txtDataAlt.Text, out dataModificacao))
            {
                novoPais.DataModificacao = dataModificacao;
            }
            else
            {
                MessageBox.Show("Data de modificação inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            novoPais.NomePais = txtNomePais.Text;
            novoPais.TipoPais = txtTipoPais.Text;
            novoPais.Sigla = Convert.ToChar(txtSigla.Text);
            novoPais.DDI = Convert.ToInt32(txtDdi.Text);
            novoPais.Ativo = chkAtivo.Checked;

            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string jsonItem = JsonConvert.SerializeObject(novoPais);
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
