using KnkForms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KnkForms.Classes
{
    public partial class FormConEmpresas : KnkForms.FormsCon.FormConPai
    {
        FormCadEmpresa oFormCadEmpresa;
        Empresas aEmpresa;

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\Database1.mdf;Integrated Security=True";
        string query = "SELECT IdEmpresa, RazaoSocial, NomeFantasia, Cnpj, IdCidade, IdRegiao, Logradouro, Numero, Complemento, Bairro, Cep FROM Empresas";
        public FormConEmpresas()
        {
            InitializeComponent();
            CarregaLV();
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
                                ListViewItem item = new ListViewItem(reader["IdEmpresa"].ToString());

                                item.SubItems.Add(reader["RazaoSocial"].ToString());
                                item.SubItems.Add(reader["NomeFantasia"].ToString());
                                item.SubItems.Add(reader["Cnpj"].ToString());
                                item.SubItems.Add(reader["IdCidade"].ToString());
                                item.SubItems.Add(reader["IdRegiao"].ToString());
                                item.SubItems.Add(reader["Logradouro"].ToString());
                                item.SubItems.Add(reader["Numero"].ToString());
                                item.SubItems.Add(reader["Complemento"].ToString());
                                item.SubItems.Add(reader["Bairro"].ToString());
                                item.SubItems.Add(reader["Cep"].ToString());
                                
                                listVConsulta.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data in Empresas: " + ex.Message);
                }
            }
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadEmpresa = (FormCadEmpresa)form;
        }

        public override void ConhecaObj(Object obj)
        {
            aEmpresa = (Empresas)obj;
        }

        protected override void Incluir()
        {
            oFormCadEmpresa.ConhecaObj(aEmpresa);
            oFormCadEmpresa.LimpaTxt();
            oFormCadEmpresa.ShowDialog();
            CarregaLV();
        }

        protected override void Alterar()
        {
            oFormCadEmpresa.LimpaTxt();
            oFormCadEmpresa.CarregaTxt();
            oFormCadEmpresa.ShowDialog();
            CarregaLV();
        }

        protected override void Excluir()
        {
            oFormCadEmpresa.LimpaTxt();
            oFormCadEmpresa.ConhecaObj(aEmpresa);
            oFormCadEmpresa.CarregaTxt();
            oFormCadEmpresa.BloqueiaTxt();
            oFormCadEmpresa.ShowDialog();
            oFormCadEmpresa.DesbloqueiaTxt();
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
                                if (txtPesquisa.Text == Convert.ToString(reader["IdEmpresa"]) ||
                                    txtPesquisa.Text == Convert.ToString(reader["RazaoSocial"]))
                                {
                                    ListViewItem item = new ListViewItem(reader["IdEmpresa"].ToString());

                                    item.SubItems.Add(reader["RazaoSocial"].ToString());
                                    item.SubItems.Add(reader["NomeFantasia"].ToString());
                                    item.SubItems.Add(reader["Cnpj"].ToString());
                                    item.SubItems.Add(reader["IdCidade"].ToString());
                                    item.SubItems.Add(reader["IdRegiao"].ToString());
                                    item.SubItems.Add(reader["Logradouro"].ToString());
                                    item.SubItems.Add(reader["Numero"].ToString());
                                    item.SubItems.Add(reader["Complemento"].ToString());
                                    item.SubItems.Add(reader["Bairro"].ToString());
                                    item.SubItems.Add(reader["Cep"].ToString());

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
