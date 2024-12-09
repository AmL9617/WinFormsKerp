using KnkForms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KnkForms.Classes
{
    public partial class FormConRegioes : KnkForms.FormsCon.FormConPai
    {
        FormCadRegiao oFormCadRegiao;
        Regioes aRegiao;
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\localKerp.mdf;Integrated Security=True;Connect Timeout=30";
        //"Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";
        string query = "SELECT IdRegiao, Regiao, Descricao, Ativo, IdUsuario, IdEmpresa, DataCadastro, DataModificacao FROM Regiao";
        public FormConRegioes()
        {
            InitializeComponent();
            CarregaLV();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadRegiao = (FormCadRegiao)form;
        }

        public override void ConhecaObj(Object obj)
        {
            aRegiao = (Regioes)obj;
        }
        protected override void CarregaLV()
        {

            listVConsulta.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["IdRegiao"].ToString());

                                item.SubItems.Add(reader["Regiao"].ToString());
                                item.SubItems.Add(reader["Descricao"].ToString());
                                item.SubItems.Add(reader["Ativo"].ToString());
                                item.SubItems.Add(reader["IdUsuario"].ToString());
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
                    MessageBox.Show("Erro ao carregar os dados de Regioes: " + ex.Message);
                }
            }
        }
        protected override void Incluir()
        {
            oFormCadRegiao.ConhecaObj(aRegiao);
            oFormCadRegiao.LimpaTxt();
            oFormCadRegiao.ShowDialog();
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
                string campo6 = selectedItem.SubItems[5].Text;
                string campo7 = selectedItem.SubItems[6].Text;
                string campo8 = selectedItem.SubItems[7].Text;

                oFormCadRegiao.ConhecaObj(aRegiao);
                oFormCadRegiao.LimpaTxt();
                oFormCadRegiao.CarregaTxt(campo1, campo2, campo3, campo4, campo6, campo7, campo8);
                oFormCadRegiao.ShowDialog();
            }
            CarregaLV();
        }

        protected override void Excluir()
        {
            if (listVConsulta.SelectedItems.Count > 0)
            {
                var selectedItem = listVConsulta.SelectedItems[0];

                int campo1 = Convert.ToInt32(selectedItem.SubItems[0].Text);

                aRegiao.ExcluirBD(campo1);
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

                    string queryPesquisa = "SELECT IdRegiao, Regiao, Descricao, Ativo, IdUsuario, IdEmpresa, DataCadastro, DataModificacao " +
                                   "FROM Regiao WHERE Regiao LIKE @searchText OR IdRegiao LIKE @searchText";

                    using (SqlCommand command = new SqlCommand(queryPesquisa, connection))
                    {
                        command.Parameters.AddWithValue("@searchText", "%" + txtPesquisa.Text + "%");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["IdRegiao"].ToString());
                                item.SubItems.Add(reader["Regiao"].ToString());
                                item.SubItems.Add(reader["Descricao"].ToString());
                                item.SubItems.Add(reader["Ativo"].ToString());
                                item.SubItems.Add(reader["IdUsuario"].ToString());
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
                    MessageBox.Show("Erro ao pesquisar os dados de Regiões: " + ex.Message);
                }
            }
        }

        private void listV_DoubleClick(object sender, EventArgs e)
        {
            if (listVConsulta.SelectedItems.Count > 0)
            {
                var selectedItem = listVConsulta.SelectedItems[0];

                int idRegiao = Convert.ToInt32(selectedItem.SubItems[0].Text);
                string nomeRegiao = (selectedItem.SubItems[1].Text);
                string tipo = "Regiao";

                var cadFornecedor = this.Owner as FormCadFornecedor;
                if (cadFornecedor != null)
                {
                    cadFornecedor.SetConsultas(idRegiao, nomeRegiao, tipo);
                }
                var cadCliente = this.Owner as FormCadCliente;
                if (cadCliente != null)
                {
                    cadCliente.SetConsultas(idRegiao, nomeRegiao, tipo);
                }

                this.Close();
            }
        }
    }
}
