using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        protected char sigla;
        protected int ddi;
        protected bool ativo;
        protected char nacional;

        string connectionString = "Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";
        public Paises()
        {
            pais = "";
            tipoPais = "";
            sigla = '\0'; 
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

        public char Sigla
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
                    string query = "INSERT INTO Pais (IdEmpresa, IdPais, Pais, Sigla, Ddi, Nacional, DataCadastro, DataModificacao) VALUES (@IdEmpresa, @IdPais, @Pais, @Sigla, @Ddi, @Nacional, @DataCadastro, @DataModificacao)";

                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEmpresa", CodEmpresa);
                        command.Parameters.AddWithValue("@IdPais", Cod);
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
    }

}
