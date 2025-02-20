using KnkForms.Classes;
using KnkForms.Forms;
using KnkForms.FormsCad;
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
    public partial class FormConRamoAtividades : KnkForms.FormsCon.FormConPai
    {
        FormCadRamoAtividade oFormCadRamoAtividade;
        RamoAtividades oRamoAtividade;
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\localKerp.mdf;Integrated Security=True;Connect Timeout=30";
        //"Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";
        string query = "SELECT IdRamo, NomeRamo, Ativo, IdEmpresa, DataCadastro, DataModificacao FROM RamoAtividades";

        public FormConRamoAtividades()
        {
            InitializeComponent();
            CarregaLV();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadRamoAtividade = (FormCadRamoAtividade)form;
        }

        public override void ConhecaObj(Object obj)
        {
            oRamoAtividade = (RamoAtividades)obj;
        }
        private async Task CarregaLV()
        {
            using (HttpClient httpClient = new HttpClient())
            {

                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync($"https://localhost:7231/ramoAtividades");

                    if (response.IsSuccessStatusCode)
                    {
                        RamoAtividadeServices buscaRamoAtividades = new RamoAtividadeServices();
                        List<RamoAtividades> ramoAtividadesProcurada = await buscaRamoAtividades.Dados();

                        try
                        {
                            listVConsulta.Items.Clear();

                            foreach (RamoAtividades ramoAtividades in ramoAtividadesProcurada)
                            {
                                ListViewItem item = new ListViewItem(ramoAtividades.Cod.ToString());

                                item.SubItems.Add(ramoAtividades.Ramo.ToString());
                                item.SubItems.Add(ramoAtividades.Ativo.ToString());
                                item.SubItems.Add(ramoAtividades.CodEmpresa.ToString());
                                item.SubItems.Add(Convert.ToDateTime(ramoAtividades.DataCadastro).ToString("dd/MM/yyyy"));
                                item.SubItems.Add(Convert.ToDateTime(ramoAtividades.DataModificacao).ToString("dd/MM/yyyy"));

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
                    MessageBox.Show("Erro ao carregar os dados de RamoAtividadeses: " + ex.Message);
                }
            }
        }

        protected override void Incluir()
        {
            oFormCadRamoAtividade.ConhecaObj(oRamoAtividade);
            oFormCadRamoAtividade.LimpaTxt();
            oFormCadRamoAtividade.ShowDialog();
            CarregaLV();
        }

        protected override void Alterar()
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

                oFormCadRamoAtividade.ConhecaObj(oRamoAtividade);
                oFormCadRamoAtividade.LimpaTxt();
                oFormCadRamoAtividade.CarregaTxt(campo1, campo2, campo3, campo4, campo5, campo6);
                oFormCadRamoAtividade.ShowDialog();
            }
            CarregaLV();
        }

        protected override void Excluir()
        {
            if (listVConsulta.SelectedItems.Count > 0)
            {
                var selectedItem = listVConsulta.SelectedItems[0];

                int campo1 = Convert.ToInt32(selectedItem.SubItems[0].Text);

                oRamoAtividade.ExcluirBD(campo1);
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

                    string queryPesquisa = "SELECT IdRamo, NomeRamo, Ativo, IdEmpresa, DataCadastro, DataModificacao " +
                                   "FROM RamoAtividades WHERE NomeRamo LIKE @searchText OR IdRamo LIKE @searchText";

                    using (SqlCommand command = new SqlCommand(queryPesquisa, connection))
                    {
                        command.Parameters.AddWithValue("@searchText", "%" + txtPesquisa.Text + "%");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["IdRamo"].ToString());
                                item.SubItems.Add(reader["NomeRamo"].ToString());
                                item.SubItems.Add(reader["Ativo"].ToString());
                                item.SubItems.Add(reader["IdEmpresa"].ToString());
                                item.SubItems.Add(Convert.ToDateTime(reader["DataCadastro"]).ToString("dd/MM/yyyy"));
                                item.SubItems.Add(Convert.ToDateTime(reader["DataModificacao"]).ToString("dd/MM/yyyy"));

                                listVConsulta.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao pesquisar os dados de Ramo de Atividades: " + ex.Message);
                }
            }
        }
        private void listV_DoubleClick(object sender, EventArgs e)
        {
            if (listVConsulta.SelectedItems.Count > 0)
            {
                var selectedItem = listVConsulta.SelectedItems[0];

                int idRamoAtiv = Convert.ToInt32(selectedItem.SubItems[0].Text);
                string nomeRamoAtiv = (selectedItem.SubItems[1].Text);
                string tipo = "RamoAtiv";

                var cadCliente = this.Owner as FormCadCliente;
                if (cadCliente != null)
                {
                    cadCliente.SetConsultas(idRamoAtiv, nomeRamoAtiv, tipo);
                }

                var cadRamoCliente = this.Owner as FormCadRamoAtivCliente;
                if (cadRamoCliente != null)
                {
                    cadRamoCliente.SetConsultas(idRamoAtiv, nomeRamoAtiv, tipo);
                }

                this.Close();
            }
        }
    }
}
