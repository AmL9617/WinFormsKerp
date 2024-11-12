using KnkForms.Classes;
using KnkForms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KnkForms.FormsCon
{
    public partial class FormConPaises : KnkForms.FormsCon.FormConPai
    {
        FormCadPais oFormCadPais;
        Paises oPais;
        
        string connectionString = "Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";
        string query = "SELECT IdPais, Pais, Sigla, DDI, Nacional, Ativo, IdEmpresa, DataCadastro, DataModificacao FROM Pais";
            
        public FormConPaises()
        {
            InitializeComponent();
            CarregaLV();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadPais = (FormCadPais)form;
        }

        public override void ConhecaObj(Object obj)
        {
            oPais = (Paises)obj;
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
                                ListViewItem item = new ListViewItem(reader["IdPais"].ToString());

                                item.SubItems.Add(reader["Pais"].ToString());
                                item.SubItems.Add(reader["Sigla"].ToString());
                                item.SubItems.Add(reader["DDI"].ToString());
                                item.SubItems.Add(Convert.ToChar(reader["Nacional"]) == 's' ? "Sim" : "Não");
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
                    MessageBox.Show("Erro ao carregar os dados de País: " + ex.Message);
                }
            }
        }

        protected override void Incluir()
        {
            oFormCadPais.ConhecaObj(oPais);
            oFormCadPais.LimpaTxt();
            oFormCadPais.ShowDialog();
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

                oFormCadPais.ConhecaObj(oPais);
                oFormCadPais.LimpaTxt();
                oFormCadPais.CarregaTxt(campo1, campo2, campo3, campo4, campo5, campo6, campo7, campo8, campo9);
                oFormCadPais.ShowDialog();
            }
            CarregaLV();
        }

        protected override void Excluir()
        {
            if (listVConsulta.SelectedItems.Count > 0)
            {
                var selectedItem = listVConsulta.SelectedItems[0];

                int campo1 = Convert.ToInt32(selectedItem.SubItems[0].Text);

                oPais.ExcluirBD(campo1);
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

                    string queryPesquisa = "SELECT IdPais, Pais, Sigla, DDI, Nacional, Ativo, IdEmpresa, DataCadastro, DataModificacao " +
                                   "FROM Pais WHERE Pais LIKE @searchText OR IdPais LIKE @searchText";

                    using (SqlCommand command = new SqlCommand(queryPesquisa, connection))
                    {
                        command.Parameters.AddWithValue("@searchText", "%" + txtPesquisa.Text + "%");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["IdPais"].ToString());

                                item.SubItems.Add(reader["Pais"].ToString());
                                item.SubItems.Add(reader["Sigla"].ToString());
                                item.SubItems.Add(reader["DDI"].ToString());
                                item.SubItems.Add(Convert.ToChar(reader["Nacional"]) == 's' ? "Sim" : "Não");
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
                    MessageBox.Show("Erro ao pesquisar os dados de País: " + ex.Message);
                }
            }
        }
        private void listV_DoubleClick(object sender, EventArgs e)
        {
            if (listVConsulta.SelectedItems.Count > 0)
            {
                var selectedItem = listVConsulta.SelectedItems[0];

                int idPais = Convert.ToInt32(selectedItem.SubItems[0].Text);
                string nomePais = (selectedItem.SubItems[1].Text);

                var cadEstado = this.Owner as FormCadEstado;
                if (cadEstado != null)
                {
                    cadEstado.SetPais(idPais, nomePais);
                }

                this.Close();
            }
        }
    }
}
