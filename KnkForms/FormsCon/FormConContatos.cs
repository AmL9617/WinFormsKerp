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
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\Database1.mdf;Integrated Security=True";
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
                    MessageBox.Show("Error loading data in Estados: " + ex.Message);
                }
            }
        }
        protected override void Incluir()
        {
            oFormCadContato.ConhecaObj(oContato);
            oFormCadContato.LimpaTxt();
            oFormCadContato.ShowDialog();
        }

        protected override void Alterar()
        {
            oFormCadContato.LimpaTxt();
            oFormCadContato.CarregaTxt();
            oFormCadContato.ShowDialog();
        }

        protected override void Excluir()
        {
            oFormCadContato.LimpaTxt();
            oFormCadContato.ConhecaObj(oContato);
            oFormCadContato.CarregaTxt();
            oFormCadContato.BloqueiaTxt();
            oFormCadContato.ShowDialog();
            oFormCadContato.DesbloqueiaTxt();
        }
    }
}
