using KnkForms.Classes;
using KnkForms.Forms;
using KnkForms.FormsCad;
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
    public partial class FormConRamoAtivClientes : FormConPai
    {
        FormCadRamoAtivCliente oFormCadRamoAtivCliente;
        RamoAtividadesClientes oRamoAtivClientes;
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\localKerp.mdf;Integrated Security=True;Connect Timeout=30";
        //"Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";
        string query = "SELECT RamoAtividadeClientes.IdRamo, RamoAtividadeClientes.IdFornCliente, RamoAtividadeClientes.Prioridade, RamoAtividadeClientes.IdEmpresa, RamoAtividades.NomeRamo, FornCliente.NomeFantasia FROM RamoAtividadeClientes JOIN RamoAtividades ON RamoAtividadeClientes.IdRamo = RamoAtividades.IdRamo JOIN FornCliente ON RamoAtividadeClientes.IdFornCliente = FornCliente.IdFornCliente";
        public FormConRamoAtivClientes()
        {
            InitializeComponent();
            CarregaLV();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadRamoAtivCliente = (FormCadRamoAtivCliente)form;
        }

        public override void ConhecaObj(Object obj)
        {
            oRamoAtivClientes = (RamoAtividadesClientes)obj;
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
                                ListViewItem item = new ListViewItem(reader["IdRamo"].ToString());

                                item.SubItems.Add(reader["NomeRamo"].ToString());
                                item.SubItems.Add(reader["NomeFantasia"].ToString());
                                item.SubItems.Add(reader["Prioridade"].ToString());
                                item.SubItems.Add(reader["IdEmpresa"].ToString());
                                
                                listVConsulta.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os dados de Ramo de Atividades de Clientes: " + ex.Message);
                }
            }
        }

        protected override void Incluir()
        {
            oFormCadRamoAtivCliente.ConhecaObj(oRamoAtivClientes);
            oFormCadRamoAtivCliente.LimpaTxt();
            oFormCadRamoAtivCliente.ShowDialog();
            CarregaLV();
        }

        protected override void Alterar()
        {
            if (listVConsulta.SelectedItems.Count > 0)
            {
                var selectedItem = listVConsulta.SelectedItems[0];

                string idFornCliente = "";
                string nomeFornCliente = selectedItem.SubItems[2].Text;

                //TESTE
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT IdFornCliente FROM FornCliente WHERE NomeFantasia = @nomeFornCliente", connection))
                    {
                        command.Parameters.AddWithValue("@nomeFornCliente", nomeFornCliente);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                idFornCliente = reader["idFornCliente"].ToString();
                            }
                        }
                    }
                }

                string campo1 = selectedItem.SubItems[0].Text;
                string campo2 = selectedItem.SubItems[1].Text;
                string campo3 = selectedItem.SubItems[2].Text;
                string campo4 = idFornCliente;
                string campo5 = selectedItem.SubItems[3].Text;
                string campo6 = selectedItem.SubItems[4].Text;

                oFormCadRamoAtivCliente.ConhecaObj(oRamoAtivClientes);
                oFormCadRamoAtivCliente.LimpaTxt();
                oFormCadRamoAtivCliente.CarregaTxt(campo1, campo2, campo3, campo4, campo5, campo6);
                oFormCadRamoAtivCliente.ShowDialog();
            }
            CarregaLV();
        }

        protected override void Excluir()
        {
            if (listVConsulta.SelectedItems.Count > 0)
            {
                var selectedItem = listVConsulta.SelectedItems[0];

                int campo1 = Convert.ToInt32(selectedItem.SubItems[0].Text);

                oRamoAtivClientes.ExcluirBD(campo1);
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

                    string queryPesquisa = "SELECT IdRamo, IdFornCliente, Prioridade, IdEmpresa " +
                                   "FROM RamoAtividadeClientes WHERE Prioridade LIKE @searchText OR IdRamo LIKE @searchText";

                    using (SqlCommand command = new SqlCommand(queryPesquisa, connection))
                    {
                        command.Parameters.AddWithValue("@searchText", "%" + txtPesquisa.Text + "%");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["IdRamo"].ToString());
                                item.SubItems.Add(reader["IdFornCliente"].ToString());
                                item.SubItems.Add(reader["Prioridade"].ToString());
                                item.SubItems.Add(reader["IdEmpresa"].ToString());
                                
                                listVConsulta.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao pesquisar os dados de Ramo de Atividades de Clientes: " + ex.Message);
                }
            }
        }
        private void listV_DoubleClick(object sender, EventArgs e)
        {
            if (listVConsulta.SelectedItems.Count > 0)
            {
                var selectedItem = listVConsulta.SelectedItems[0];

                int idRamoAtiv = Convert.ToInt32(selectedItem.SubItems[0].Text);
                string nomeRamoAtiv = (selectedItem.SubItems[1].Text);
                string tipo = "RamoAtivCliente";

                var cadCliente = this.Owner as FormCadCliente;
                if (cadCliente != null)
                {
                    cadCliente.SetConsultas(idRamoAtiv, nomeRamoAtiv, tipo);
                }

                this.Close();
            }
        }
    }
}
