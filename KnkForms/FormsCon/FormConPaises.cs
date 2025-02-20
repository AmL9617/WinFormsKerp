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
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KnkForms.FormsCon
{
    public partial class FormConPaises : KnkForms.FormsCon.FormConPai
    {
        FormCadPais oFormCadPais;
        Paises oPais;
        
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\localKerp.mdf;Integrated Security=True;Connect Timeout=30";
        //"Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";
        string query = "SELECT IdPais, Pais, Sigla, DDI, Nacional, Ativo, IdEmpresa, DataCadastro, DataModificacao FROM Pais";
            
        public FormConPaises()
        {
            InitializeComponent();
            CarregaLV();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadPais = (FormCadPais)form;
        }

        public override void ConhecaObj(Object obj)
        {
            oPais = (Paises)obj;
        }

        private async Task CarregaLV()
        {
            using (HttpClient httpClient = new HttpClient())
            {

                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync($"https://localhost:7231/Pais");

                    if (response.IsSuccessStatusCode)
                    {
                        PaisServices buscaPais = new PaisServices();
                        List<Paises> PaisProcurado = await buscaPais.Dados();

                        try
                        {
                            listVConsulta.Items.Clear();

                            foreach (Paises pais in PaisProcurado)
                            {
                                ListViewItem item = new ListViewItem(pais.Cod.ToString());

                                item.SubItems.Add(pais.Pais.ToString());
                                item.SubItems.Add(pais.Sigla.ToString());
                                item.SubItems.Add(pais.DDI.ToString());
                                item.SubItems.Add(Convert.ToChar(pais.Nacional) == 'S' ? "Sim" : "Não");
                                item.SubItems.Add(Convert.ToString(pais.CodEmpresa));
                                item.SubItems.Add(Convert.ToDateTime(pais.DataCadastro).ToString("dd/MM/yyyy"));
                                item.SubItems.Add(Convert.ToDateTime(pais.DataModificacao).ToString("dd/MM/yyyy"));

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
                    MessageBox.Show("Erro ao carregar os dados de Paises: " + ex.Message);
                }
            }
        }

        protected override void Incluir()
        {
            oFormCadPais.ConhecaObj(oPais);
            oFormCadPais.LimpaTxt();
            oFormCadPais.ShowDialog();
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
                string campo7 = selectedItem.SubItems[6].Text;
                string campo8 = selectedItem.SubItems[7].Text;

                oFormCadPais.ConhecaObj(oPais);
                oFormCadPais.LimpaTxt();
                oFormCadPais.CarregaTxt(campo1, campo2, campo3, campo4, campo5, campo6, campo7, campo8);
                oFormCadPais.ShowDialog();
            }
            CarregaLV();
        }

        protected override void Excluir()
        {
            if (listVConsulta.SelectedItems.Count > 0)
            {
                var selectedItem = listVConsulta.SelectedItems[0];

                int campo1 = Convert.ToInt32(selectedItem.SubItems[0].Text);

                oPais.ExcluirBD(campo1);
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

                    string queryPesquisa = "SELECT IdPais, Pais, Sigla, DDI, Nacional, Ativo, IdEmpresa, DataCadastro, DataModificacao " +
                                   "FROM Pais WHERE Pais LIKE @searchText OR IdPais LIKE @searchText";

                    using (SqlCommand command = new SqlCommand(queryPesquisa, connection))
                    {
                        command.Parameters.AddWithValue("@searchText", "%" + txtPesquisa.Text + "%");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["IdPais"].ToString());

                                item.SubItems.Add(reader["Pais"].ToString());
                                item.SubItems.Add(reader["Sigla"].ToString());
                                item.SubItems.Add(reader["DDI"].ToString());
                                item.SubItems.Add(Convert.ToChar(reader["Nacional"]) == 's' ? "Sim" : "Não");
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
                    MessageBox.Show("Erro ao pesquisar os dados de País: " + ex.Message);
                }
            }
        }
        private void listV_DoubleClick(object sender, EventArgs e)
        {
            if (listVConsulta.SelectedItems.Count > 0)
            {
                var selectedItem = listVConsulta.SelectedItems[0];

                int idPais = Convert.ToInt32(selectedItem.SubItems[0].Text);
                string nomePais = (selectedItem.SubItems[1].Text);

                var cadEstado = this.Owner as FormCadEstado;
                if (cadEstado != null)
                {
                    cadEstado.SetPais(idPais, nomePais);
                }

                this.Close();
            }
        }
    }
}
