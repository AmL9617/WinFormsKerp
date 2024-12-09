using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnkForms.Classes
{
    internal class Cidades : Pai
    {
        protected string cidade;
        protected int ddd;
        protected char ativo;

        //Placeholder
        protected int codEstado;
        //Agregação
        protected Estados estado;

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\localKerp.mdf;Integrated Security=True;Connect Timeout=30";
		//"Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";

		public Cidades()
        {
            cidade = "";
            ddd = 0;
            ativo = '\0';
            estado = new Estados();
            codEstado = 0; 
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public int DDD
        {
            get { return ddd; }
            set { ddd = value; }
        }

        public char Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        public int CodEstado
        {
            get { return codEstado; }
            set { codEstado = value; }
        }

        public Estados Estado
        { 
            get { return estado; } 
            set { estado = value; } 
        }
        public void SalvarBD()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Cidade (IdEmpresa, IdEstado, Cidade, Ddd, Ativo, DataCadastro, DataModificacao) VALUES (@IdEmpresa, @IdEstado, @Cidade, @Ddd, @Ativo, @DataCadastro, @DataModificacao)";

                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEmpresa", CodEmpresa);
                        command.Parameters.AddWithValue("@IdEstado", CodEstado);
                        command.Parameters.AddWithValue("@Cidade", Cidade);
                        command.Parameters.AddWithValue("@Ddd", DDD);
                        command.Parameters.AddWithValue("@Ativo", Ativo);
                        command.Parameters.AddWithValue("@DataCadastro", DataCadastro);
                        command.Parameters.AddWithValue("@DataModificacao", DataModificacao);

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
        public void AlterarBD(int CodCidade)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Cidade SET IdEmpresa=@IdEmpresa, IdEstado=@IdEstado, Cidade=@Cidade, Ddd=@Ddd, Ativo=@Ativo, DataCadastro=@DataCadastro, DataModificacao=@DataModificacao WHERE IdCidade = @IdCidade";
                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEmpresa", CodEmpresa);
                        command.Parameters.AddWithValue("@IdEstado", CodEstado);
                        command.Parameters.AddWithValue("@Cidade", Cidade);
                        command.Parameters.AddWithValue("@Ddd", DDD);
                        command.Parameters.AddWithValue("@Ativo", Ativo);
                        command.Parameters.AddWithValue("@DataCadastro", DataCadastro);
                        command.Parameters.AddWithValue("@DataModificacao", DataModificacao);
                        command.Parameters.AddWithValue("@IdCidade", CodCidade);

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
        public void ExcluirBD(int CodCidade)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Cidade WHERE IdCidade = @IdCidade";
                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdCidade", CodCidade);

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
