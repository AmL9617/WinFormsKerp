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
    public partial class FormConRegioes : KnkForms.FormsCon.FormConPai
    {
        FormCadRegiao oFormCadRegiao;
        Regioes aRegiao;
        string connectionString = "Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";
        string query = "SELECT IdRegiao, Regiao, Descricao, Ativo, IdUsuario, IdEmpresa, DataCadastro, DataModificacao FROM Regiao";
        public FormConRegioes()
        {
            InitializeComponent();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadRegiao = (FormCadRegiao)form;
        }

        public override void ConhecaObj(Object obj)
        {
            aRegiao = (Regioes)obj;
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
                                ListViewItem item = new ListViewItem(reader["IdRegiao"].ToString());

                                item.SubItems.Add(reader["Regiao"].ToString());
                                item.SubItems.Add(reader["Descricao"].ToString());
                                item.SubItems.Add(reader["Ativo"].ToString());
                                item.SubItems.Add(reader["IdUsuario"].ToString());
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
                    MessageBox.Show("Error loading data in Regioes: " + ex.Message);
                }
            }
        }
        protected override void Incluir()
        {
            oFormCadRegiao.ConhecaObj(aRegiao);
            oFormCadRegiao.LimpaTxt();
            oFormCadRegiao.ShowDialog();
        }

        protected override void Alterar()
        {
            oFormCadRegiao.LimpaTxt();
            oFormCadRegiao.CarregaTxt();
            oFormCadRegiao.ShowDialog();
        }

        protected override void Excluir()
        {
            oFormCadRegiao.LimpaTxt();
            oFormCadRegiao.ConhecaObj(aRegiao);
            oFormCadRegiao.CarregaTxt();
            oFormCadRegiao.BloqueiaTxt();
            oFormCadRegiao.ShowDialog();
            oFormCadRegiao.DesbloqueiaTxt();
        }
    }
}
