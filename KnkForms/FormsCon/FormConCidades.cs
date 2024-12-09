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
    public partial class FormConCidades : KnkForms.FormsCon.FormConPai
    {
        FormCadCidade oFormCadCidade;
        Cidades aCidade;
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\localKerp.mdf;Integrated Security=True;Connect Timeout=30";
		//"Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";

		//string query = "SELECT IdCidade, IdEstado, Cidade, Ddd, Ativo, IdEmpresa, DataCadastro, DataModificacao FROM Cidade";

		//TESTE
		string query = "SELECT Cidade.IdCidade, Cidade.Cidade, Cidade.IdEstado, Cidade.Ddd, Cidade.Ativo, Cidade.IdEmpresa, Cidade.DataCadastro, Cidade.DataModificacao, Estado.Estado AS NomeEstado FROM Cidade JOIN Estado ON Cidade.IdEstado = Estado.IdEstado";
        //TESTE

        public FormConCidades()
        {
            InitializeComponent();
            CarregaLV();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadCidade = (FormCadCidade)form;
        }

        public override void ConhecaObj(Object obj)
        {
            aCidade = (Cidades)obj;
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
                                ListViewItem item = new ListViewItem(reader["IdCidade"].ToString());

                                //item.SubItems.Add(reader["IdEstado"].ToString());
                                item.SubItems.Add(reader["Cidade"].ToString());
                                
                                //TESTE
                                item.SubItems.Add(reader["NomeEstado"].ToString());
                                //TESTE
                                
                                item.SubItems.Add(reader["Ddd"].ToString());
                                item.SubItems.Add(reader["Ativo"].ToString());
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
                    MessageBox.Show("Erro ao carregar os dados de Cidades: " + ex.Message);
                }
            }
        }
        protected override void Incluir()
        {
            oFormCadCidade.ConhecaObj(aCidade);
            oFormCadCidade.LimpaTxt();
            oFormCadCidade.ShowDialog();
            CarregaLV();
        }

        protected override void Alterar()
        {
            
            if (listVConsulta.SelectedItems.Count > 0)
            {
                var selectedItem = listVConsulta.SelectedItems[0];
                string idEstado = "";
                string nomeEstado = selectedItem.SubItems[2].Text;

                //TESTE
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT IdEstado FROM Estado WHERE Estado = @nomeEstado", connection))
                    {
                        command.Parameters.AddWithValue("@nomeEstado", nomeEstado);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                idEstado = reader["idEstado"].ToString();
                            }
                        }
                    }
                }
                //TESTE

                string campo1 = selectedItem.SubItems[0].Text;
                string campo2 = selectedItem.SubItems[2].Text;
                string campo3 = idEstado;
                string campo4 = selectedItem.SubItems[1].Text;
                string campo5 = selectedItem.SubItems[3].Text;
                string campo6 = selectedItem.SubItems[4].Text;
                string campo7 = selectedItem.SubItems[5].Text;
                string campo8 = selectedItem.SubItems[6].Text;
                string campo9 = selectedItem.SubItems[7].Text;

                

                oFormCadCidade.ConhecaObj(aCidade);
                oFormCadCidade.LimpaTxt();
                oFormCadCidade.CarregaTxt(campo1, campo2, campo3, campo4, campo5, campo6, campo7, campo8, campo9);
                oFormCadCidade.ShowDialog();
            }
            CarregaLV();
        }

        protected override void Excluir()
        {
            if (listVConsulta.SelectedItems.Count > 0)
            {
                var selectedItem = listVConsulta.SelectedItems[0];

                int campo1 = Convert.ToInt32(selectedItem.SubItems[0].Text);

                aCidade.ExcluirBD(campo1);
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

                    string queryPesquisa = "SELECT Cidade.IdCidade, Cidade.IdEstado, Cidade.Cidade, Cidade.Ddd, Cidade.Ativo, Cidade.IdEmpresa, Cidade.DataCadastro, Cidade.DataModificacao, Estado.Estado AS NomeEstado " +
                                   "FROM Cidade JOIN Estado ON Cidade.IdEstado = Estado.IdEstado WHERE Cidade LIKE @searchText OR IdCidade LIKE @searchText";

                    using (SqlCommand command = new SqlCommand(queryPesquisa, connection))
                    {
                        command.Parameters.AddWithValue("@searchText", "%" + txtPesquisa.Text + "%");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["IdCidade"].ToString());
                                
                                item.SubItems.Add(reader["Cidade"].ToString());
                                item.SubItems.Add(reader["NomeEstado"].ToString());
                                item.SubItems.Add(reader["Ddd"].ToString());
                                item.SubItems.Add(reader["Ativo"].ToString());
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
                    MessageBox.Show("Erro ao pesquisar os dados de Cidade: " + ex.Message);
                }
            }
        }
        private void listV_DoubleClick(object sender, EventArgs e)
        {
            if (listVConsulta.SelectedItems.Count > 0)
            {
                var selectedItem = listVConsulta.SelectedItems[0];

                int idCidade = Convert.ToInt32(selectedItem.SubItems[0].Text);
                string nomeCidade = (selectedItem.SubItems[1].Text);
                string tipo = "Cidade";

                var cadFornecedor = this.Owner as FormCadFornecedor;
                if (cadFornecedor != null)
                {
                    cadFornecedor.SetConsultas(idCidade, nomeCidade, tipo);
                }
                var cadCliente = this.Owner as FormCadCliente;
                if (cadCliente != null)
                {
                    cadCliente.SetConsultas(idCidade, nomeCidade, tipo);
                }

                this.Close();
            }
        }
    }
}
