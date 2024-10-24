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
    public partial class FormConEstados : KnkForms.FormsCon.FormConPai
    {
        FormCadEstado oFormCadEstado;
        Estados oEstado;
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\Database1.mdf;Integrated Security=True";
        string query = "SELECT IdEstado, IdPais, Estado, Sigla, PercIcms, IcmsInt, PerRedSt, CodigoWeb, IdEmpresa, DataCadastro, DataModificacao FROM Estados";
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
                                ListViewItem item = new ListViewItem(reader["IdEstado"].ToString());

                                item.SubItems.Add(reader["IdPais"].ToString());
                                item.SubItems.Add(reader["Estado"].ToString());
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
                    MessageBox.Show("Error loading data in Estados: " + ex.Message);
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
            oFormCadEstado.LimpaTxt();
            oFormCadEstado.CarregaTxt();
            oFormCadEstado.ShowDialog();
            CarregaLV();
        }

        protected override void Excluir()
        {
            oFormCadEstado.LimpaTxt();
            oFormCadEstado.ConhecaObj(oEstado);
            oFormCadEstado.CarregaTxt();
            oFormCadEstado.BloqueiaTxt();
            oFormCadEstado.ShowDialog();
            oFormCadEstado.DesbloqueiaTxt();
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
                                if (txtPesquisa.Text == Convert.ToString(reader["IdEstado"]) ||
                                    txtPesquisa.Text == Convert.ToString(reader["Estado"]))
                                {
                                    ListViewItem item = new ListViewItem(reader["IdEstado"].ToString());

                                    item.SubItems.Add(reader["IdPais"].ToString());
                                    item.SubItems.Add(reader["Estado"].ToString());
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
