using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        protected bool ativo;

        //Placeholder
        protected int codEstado;
        //Agregação
        protected Estados estado;

        string connectionString = "Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";

        public Cidades()
        {
            cidade = "";
            ddd = 0;
            ativo = false;
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

        public bool Ativo
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
