using KnkForms.Classes;
using KnkForms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KnkForms.FormsCon
{
    public partial class FormConCidades : KnkForms.FormsCon.FormConPai
    {
        FormCadCidade oFormCadCidade;
        Cidades aCidade;
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\Database1.mdf;Integrated Security=True";
        string query = "SELECT IdCidade, IdEstado, Cidade, Ddd, Ativo, IdEmpresa, DataCadastro, DataModificacao FROM Cidades";
        public FormConCidades()
        {
            InitializeComponent();
            CarregaLV();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadCidade = (FormCadCidade)form;
        }

        public override void ConhecaObj(Object obj)
        {
            aCidade = (Cidades)obj;
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
                                ListViewItem item = new ListViewItem(reader["IdCidade"].ToString());

                                item.SubItems.Add(reader["IdEstado"].ToString());
                                item.SubItems.Add(reader["Cidade"].ToString());
                                item.SubItems.Add(reader["Ddd"].ToString());
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
                    MessageBox.Show("Error loading data in Cidades: " + ex.Message);
                }
            }
        }
        protected override void Incluir()
        {
            oFormCadCidade.ConhecaObj(aCidade);
            oFormCadCidade.LimpaTxt();
            oFormCadCidade.ShowDialog();
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

                oFormCadCidade.ConhecaObj(aCidade);
                oFormCadCidade.LimpaTxt();
                oFormCadCidade.CarregaTxt(campo1, campo2, campo3, campo4, campo5, campo6, campo7, campo8);
                oFormCadCidade.ShowDialog();
            }
            CarregaLV();
        }

        protected override void Excluir()
        {
            oFormCadCidade.LimpaTxt();
            oFormCadCidade.ConhecaObj(aCidade);
            oFormCadCidade.CarregaTxt();
            oFormCadCidade.BloqueiaTxt();
            oFormCadCidade.ShowDialog();
            oFormCadCidade.DesbloqueiaTxt();
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

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (txtPesquisa.Text == Convert.ToString(reader["IdCidade"]) ||
                                    txtPesquisa.Text == Convert.ToString(reader["Cidade"]))
                                {
                                    ListViewItem item = new ListViewItem(reader["IdCidade"].ToString());

                                    item.SubItems.Add(reader["IdEstado"].ToString());
                                    item.SubItems.Add(reader["Cidade"].ToString());
                                    item.SubItems.Add(reader["Ddd"].ToString());
                                    item.SubItems.Add(reader["Ativo"].ToString());
                                    item.SubItems.Add(reader["IdEmpresa"].ToString());
                                    item.SubItems.Add(Convert.ToDateTime(reader["DataCadastro"]).ToString("dd/MM/yyyy"));
                                    item.SubItems.Add(Convert.ToDateTime(reader["DataModificacao"]).ToString("dd/MM/yyyy"));

                                    listVConsulta.Items.Add(item);
                                }
                                else if (String.IsNullOrEmpty(txtPesquisa.Text))
                                {
                                    CarregaLV();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }
    }
}
