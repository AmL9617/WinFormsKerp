using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnkForms.Classes
{
    //ST é situação tributária
    internal class ListaCodST:Pai
    {
        protected string tipo;
        protected string descricao;
        protected char ativo;

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\localKerp.mdf;Integrated Security=True;Connect Timeout=30";
        //"Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";
        public ListaCodST()
        {
            tipo = "";
            descricao = "";
            ativo = '\0';
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Descricao 
        {
            get { return descricao; } 
            set { descricao = value; } 
        }
        public char Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        public void SalvarBD()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO ListaCst (IdEmpresa, Tipo, Descricao, Ativo) VALUES (@IdEmpresa, @Tipo, @Descricao, @Ativo)";

                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEmpresa", CodEmpresa);
                        command.Parameters.AddWithValue("@Tipo", Tipo);
                        command.Parameters.AddWithValue("@Descricao", Descricao);
                        command.Parameters.AddWithValue("@Ativo", Ativo);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Dados salvos com sucesso", "Sucesso", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }
        public void AlterarBD(int CodLista)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE ListaCst SET IdEmpresa=@IdEmpresa, Tipo=@Tipo, Descricao=@Descricao, Ativo=@Ativo WHERE IdListaCst = @IdListaCst";
                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEmpresa", CodEmpresa);
                        command.Parameters.AddWithValue("@Tipo", Tipo);
                        command.Parameters.AddWithValue("@Descricao", Descricao);
                        command.Parameters.AddWithValue("@Ativo", Ativo);
                        command.Parameters.AddWithValue("@IdListaCst", CodLista);

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
        public void ExcluirBD(int CodLista)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Lista WHERE IdLista = @IdLista";
                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdLista", CodLista);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Dados deletados com sucesso", "Sucesso", MessageBoxButtons.OK);
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
