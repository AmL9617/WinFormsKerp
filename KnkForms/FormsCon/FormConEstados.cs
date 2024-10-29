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
        string connectionString = "Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";
        string query = "SELECT IdEstado, IdPais, Estado, Sigla, PercIcms, IcmsInt, PerRedSt, CodigoWeb, IdEmpresa, DataCadastro, DataModificacao FROM Estado";
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

                string campo1 = selectedItem.SubItems[0].Text;
                string campo2 = selectedItem.SubItems[1].Text;
                string campo3 = selectedItem.SubItems[2].Text;
                string campo4 = selectedItem.SubItems[3].Text;
                string campo5 = selectedItem.SubItems[4].Text;
                string campo6 = selectedItem.SubItems[5].Text;
                string campo7 = selectedItem.SubItems[6].Text;
                string campo8 = selectedItem.SubItems[7].Text;
                string campo9 = selectedItem.SubItems[8].Text;
                string campo10 = selectedItem.SubItems[9].Text;
                string campo11 = selectedItem.SubItems[10].Text;


                oFormCadEstado.ConhecaObj(oEstado);
                oFormCadEstado.LimpaTxt();
                oFormCadEstado.CarregaTxt(campo1, campo2, campo3, campo4, campo5, campo6, campo7, campo8, campo9, campo10, campo11);
                oFormCadEstado.ShowDialog();
            }
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
                    MessageBox.Show("Erro ao carregar os dados de Estados: " + ex.Message);
                }
            }
        }
    }
}
