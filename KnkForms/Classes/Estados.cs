using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace KnkForms.Classes
{
    internal class Estados : Pai
    {
        protected string estado;
        protected string sigla;
        protected char ativo;
        protected double? percIcms;
        protected double? icms;
        protected double? percRedST; //Percentual de Redução da Substituição Tributária 
        protected int? codWeb;

        //Placeholder
        protected int codPais;

        //Agregação
        protected Paises oPais;

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\localKerp.mdf;Integrated Security=True;Connect Timeout=30";
        //"Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";

        public Estados():base()
        {
            estado = "";
            sigla = ""; 
            ativo = '\0';
            codPais = 0;
            percIcms = 0;
            icms = 0;
            percRedST = 0;
            codWeb = 0;
            oPais = new Paises();
        }

        public Estados(int cod, int codEmpresa, DateTime dataCadastro, DateTime dataModificacao, string estado, string sigla, char Ativo, int codPais, double percIcms, int icms, double percRedST, int codWeb, Paises oPais) : base(cod, codEmpresa, dataCadastro, dataModificacao)
        {
            estado = Estado;
            sigla = sigla;
            ativo = ativo;
            percIcms = percIcms;
            icms = icms;
            percRedST = percRedST;
            codWeb = codWeb;
            codPais = codPais;
            oPais = oPais;
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Sigla
        {
            get { return sigla; }
            set { sigla = value; }
        }

        public char Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        public int CodPais
        {
            get { return codPais; }
            set { codPais = value; }
        }
        public double? PercIcms
        {
            get { return percIcms; }
            set { percIcms = value; }
        }

        public double? Icms
        {
            get { return icms; }
            set { icms = value; }
        }
        public double? PercRedST
        {
            get { return percRedST; }
            set { percRedST = value; }
        }
        public int? CodWeb
        {
            get { return codWeb; }
            set { codWeb = value; }
        }
        public Paises Pais
        {
            get { return oPais; }
            set { oPais = value; }
        }
        public void SalvarBD()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Estado (IdEmpresa, IdPais, Estado, Sigla, PercIcms, IcmsInt, PerRedSt, CodigoWeb, DataCadastro, DataModificacao) VALUES (@IdEmpresa, @IdPais, @Estado, @Sigla, @PercIcms, @IcmsInt, @PerRedSt, @CodigoWeb, @DataCadastro, @DataModificacao)";

                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEmpresa", CodEmpresa);
                        command.Parameters.AddWithValue("@IdPais", CodPais);
                        command.Parameters.AddWithValue("@Estado", Estado);
                        command.Parameters.AddWithValue("@Sigla", Sigla);
                        command.Parameters.AddWithValue("@PercIcms", PercIcms.HasValue ? (object)PercIcms.Value : DBNull.Value);
                        command.Parameters.AddWithValue("@IcmsInt", Icms.HasValue ? (object)Icms.Value : DBNull.Value);
                        command.Parameters.AddWithValue("@PerRedSt", PercRedST.HasValue ? (object)PercRedST.Value : DBNull.Value);
                        command.Parameters.AddWithValue("@CodigoWeb", CodWeb.HasValue ? (object)CodWeb.Value : DBNull.Value);
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
        public void AlterarBD(int CodEstado)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Estado SET IdEmpresa=@IdEmpresa, IdPais=@IdPais, Estado=@Estado, Sigla=@Sigla, PercIcms=@PercIcms, IcmsInt=@IcmsInt, PerRedSt=@PerRedSt, CodigoWeb=@CodigoWeb, DataCadastro=@DataCadastro, DataModificacao=@DataModificacao WHERE IdEstado = @IdEstado";
                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEmpresa", CodEmpresa);
                        command.Parameters.AddWithValue("@IdPais", CodPais);
                        command.Parameters.AddWithValue("@Estado", Estado);
                        command.Parameters.AddWithValue("@Sigla", Sigla);
                        command.Parameters.AddWithValue("@PercIcms", PercIcms.HasValue ? (object)PercIcms.Value : DBNull.Value);
                        command.Parameters.AddWithValue("@IcmsInt", Icms.HasValue ? (object)Icms.Value : DBNull.Value);
                        command.Parameters.AddWithValue("@PerRedSt", PercRedST.HasValue ? (object)PercRedST.Value : DBNull.Value);
                        command.Parameters.AddWithValue("@CodigoWeb", CodWeb.HasValue ? (object)CodWeb.Value : DBNull.Value);
                        command.Parameters.AddWithValue("@DataCadastro", DataCadastro);
                        command.Parameters.AddWithValue("@DataModificacao", DataModificacao);
                        command.Parameters.AddWithValue("@IdEstado", CodEstado);

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
        public void ExcluirBD(int CodEstado)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Estado WHERE IdEstado = @IdEstado";
                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEstado", CodEstado);

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
