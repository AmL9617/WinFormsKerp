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

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\localKerp.mdf;Integrated Security=True;Connect Timeout=30";
        //"Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";
        string query = "SELECT IdCondicaoPagamento, CondicaoPagamento, TaxaJuros, NumeroParcelas, Tipo, Dia, Operacao, Ativo, PorParcela, IdEmpresa, DataCadastro, DataModificacao FROM CondicaoPagamento";

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
                                item.SubItems.Add(Convert.ToDateTime(reader["DataModificacao"]).ToString("dd/MM/yyyy"));

                                listVConsulta.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os dados de CondicaoPagamento: " + ex.Message);
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

                oFormCadCondicaoPagamento.ConhecaObj(aCondicaoPagamento);
                oFormCadCondicaoPagamento.LimpaTxt();
                oFormCadCondicaoPagamento.CarregaTxt(campo1, campo2, campo3, campo4, campo5, campo6, campo7, campo8, campo9, campo10, campo11, campo12);
                oFormCadCondicaoPagamento.ShowDialog();
            }
            CarregaLV();
        }

        protected override void Excluir()
        {
            if (listVConsulta.SelectedItems.Count > 0)
            {
                var selectedItem = listVConsulta.SelectedItems[0];

                int campo1 = Convert.ToInt32(selectedItem.SubItems[0].Text);

                aCondicaoPagamento.ExcluirBD(campo1);
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
                    string queryPesquisa = "SELECT IdCondicaoPagamento, CondicaoPagamento, TaxaJuros, NumeroParcelas, Tipo, Dia, Operacao, Ativo, PorParcela, IdEmpresa, DataCadastro, DataModificacao " +
                                   "FROM CondicaoPagamento WHERE CondicaoPagamento LIKE @searchText OR IdCondicaoPagamento LIKE @searchText";

                    using (SqlCommand command = new SqlCommand(queryPesquisa, connection))
                    {
                        command.Parameters.AddWithValue("@searchText", "%" + txtPesquisa.Text + "%");

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
                                item.SubItems.Add(Convert.ToDateTime(reader["DataModificacao"]).ToString("dd/MM/yyyy"));

                                listVConsulta.Items.Add(item);
                            
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao pesquisar os dados de CondicaoPagamento: " + ex.Message);
                }
            }
        }
        private void listV_DoubleClick(object sender, EventArgs e)
        {
            if (listVConsulta.SelectedItems.Count > 0)
            {
                var selectedItem = listVConsulta.SelectedItems[0];

                int idCondPag = Convert.ToInt32(selectedItem.SubItems[0].Text);
                string nomeCondPag = (selectedItem.SubItems[1].Text);
                string tipo = "CondPag";

                var cadFornecedor = this.Owner as FormCadFornecedor;
                if (cadFornecedor != null)
                {
                    cadFornecedor.SetConsultas(idCondPag, nomeCondPag, tipo);
                }
                var cadCliente = this.Owner as FormCadCliente;
                if (cadCliente != null)
                {
                    cadCliente.SetConsultas(idCondPag, nomeCondPag, tipo);
                }

                this.Close();
            }
        }
    }
}
