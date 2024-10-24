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
    public partial class FormConListaPrecos : KnkForms.FormsCon.FormConPai
    {
        FormCadListaPreco oFormCadListaPreco;
        ListaPrecos aListaPreco;

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\Database1.mdf;Integrated Security=True";
        string query = "SELECT IdLista, Lista, DescMax, MargemLucro, PerComissao, IdEmpresa, DataModificacao FROM Listas";

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
                    MessageBox.Show("Error loading data in ListaPreço: " + ex.Message);
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

        protected override void Alterar()
        {
            oFormCadListaPreco.LimpaTxt();
            oFormCadListaPreco.CarregaTxt();
            oFormCadListaPreco.ShowDialog();
            CarregaLV();
        }

        protected override void Excluir()
        {
            oFormCadListaPreco.LimpaTxt();
            oFormCadListaPreco.ConhecaObj(aListaPreco);
            oFormCadListaPreco.CarregaTxt();
            oFormCadListaPreco.BloqueiaTxt();
            oFormCadListaPreco.ShowDialog();
            oFormCadListaPreco.DesbloqueiaTxt();
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
                                if (txtPesquisa.Text == Convert.ToString(reader["IdLista"]) ||
                                    txtPesquisa.Text == Convert.ToString(reader["Lista"]))
                                {
                                    ListViewItem item = new ListViewItem(reader["IdLista"].ToString());

                                    item.SubItems.Add(reader["Lista"].ToString());
                                    item.SubItems.Add(reader["DescMax"].ToString());
                                    item.SubItems.Add(reader["MargemLucro"].ToString());
                                    item.SubItems.Add(reader["PerComissao"].ToString());
                                    item.SubItems.Add(reader["IdEmpresa"].ToString());
                                    item.SubItems.Add(Convert.ToDateTime(reader["DataModificacao"]).ToString("dd/MM/yyyy"));

                                    listVConsulta.Items.Add(item);

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
                    MessageBox.Show("Error loading data in ListaPreços: " + ex.Message);
                }
            }
        }

    }
}
