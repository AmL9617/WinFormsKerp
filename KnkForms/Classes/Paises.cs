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
    internal class Paises : Pai
    {
        protected string pais;
        protected string tipoPais;
        protected string sigla;
        protected int ddi;
        protected char ativo;
        protected char nacional;

        string connectionString = "Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";
        public Paises()
        {
            pais = "";
            tipoPais = "";
            sigla = ""; 
            ddi = 0;
            ativo = '\0';
            nacional = '\0';
        }

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public string TipoPais
        {
            get { return tipoPais; }
            set { tipoPais = value; }
        }

        public string Sigla
        {
            get { return sigla; }
            set { sigla = value; }
        }

        public int DDI
        {
            get { return ddi; }
            set { ddi = value; }
        }

        public char Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }
        public char Nacional
        {
            get { return nacional; }
            set { nacional = value; }
        }

        public void SalvarBD()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Pais (IdEmpresa, Pais, Sigla, Ddi, Nacional, Ativo, DataCadastro, DataModificacao) VALUES (@IdEmpresa, @Pais, @Sigla, @Ddi, @Nacional, @Ativo, @DataCadastro, @DataModificacao)";

                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEmpresa", CodEmpresa);
                        command.Parameters.AddWithValue("@Pais", Pais);
                        command.Parameters.AddWithValue("@Sigla", Sigla);
                        command.Parameters.AddWithValue("@Ddi", DDI);
                        command.Parameters.AddWithValue("@Nacional", Nacional);
                        command.Parameters.AddWithValue("@Ativo", Ativo);
                        command.Parameters.AddWithValue("@DataCadastro", DataCadastro);
                        command.Parameters.AddWithValue("@DataModificacao", DataModificacao);

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
        public void AlterarBD(int CodPaises)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Pais SET IdEmpresa=@IdEmpresa, Pais=@Pais, Sigla=@Sigla, Ddi=@Ddi, Nacional=@Nacional, Ativo=@Ativo, DataCadastro=@DataCadastro, DataModificacao=@DataModificacao WHERE IdPais = @IdPais";
                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEmpresa", CodEmpresa);
                        command.Parameters.AddWithValue("@Pais", Pais);
                        command.Parameters.AddWithValue("@Sigla", Sigla);
                        command.Parameters.AddWithValue("@Ddi", DDI);
                        command.Parameters.AddWithValue("@Nacional", Nacional);
                        command.Parameters.AddWithValue("@Ativo", Ativo);
                        command.Parameters.AddWithValue("@DataCadastro", DataCadastro);
                        command.Parameters.AddWithValue("@DataModificacao", DataModificacao);
                        command.Parameters.AddWithValue("@IdPais", CodPaises);

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
        public void ExcluirBD(int CodPais)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Pais WHERE IdPais = @IdPais";
                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdPais", CodPais);

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
