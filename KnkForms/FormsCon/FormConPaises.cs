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
            string connectionString = "Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";

            string query = "SELECT IdPais, Pais, Sigla, DDI, Nacional, IdEmpresa, DataCadastro, DataModificacao FROM Pais";

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
            oFormCadPais.ConhecaObj(oPais);
            oFormCadPais.LimpaTxt();
            oFormCadPais.ShowDialog();
        }

        protected override void Alterar()
        {
            oFormCadPais.LimpaTxt();
            oFormCadPais.CarregaTxt();
            oFormCadPais.ShowDialog();
        }

        protected override void Excluir()
        {
            oFormCadPais.LimpaTxt();
            oFormCadPais.ConhecaObj(oPais);
            oFormCadPais.CarregaTxt();
            oFormCadPais.BloqueiaTxt();
            oFormCadPais.ShowDialog();
            oFormCadPais.DesbloqueiaTxt();
        }

    }
}
