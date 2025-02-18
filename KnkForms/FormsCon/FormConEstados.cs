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

namespace KnkForms.Classes
{
    public partial class FormConEstados : KnkForms.FormsCon.FormConPai
    {
        FormCadEstado oFormCadEstado;
        Estados oEstado;
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\localKerp.mdf;Integrated Security=True;Connect Timeout=30";
        //"Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";
        string query = "SELECT Estado.IdEstado, Estado.IdPais, Estado.Estado, Estado.Sigla, Estado.PercIcms, Estado.IcmsInt, Estado.PerRedSt, Estado.CodigoWeb, Estado.IdEmpresa, Estado.DataCadastro, Estado.DataModificacao, Pais.Pais AS NomePais FROM Estado JOIN Pais ON Estado.IdPais = Pais.IdPais";
        public FormConEstados()
        {
            InitializeComponent();
            CarregaLV();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadEstado = (FormCadEstado)form;
        }

        public override void ConhecaObj(Object obj)
        {
            oEstado = (Estados)obj;
        }
        private async Task CarregaLV()
        {

            using (HttpClient httpClient = new HttpClient())
            {

                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync($"https://localhost:7231/Estado");

                    if (response.IsSuccessStatusCode)
                    {
                        EstadoServices buscaEstado = new EstadoServices();
                        List<Estados> EstadoProcurado = await buscaEstado.Dados();

                        try
                        {
                            listVConsulta.Items.Clear();

                            foreach (Estados estado in EstadoProcurado)
                            {
                                ListViewItem item = new ListViewItem(Convert.ToString(estado.Cod));

                                item.SubItems.Add(estado.Estado);
                                item.SubItems.Add(estado.NomePais);
                                item.SubItems.Add(estado.Sigla);
                                item.SubItems.Add(Convert.ToString(estado.PercIcms));
                                item.SubItems.Add(Convert.ToString(estado.Icms));
                                item.SubItems.Add(Convert.ToString(estado.PercRedST));
                                item.SubItems.Add(Convert.ToString(estado.CodWeb));
                                item.SubItems.Add(Convert.ToString(estado.CodEmpresa));
                                item.SubItems.Add(Convert.ToDateTime(estado.DataCadastro).ToString("dd/MM/yyyy"));
                                item.SubItems.Add(Convert.ToDateTime(estado.DataModificacao).ToString("dd/MM/yyyy"));

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
                    MessageBox.Show("Erro ao carregar os dados de Estados: " + ex.Message);
                }
            }
        }
        protected override void Incluir()
        {
            oFormCadEstado.ConhecaObj(oEstado);
            oFormCadEstado.LimpaTxt();
            oFormCadEstado.ShowDialog();
            CarregaLV();
        }

        protected override void Alterar()
        {
            if (listVConsulta.SelectedItems.Count > 0)
            {
                var selectedItem = listVConsulta.SelectedItems[0];
                string idPais = "";
                string nomePais = selectedItem.SubItems[2].Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT IdPais FROM Pais WHERE Pais = @nomePais", connection))
                    {
                        command.Parameters.AddWithValue("@nomePais", nomePais);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                idPais = reader["idPais"].ToString();
                            }
                        }
                    }
                }

                string campo1 = selectedItem.SubItems[0].Text;
                string campo2 = selectedItem.SubItems[1].Text;
                string campo3 = idPais;
                string campo4 = selectedItem.SubItems[2].Text;
                string campo5 = selectedItem.SubItems[3].Text;
                string campo6 = selectedItem.SubItems[4].Text;
                string campo7 = selectedItem.SubItems[5].Text;
                string campo8 = selectedItem.SubItems[6].Text;
                string campo9 = selectedItem.SubItems[7].Text;
                string campo10 = selectedItem.SubItems[8].Text;
                string campo11 = selectedItem.SubItems[9].Text;
                string campo12 = selectedItem.SubItems[10].Text;


                oFormCadEstado.ConhecaObj(oEstado);
                oFormCadEstado.LimpaTxt();
                oFormCadEstado.CarregaTxt(campo1, campo2, campo3, campo4, campo5, campo6, campo7, campo8, campo9, campo10, campo11, campo12);
                oFormCadEstado.ShowDialog();
            }
            CarregaLV();
        }

        protected override void Excluir()
        {
            if (listVConsulta.SelectedItems.Count > 0)
            {
                var selectedItem = listVConsulta.SelectedItems[0];

                int campo1 = Convert.ToInt32(selectedItem.SubItems[0].Text);

                oEstado.ExcluirBD(campo1);
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

                    string queryPesquisa = "SELECT Estado.IdEstado, Estado.IdPais, Estado.Estado, Estado.Sigla, Estado.PercIcms, Estado.IcmsInt, Estado.PerRedSt, Estado.CodigoWeb, Estado.IdEmpresa, Estado.DataCadastro, Estado.DataModificacao, Pais.Pais AS NomePais  " +
                                   "FROM Estado JOIN Pais ON Estado.IdPais = Pais.IdPais WHERE Estado LIKE @searchText OR IdEstado LIKE @searchText";

                    using (SqlCommand command = new SqlCommand(queryPesquisa, connection))
                    {
                        command.Parameters.AddWithValue("@searchText", "%" + txtPesquisa.Text + "%");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["IdEstado"].ToString());

                                item.SubItems.Add(reader["Estado"].ToString());
                                item.SubItems.Add(reader["NomePais"].ToString()); 
                                item.SubItems.Add(reader["Sigla"].ToString());
                                item.SubItems.Add(reader["PercIcms"].ToString());
                                item.SubItems.Add(reader["IcmsInt"].ToString());
                                item.SubItems.Add(reader["PerRedSt"].ToString());
                                item.SubItems.Add(reader["CodigoWeb"].ToString());
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
                    MessageBox.Show("Erro ao pesquisar os dados de Estados: " + ex.Message);
                }
            }
        }

        private void listV_DoubleClick(object sender, EventArgs e)
        {
            if (listVConsulta.SelectedItems.Count > 0)
            {
                var selectedItem = listVConsulta.SelectedItems[0];

                int idEstado = Convert.ToInt32(selectedItem.SubItems[0].Text);
                string nomeEstado = (selectedItem.SubItems[1].Text);

                var cadCidade = this.Owner as FormCadCidade;
                if (cadCidade != null)
                {
                    cadCidade.SetEstado(idEstado, nomeEstado);
                }

                this.Close();
            }
        }
    }
}
