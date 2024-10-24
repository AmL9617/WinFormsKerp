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
    public partial class FormConCondicaoPagamentos : KnkForms.FormsCon.FormConPai
    {
        FormCadCondicaoPagamento oFormCadCondicaoPagamento;
        CondicaoPagamentos aCondicaoPagamento;

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\Database1.mdf;Integrated Security=True";
        string query = "SELECT IdCondicaoPagamento, CondicaoPagamento, TaxaJuros, NumeroParcelas, Tipo, Dia, Operacao, Ativo, PorParcela, IdEmpresa, DataCadastro, DataAlteracao FROM CondPagamentos";

        public FormConCondicaoPagamentos()
        {
            InitializeComponent();
            CarregaLV();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadCondicaoPagamento = (FormCadCondicaoPagamento)form;
        }

        public override void ConhecaObj(Object obj)
        {
            aCondicaoPagamento = (CondicaoPagamentos)obj;
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
                                ListViewItem item = new ListViewItem(reader["IdCondicaoPagamento"].ToString());

                                item.SubItems.Add(reader["CondicaoPagamento"].ToString());
                                item.SubItems.Add(reader["TaxaJuros"].ToString());
                                item.SubItems.Add(reader["NumeroParcelas"].ToString());
                                item.SubItems.Add(reader["Tipo"].ToString());
                                item.SubItems.Add(reader["Dia"].ToString());
                                item.SubItems.Add(reader["Operacao"].ToString());
                                item.SubItems.Add(reader["Ativo"].ToString());
                                item.SubItems.Add(reader["PorParcela"].ToString());
                                item.SubItems.Add(reader["IdEmpresa"].ToString());
                                item.SubItems.Add(Convert.ToDateTime(reader["DataCadastro"]).ToString("dd/MM/yyyy"));
                                item.SubItems.Add(Convert.ToDateTime(reader["DataAlteracao"]).ToString("dd/MM/yyyy"));

                                listVConsulta.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data in CondPag: " + ex.Message);
                }
            }
        }

        protected override void Incluir()
        {
            oFormCadCondicaoPagamento.ConhecaObj(aCondicaoPagamento);
            oFormCadCondicaoPagamento.LimpaTxt();
            oFormCadCondicaoPagamento.ShowDialog();
            CarregaLV();
        }

        protected override void Alterar()
        {
            oFormCadCondicaoPagamento.LimpaTxt();
            oFormCadCondicaoPagamento.CarregaTxt();
            oFormCadCondicaoPagamento.ShowDialog();
            CarregaLV();
        }

        protected override void Excluir()
        {
            oFormCadCondicaoPagamento.LimpaTxt();
            oFormCadCondicaoPagamento.ConhecaObj(aCondicaoPagamento);
            oFormCadCondicaoPagamento.CarregaTxt();
            oFormCadCondicaoPagamento.BloqueiaTxt();
            oFormCadCondicaoPagamento.ShowDialog();
            oFormCadCondicaoPagamento.DesbloqueiaTxt();
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
                                if (txtPesquisa.Text == Convert.ToString(reader["IdCondicaoPagamento"]) ||
                                    txtPesquisa.Text == Convert.ToString(reader["CondicaoPagamento"]))
                                {
                                    ListViewItem item = new ListViewItem(reader["IdCondicaoPagamento"].ToString());

                                    item.SubItems.Add(reader["CondicaoPagamento"].ToString());
                                    item.SubItems.Add(reader["TaxaJuros"].ToString());
                                    item.SubItems.Add(reader["NumeroParcelas"].ToString());
                                    item.SubItems.Add(reader["Tipo"].ToString());
                                    item.SubItems.Add(reader["Dia"].ToString());
                                    item.SubItems.Add(reader["Operacao"].ToString());
                                    item.SubItems.Add(reader["Ativo"].ToString());
                                    item.SubItems.Add(reader["PorParcela"].ToString());
                                    item.SubItems.Add(reader["IdEmpresa"].ToString());
                                    item.SubItems.Add(Convert.ToDateTime(reader["DataCadastro"]).ToString("dd/MM/yyyy"));
                                    item.SubItems.Add(Convert.ToDateTime(reader["DataAlteracao"]).ToString("dd/MM/yyyy"));

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
