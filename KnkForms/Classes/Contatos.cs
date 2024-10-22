using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnkForms.Classes
{
    internal class Contatos : Pai
    {
        protected int codFornCliente;
        protected string tipo;
        protected string contato;
        protected string observacao;

        protected Clientes clientes;

        string connectionString = "Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";

        public Contatos()
        {
            codFornCliente = 0;
            tipo = "";
            contato = "";
            observacao = "";
            clientes = new Clientes();
        }
        public int CodFornCliente
        {
            get { return codFornCliente; }
            set { codFornCliente = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Contato
        { 
            get { return contato; } 
            set { contato = value; } 
        }
        public string Observacao
        {
            get{ return observacao; }
            set { observacao = value; }
        }
        public Clientes Clientes
        {
            get { return clientes; }
            set { clientes = value; }
        }
        public void SalvarBD()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Contatos (IdEmpresa, IdFornCliente, Tipo, Contato, Observacao) VALUES (@IdEmpresa, @IdFornCliente, @Tipo, @Contato, @Observacao)";

                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEmpresa", CodEmpresa);
                        command.Parameters.AddWithValue("@IdFornCliente", CodFornCliente);
                        command.Parameters.AddWithValue("@Tipo", Tipo);
                        command.Parameters.AddWithValue("@Contato", Contato);
                        command.Parameters.AddWithValue("@Observacao", Observacao);
                        
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }
    }
}