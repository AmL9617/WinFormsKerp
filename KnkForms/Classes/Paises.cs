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
        protected bool ativo;
        protected char nacional;

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\Database1.mdf;Integrated Security=True";
        public Paises()
        {
            pais = "";
            tipoPais = "";
            sigla = ""; 
            ddi = 0;
            ativo = false;
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

        public bool Ativo
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
                    string query = "INSERT INTO Paises (IdEmpresa, Pais, Sigla, Ddi, Nacional, DataCadastro, DataModificacao) VALUES (@IdEmpresa, @Pais, @Sigla, @Ddi, @Nacional, @DataCadastro, @DataModificacao)";

                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEmpresa", CodEmpresa);
                        command.Parameters.AddWithValue("@Pais", Pais);
                        command.Parameters.AddWithValue("@Sigla", Sigla);
                        command.Parameters.AddWithValue("@Ddi", DDI);
                        command.Parameters.AddWithValue("@Nacional", Nacional);
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
                    string query = "UPDATE Paises SET IdEmpresa=@IdEmpresa, Pais=@Pais, Sigla=@Sigla, Ddi=@Ddi, Nacional=@Nacional, DataCadastro=@DataCadastro, DataModificacao=@DataModificacao WHERE IdPais = @IdPais";
                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEmpresa", CodEmpresa);
                        command.Parameters.AddWithValue("@Pais", Pais);
                        command.Parameters.AddWithValue("@Sigla", Sigla);
                        command.Parameters.AddWithValue("@Ddi", DDI);
                        command.Parameters.AddWithValue("@Nacional", Nacional);
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
    }

}
