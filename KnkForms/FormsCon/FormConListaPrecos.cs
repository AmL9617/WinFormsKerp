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

        string connectionString = "Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";
        string query = "SELECT IdLista, Lista, DescMax, MargemLucro, PerComissao, Todas, IdEmpresa, DataCadastro, DataModificacao FROM Lista";

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
                                item.SubItems.Add(reader["Todas"].ToString());
                                item.SubItems.Add(reader["IdEmpresa"].ToString());
                                item.SubItems.Add(Convert.ToDateTime(reader["DataCadastro"]).ToString());
                                item.SubItems.Add(Convert.ToDateTime(reader["DataModificacao"]).ToString("dd/MM/yyyy"));

                                listVConsulta.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os dados de ListaPreço: " + ex.Message);
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

                oFormCadListaPreco.ConhecaObj(aListaPreco);
                oFormCadListaPreco.LimpaTxt();
                oFormCadListaPreco.CarregaTxt(campo1, campo2, campo3, campo4, campo5, campo6, campo7, campo8, campo9);
                oFormCadListaPreco.ShowDialog();
            }
            CarregaLV();
        }

        protected override void Excluir()
        {
            if (listVConsulta.SelectedItems.Count > 0)
            {
                var selectedItem = listVConsulta.SelectedItems[0];

                int campo1 = Convert.ToInt32(selectedItem.SubItems[0].Text);

                aListaPreco.ExcluirBD(campo1);
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
                    MessageBox.Show("Erro ao carregar os dados de ListaPreços: " + ex.Message);
                }
            }
        }

    }
}
