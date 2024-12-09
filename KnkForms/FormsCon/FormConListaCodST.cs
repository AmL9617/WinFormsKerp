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
    public partial class FormConListaCodST : KnkForms.FormsCon.FormConPai
    {   
        FormCadListaCodST oFormCadListaCodST;
        ListaCodST aListaCodST;
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\localKerp.mdf;Integrated Security=True;Connect Timeout=30";
		//"Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";
		string query = "SELECT IdListaCst, IdEmpresa, Tipo, Descricao, Ativo FROM ListaCst";
        public FormConListaCodST()
        {
            InitializeComponent();
            CarregaLV();
        }
        
        public override void SetFrmCadastro(Object form)
        {
            oFormCadListaCodST = (FormCadListaCodST)form;
        }

        public override void ConhecaObj(Object obj)
        {
            aListaCodST = (ListaCodST)obj;
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
                                ListViewItem item = new ListViewItem(reader["IdListaCst"].ToString());

                                item.SubItems.Add(reader["Tipo"].ToString());
                                item.SubItems.Add(reader["Descricao"].ToString());
                                item.SubItems.Add(reader["Ativo"].ToString());
                                item.SubItems.Add(reader["IdEmpresa"].ToString());

                                listVConsulta.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os dados de Lista CST: " + ex.Message);
                }
            }
        }
        protected override void Incluir()
        {
            oFormCadListaCodST.ConhecaObj(aListaCodST);
            oFormCadListaCodST.LimpaTxt();
            oFormCadListaCodST.ShowDialog();
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
                
                oFormCadListaCodST.ConhecaObj(aListaCodST);
                oFormCadListaCodST.LimpaTxt();
                oFormCadListaCodST.CarregaTxt(campo1, campo2, campo3, campo4, campo5);
                oFormCadListaCodST.ShowDialog();
            }
            CarregaLV();
        }
        protected override void Excluir()
        {
            oFormCadListaCodST.LimpaTxt();
            oFormCadListaCodST.ConhecaObj(aListaCodST);
            oFormCadListaCodST.CarregaTxt();
            oFormCadListaCodST.BloqueiaTxt();
            oFormCadListaCodST.ShowDialog();
            oFormCadListaCodST.DesbloqueiaTxt();
        }
        protected override void Pesquisar()
        {
            listVConsulta.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string queryPesquisa = "SELECT IdListaCst, Tipo, Descricao, Ativo, IdEmpresa " +
                                   "FROM ListaCst WHERE Tipo LIKE @searchText OR IdListaCst LIKE @searchText";

                    using (SqlCommand command = new SqlCommand(queryPesquisa, connection))
                    {
                        command.Parameters.AddWithValue("@searchText", "%" + txtPesquisa.Text + "%");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["IdListaCst"].ToString());

                                item.SubItems.Add(reader["Tipo"].ToString());
                                item.SubItems.Add(reader["Descricao"].ToString());
                                item.SubItems.Add(reader["Ativo"].ToString());
                                item.SubItems.Add(reader["IdEmpresa"].ToString());
                                
                                listVConsulta.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao pesquisar os dados de Lista CST: " + ex.Message);
                }
            }
        }

    }
}
