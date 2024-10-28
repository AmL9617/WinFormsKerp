using KnkForms.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KnkForms.Classes
{
    public partial class FormConFornecedores : KnkForms.FormsCon.FormConPai
    {
        FormCadFornecedor oFormCadFornecedor;
        Fornecedores oFornecedor;
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\Database1.mdf;Integrated Security=True";
        string query = "SELECT IdFornCliente, RazaoSocial, NomeFantasia, InscricaoEstadual, CpfCnpj, Tipo, IdCidade, IdRegiao, Logradouro, Numero, Complemento, Bairro, Cep, ConsumidorRevenda, Observacao, Ativo, FisicaJuridica, IdCidadeEmp, IdEmpresa, DataCadastro, DataModificacao FROM FornClientes";
        public FormConFornecedores()
        {
            InitializeComponent();
            CarregaLV();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadFornecedor = (FormCadFornecedor)form;
        }

        public override void ConhecaObj(Object obj)
        {
            oFornecedor = (Fornecedores)obj;
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
                                ListViewItem item = new ListViewItem(reader["IdFornCliente"].ToString());

                                item.SubItems.Add(reader["RazaoSocial"].ToString());
                                item.SubItems.Add(reader["NomeFantasia"].ToString());
                                item.SubItems.Add(reader["InscricaoEstadual"].ToString());
                                item.SubItems.Add(reader["CpfCnpj"].ToString());
                                item.SubItems.Add(reader["Tipo"].ToString());
                                item.SubItems.Add(reader["IdCidade"].ToString());
                                item.SubItems.Add(reader["IdRegiao"].ToString());
                                item.SubItems.Add(reader["Logradouro"].ToString());
                                item.SubItems.Add(reader["Numero"].ToString());
                                item.SubItems.Add(reader["Complemento"].ToString());
                                item.SubItems.Add(reader["Bairro"].ToString());
                                item.SubItems.Add(reader["Cep"].ToString());
                                item.SubItems.Add(reader["ConsumidorRevenda"].ToString());
                                item.SubItems.Add(reader["Observacao"].ToString());
                                item.SubItems.Add(reader["Ativo"].ToString());
                                item.SubItems.Add(reader["FisicaJuridica"].ToString());
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
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        protected override void Incluir()
        {
            oFormCadFornecedor.ConhecaObj(oFornecedor);
            oFormCadFornecedor.LimpaTxt();
            oFormCadFornecedor.ShowDialog();
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
                string campo12 = selectedItem.SubItems[11].Text;
                string campo13 = selectedItem.SubItems[12].Text;
                string campo14 = selectedItem.SubItems[13].Text;
                string campo15 = selectedItem.SubItems[14].Text;
                string campo16 = selectedItem.SubItems[15].Text;
                string campo17 = selectedItem.SubItems[16].Text;
                string campo18 = selectedItem.SubItems[17].Text;
                string campo19 = selectedItem.SubItems[18].Text;
                string campo20 = selectedItem.SubItems[19].Text;

                oFormCadFornecedor.ConhecaObj(oFornecedor);
                oFormCadFornecedor.LimpaTxt();
                oFormCadFornecedor.CarregaTxt(campo1, campo2, campo3, campo4, campo5, campo6, campo7, campo8, campo9, campo10, campo11, campo12, campo13, campo14, campo15, campo16, campo17, campo18, campo19, campo20);
                oFormCadFornecedor.ShowDialog();
            }
            CarregaLV();
        }

        protected override void Excluir()
        {
            oFormCadFornecedor.LimpaTxt();
            oFormCadFornecedor.ConhecaObj(oFornecedor);
            oFormCadFornecedor.CarregaTxt();
            oFormCadFornecedor.BloqueiaTxt();
            oFormCadFornecedor.ShowDialog();
            oFormCadFornecedor.DesbloqueiaTxt();
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
                                if (txtPesquisa.Text == Convert.ToString(reader["IdFornCliente"]) ||
                                    txtPesquisa.Text == Convert.ToString(reader["NomeFantasia"]))
                                {
                                    ListViewItem item = new ListViewItem(reader["IdFornCliente"].ToString());

                                    item.SubItems.Add(reader["RazaoSocial"].ToString());
                                    item.SubItems.Add(reader["NomeFantasia"].ToString());
                                    item.SubItems.Add(reader["InscricaoEstadual"].ToString());
                                    item.SubItems.Add(reader["CpfCnpj"].ToString());
                                    item.SubItems.Add(reader["Tipo"].ToString());
                                    item.SubItems.Add(reader["IdCidade"].ToString());
                                    item.SubItems.Add(reader["IdRegiao"].ToString());
                                    item.SubItems.Add(reader["Logradouro"].ToString());
                                    item.SubItems.Add(reader["Numero"].ToString());
                                    item.SubItems.Add(reader["Complemento"].ToString());
                                    item.SubItems.Add(reader["Bairro"].ToString());
                                    item.SubItems.Add(reader["Cep"].ToString());
                                    item.SubItems.Add(reader["ConsumidorRevenda"].ToString());
                                    item.SubItems.Add(reader["Observacao"].ToString());
                                    item.SubItems.Add(reader["Ativo"].ToString());
                                    item.SubItems.Add(reader["FisicaJuridica"].ToString());
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
