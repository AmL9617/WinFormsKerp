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
                                item.SubItems.Add(reader["IdCidadeEmp"].ToString());
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
            oFormCadFornecedor.LimpaTxt();
            oFormCadFornecedor.CarregaTxt();
            oFormCadFornecedor.ShowDialog();
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
                                    item.SubItems.Add(reader["IdCidadeEmp"].ToString());
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
