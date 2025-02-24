using KnkForms.Classes;
using KnkForms.Forms;
using KnkForms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnkForms.FormsCon
{
    public partial class FormConListaPrecos : KnkForms.FormsCon.FormConPai
    {
        FormCadListaPreco oFormCadListaPreco;
        ListaPrecos aListaPreco;

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\localKerp.mdf;Integrated Security=True;Connect Timeout=30";
        
        public FormConListaPrecos()
        {
            InitializeComponent();
            CarregaLV();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadListaPreco = (FormCadListaPreco)form;
        }

        public override void ConhecaObj(Object obj)
        {
            aListaPreco = (ListaPrecos)obj;
        }
        private async Task CarregaLV()
        {
            using (HttpClient httpClient = new HttpClient())
            {

                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync($"https://localhost:7231/Lista");

                    if (response.IsSuccessStatusCode)
                    {
                        ListaPrecoServices buscalista = new ListaPrecoServices();
                        List<ListaPrecos> listaProcurada = await buscalista.Dados();

                        try
                        {
                            listVConsulta.Items.Clear();

                            foreach (ListaPrecos lista in listaProcurada)
                            {
                                ListViewItem item = new ListViewItem(lista.Cod.ToString());

                                item.SubItems.Add(lista.Lista.ToString());
                                item.SubItems.Add(lista.DescontoMaximo.ToString());
                                item.SubItems.Add(lista.MargemLucro.ToString());
                                item.SubItems.Add(lista.PercCom.ToString());
                                item.SubItems.Add(lista.Todas);
                                item.SubItems.Add(lista.CodEmpresa.ToString());
                                item.SubItems.Add(Convert.ToDateTime(lista.DataCadastro).ToString("dd/MM/yyyy"));
                                item.SubItems.Add(Convert.ToDateTime(lista.DataModificacao).ToString("dd/MM/yyyy"));

                                listVConsulta.Items.Add(item);

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ocorreu um erro: {ex.Message}");
                        }
                    }

                    else
                    {
                        MessageBox.Show($"Falha na requisição. Status: {response.StatusCode}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os dados de Condicoes Pagamentos: " + ex.Message);
                }
            }
        }
        protected override void Incluir()
        {
            oFormCadListaPreco.ConhecaObj(aListaPreco);
            oFormCadListaPreco.LimpaTxt();
            oFormCadListaPreco.ShowDialog();
            CarregaLV();
        }

        protected override async void Alterar()
        {
            if (listVConsulta.SelectedItems.Count > 0)
            {
                var selectedItem = listVConsulta.SelectedItems[0];

                string campo1 = selectedItem.SubItems[0].Text;
                string campo2 = selectedItem.SubItems[1].Text;
                string campo3 = selectedItem.SubItems[2].Text;
                string campo4 = selectedItem.SubItems[3].Text;
                string campo5 = selectedItem.SubItems[4].Text;
                string campo6 = selectedItem.SubItems[5].Text;
                string campo7 = selectedItem.SubItems[6].Text;  
                string campo8 = selectedItem.SubItems[7].Text;
                string campo9 = selectedItem.SubItems[8].Text;

                oFormCadListaPreco.ConhecaObj(aListaPreco);
                oFormCadListaPreco.LimpaTxt();
                oFormCadListaPreco.CarregaTxt(campo1, campo2, campo3, campo4, campo5, campo6, campo7, campo8, campo9);
                oFormCadListaPreco.ShowDialog();
            }
            CarregaLV();
        }

        protected override void Excluir()
        {
            if (listVConsulta.SelectedItems.Count > 0)
            {
                var selectedItem = listVConsulta.SelectedItems[0];

                int campo1 = Convert.ToInt32(selectedItem.SubItems[0].Text);

                aListaPreco.ExcluirBD(campo1);
            }
            CarregaLV();
        }
        protected override void Pesquisar()
        {
            listVConsulta.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string queryPesquisa = "SELECT IdLista, Lista, DescMax, MargemLucro, PerComissao, Todas, IdEmpresa, DataCadastro, DataModificacao " +
                                   "FROM Lista WHERE Lista LIKE @searchText OR IdLista LIKE @searchText";

                    using (SqlCommand command = new SqlCommand(queryPesquisa, connection))
                    {
                        command.Parameters.AddWithValue("@searchText", "%" + txtPesquisa.Text + "%");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["IdLista"].ToString());

                                item.SubItems.Add(reader["Lista"].ToString());
                                item.SubItems.Add(reader["DescMax"].ToString());
                                item.SubItems.Add(reader["MargemLucro"].ToString());
                                item.SubItems.Add(reader["PerComissao"].ToString());
                                item.SubItems.Add(reader["IdEmpresa"].ToString());
                                item.SubItems.Add(Convert.ToDateTime(reader["DataModificacao"]).ToString("dd/MM/yyyy"));

                                listVConsulta.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao pesquisar os dados de ListaPreços: " + ex.Message);
                }
            }
        }
        private void listV_DoubleClick(object sender, EventArgs e)
        {
            if (listVConsulta.SelectedItems.Count > 0)
            {
                var selectedItem = listVConsulta.SelectedItems[0];

                int idListaPreco = Convert.ToInt32(selectedItem.SubItems[0].Text);
                string nomeListaPreco = (selectedItem.SubItems[1].Text);
                string tipo = "ListaPreco";

                var cadFornecedor = this.Owner as FormCadFornecedor;
                if (cadFornecedor != null)
                {
                    cadFornecedor.SetConsultas(idListaPreco, nomeListaPreco, tipo);
                }
                var cadCliente = this.Owner as FormCadCliente;
                if (cadCliente != null)
                {
                    cadCliente.SetConsultas(idListaPreco, nomeListaPreco, tipo);
                }
                this.Close();
            }
        }

    }
}
