using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnkForms.Classes
{
    internal class Regioes : Pai
    {
        protected string regiao;
        protected char ativo;
        protected string descricao;

        string connectionString = "Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";

        public Regioes()
        {
            regiao = "";
            ativo = '\0';
            descricao = "";
        }

        public string Regiao
        {
            get { return regiao; }
            set { regiao = value; }
        }

        public char Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public void SalvarBD()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Regiao (IdEmpresa, Regiao, Descricao, IdUsuario, Ativo, DataCadastro, DataModificacao) VALUES (@IdEmpresa, @Regiao, @Descricao, @IdUsuario, @Ativo, @DataCadastro, @DataModificacao)";

                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEmpresa", CodEmpresa);
                        command.Parameters.AddWithValue("@Regiao", Regiao);
                        command.Parameters.AddWithValue("@Descricao", Descricao);
                        command.Parameters.AddWithValue("@IdUsuario", CodEmpresa);
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
        public void AlterarBD(int CodRegiao)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Regiao SET IdEmpresa=@IdEmpresa, Regiao=@Regiao, Descricao=@Descricao, IdUsuario=@IdUsuario, Ativo=@Ativo, DataCadastro=@DataCadastro, DataModificacao=@DataModificacao WHERE IdRegiao = @IdRegiao";
                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEmpresa", CodEmpresa);
                        command.Parameters.AddWithValue("@Regiao", Regiao);
                        command.Parameters.AddWithValue("@Descricao", Descricao);
                        command.Parameters.AddWithValue("@IdUsuario", CodEmpresa);
                        command.Parameters.AddWithValue("@Ativo", Ativo);
                        command.Parameters.AddWithValue("@DataCadastro", DataCadastro);
                        command.Parameters.AddWithValue("@DataModificacao", DataModificacao);
                        command.Parameters.AddWithValue("@IdRegiao", CodRegiao);

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
