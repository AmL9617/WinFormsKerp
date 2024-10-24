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
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\Database1.mdf;Integrated Security=True";
        string query = "SELECT IdRegiao, Regiao, Descricao, Ativo, IdUsuario, IdEmpresa, DataCadastro, DataModificacao FROM Regioes";
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
                    MessageBox.Show("Error loading data in Regioes: " + ex.Message);
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
            oFormCadRegiao.LimpaTxt();
            oFormCadRegiao.ConhecaObj(aRegiao);
            oFormCadRegiao.CarregaTxt();
            oFormCadRegiao.BloqueiaTxt();
            oFormCadRegiao.ShowDialog();
            oFormCadRegiao.DesbloqueiaTxt();
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
                                if (txtPesquisa.Text == Convert.ToString(reader["IdRegiao"]) ||
                                    txtPesquisa.Text == Convert.ToString(reader["Regiao"]))
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
