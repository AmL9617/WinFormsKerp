using KnkForms.Classes;
using KnkForms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KnkForms.FormsCad;
using System.Collections;
using System.Data.SqlClient;

namespace KnkForms.FormsCon
{
    public partial class FormConContatos : KnkForms.FormsCon.FormConPai
    {
        FormCadContato oFormCadContato;
        Contatos oContato;
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\localKerp.mdf;Integrated Security=True;Connect Timeout=30";
        //"Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";
        string query = "SELECT IdContato, IdFornCliente, Tipo, Contato, Observacao, IdEmpresa FROM Contatos";

        public FormConContatos()
        {
            InitializeComponent();
            CarregaLV();
        }
        
        public override void SetFrmCadastro(Object form)
        {
            oFormCadContato = (FormCadContato)form;
        }

        public override void ConhecaObj(Object obj)
        {
            oContato = (Contatos)obj;
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
                                ListViewItem item = new ListViewItem(reader["IdContato"].ToString());

                                item.SubItems.Add(reader["IdFornCliente"].ToString());
                                item.SubItems.Add(reader["Tipo"].ToString());
                                item.SubItems.Add(reader["Contato"].ToString());
                                item.SubItems.Add(reader["Observacao"].ToString());
                                item.SubItems.Add(reader["IdEmpresa"].ToString());
                                //item.SubItems.Add(Convert.ToDateTime(reader["DataCadastro"]).ToString("dd/MM/yyyy"));
                                //item.SubItems.Add(Convert.ToDateTime(reader["DataModificacao"]).ToString("dd/MM/yyyy"));

                                listVConsulta.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os dados de Contatos: " + ex.Message);
                }
            }
        }
        protected override void Incluir()
        {
            oFormCadContato.ConhecaObj(oContato);
            oFormCadContato.LimpaTxt();
            oFormCadContato.ShowDialog();
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


                oFormCadContato.ConhecaObj(oContato);
                oFormCadContato.LimpaTxt();
                oFormCadContato.CarregaTxt(campo1, campo2, campo3, campo4, campo5, campo6, campo7, campo8);
                oFormCadContato.ShowDialog();
            }
            CarregaLV();
        }

        protected override void Excluir()
        {
            if (listVConsulta.SelectedItems.Count > 0)
            {
                var selectedItem = listVConsulta.SelectedItems[0];

                int campo1 = Convert.ToInt32(selectedItem.SubItems[0].Text);

                oContato.ExcluirBD(campo1);
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
                    string queryPesquisa = "SELECT IdContato, IdFornCliente, Tipo, Contato, Observacao, IdEmpresa " +
                                   "FROM Contato WHERE Contato LIKE @searchText OR IdContato LIKE @searchText";

                    using (SqlCommand command = new SqlCommand(queryPesquisa, connection))
                    {
                        command.Parameters.AddWithValue("@searchText", "%" + txtPesquisa.Text + "%");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["IdContato"].ToString());

                                item.SubItems.Add(reader["IdFornCliente"].ToString());
                                item.SubItems.Add(reader["Tipo"].ToString());
                                item.SubItems.Add(reader["Contato"].ToString());
                                item.SubItems.Add(reader["Observacao"].ToString());
                                item.SubItems.Add(reader["IdEmpresa"].ToString());
                                //item.SubItems.Add(Convert.ToDateTime(reader["DataCadastro"]).ToString("dd/MM/yyyy"));
                                //item.SubItems.Add(Convert.ToDateTime(reader["DataModificacao"]).ToString("dd/MM/yyyy"));

                                listVConsulta.Items.Add(item);
                                
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao pesquisar os dados de Contatos: " + ex.Message);
                }
            }
        }
    }
}
