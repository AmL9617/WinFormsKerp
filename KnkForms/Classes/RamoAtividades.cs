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
    internal class RamoAtividades : Pai
    {
        protected string ramo;
        protected char ativo;

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\localKerp.mdf;Integrated Security=True;Connect Timeout=30";
        //"Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";

        public RamoAtividades()
        {
            ramo = "";
            ativo = '\0';
        }

        public string Ramo
        {
            get { return ramo; }
            set { ramo = value; }
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
                    string query = "INSERT INTO RamoAtividades (IdEmpresa, NomeRamo, Ativo, DataCadastro, DataModificacao) VALUES (@IdEmpresa, @NomeRamo, @Ativo, @DataCadastro, @DataModificacao)";

                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEmpresa", CodEmpresa);
                        command.Parameters.AddWithValue("@NomeRamo", Ramo);
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
        public void AlterarBD(int CodRamo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE RamoAtividades SET IdEmpresa=@IdEmpresa, NomeRamo=@NomeRamo, Ativo=@Ativo, DataCadastro=@DataCadastro, DataModificacao=@DataModificacao WHERE IdRamo = @IdRamo";
                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEmpresa", CodEmpresa);
                        command.Parameters.AddWithValue("@NomeRamo", Ramo);
                        command.Parameters.AddWithValue("@Ativo", Ativo);
                        command.Parameters.AddWithValue("@DataCadastro", DataCadastro);
                        command.Parameters.AddWithValue("@DataModificacao", DataModificacao);
                        command.Parameters.AddWithValue("@IdRamo", CodRamo);

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
        public void ExcluirBD(int CodRegiao)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM RamoAtividades WHERE IdRamo = @IdRamo";
                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdRamo", CodRegiao);

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
