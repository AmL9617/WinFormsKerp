using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
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

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\Database1.mdf;Integrated Security=True";

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
        public void AlterarBD(int CodContato)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Contatos SET IdEmpresa=@IdEmpresa, IdFornCliente=@IdFornCliente, Tipo=@Tipo, Contato=@Contato, Observacao=@Observacao WHERE IdContato = @IdContato";
                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEmpresa", CodEmpresa);
                        command.Parameters.AddWithValue("@IdFornCliente", CodFornCliente);
                        command.Parameters.AddWithValue("@Tipo", Tipo);
                        command.Parameters.AddWithValue("@Contato", Contato);
                        command.Parameters.AddWithValue("@Observacao", Observacao);
                        command.Parameters.AddWithValue("@IdContato", CodContato);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Dados atualizados com sucesso", "Sucesso", MessageBoxButtons.OK);
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