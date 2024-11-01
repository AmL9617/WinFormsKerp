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
    internal class ListaPrecos : Pai
    {
        protected string lista;
        protected double descontoMaximo;
        protected double margemLucro;
        protected double percCom;
        protected char todas;

        //Placeholder
        protected int codMarca;
        protected int codSubgrupo;

        //Agregação
        protected Marcas marcas;
        protected Subgrupos subgrupos;
        
        string connectionString = "Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";
        public ListaPrecos()
        {
            lista = "";
            descontoMaximo = 0.0f;
            margemLucro = 0.0f;
            percCom = 0.0f;
            todas = '\0';
            marcas = new Marcas();
            subgrupos = new Subgrupos();
            codMarca = 0;
            codSubgrupo = 0;
        }

        public string Lista
        {
            get { return lista; }
            set { lista = value; }
        }

        public double DescontoMaximo
        {
            get { return descontoMaximo; }
            set { descontoMaximo = value; }
        }

        public double MargemLucro
        {
            get { return margemLucro; }
            set { margemLucro = value; }
        }

        public double PercCom
        {
            get { return percCom; }
            set { percCom = value; }
        }

        public char Todas
        {
            get { return todas; }
            set { todas = value; }
        }

        public int CodMarca
        {
            get { return codMarca; }
            set { codMarca = value; }
        }

        public int CodSubgrupo
        {
            get { return codSubgrupo; }
            set { codSubgrupo = value; }
        }

        public Marcas Marcas
        {
            get { return marcas; }
            set { marcas = value; }
        }

        public Subgrupos Subgrupos
        {
            get { return subgrupos; }
            set { subgrupos = value; }
        }
        public void SalvarBD()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Lista (IdEmpresa, Lista, DescMax, MargemLucro, PerComissao, Todas, DataCadastro, DataModificacao) VALUES (@IdEmpresa, @Lista, @DescMax, @MargemLucro, @PerComissao, @Todas, @DataCadastro, @DataModificacao)";

                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEmpresa", CodEmpresa);
                        command.Parameters.AddWithValue("@Lista", Lista);
                        command.Parameters.AddWithValue("@DescMax", DescontoMaximo);
                        command.Parameters.AddWithValue("@MargemLucro", MargemLucro);
                        command.Parameters.AddWithValue("@PerComissao", PercCom);
                        command.Parameters.AddWithValue("@Todas", Todas);
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
        public void AlterarBD(int CodLista)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Lista SET IdEmpresa=@IdEmpresa, Lista=@Lista, DescMax=@DescMax, MargemLucro=@MargemLucro, PerComissao=@PerComissao, Todas=@Todas, DataCadastro=@DataCadastro, DataModificacao=@DataModificacao WHERE IdLista = @IdLista";
                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEmpresa", CodEmpresa);
                        command.Parameters.AddWithValue("@Lista", Lista);
                        command.Parameters.AddWithValue("@DescMax", DescontoMaximo);
                        command.Parameters.AddWithValue("@MargemLucro", MargemLucro);
                        command.Parameters.AddWithValue("@PerComissao", PercCom);
                        command.Parameters.AddWithValue("@Todas", Todas);
                        command.Parameters.AddWithValue("@DataCadastro", DataCadastro.ToString());
                        command.Parameters.AddWithValue("@DataModificacao", DataModificacao);
                        command.Parameters.AddWithValue("@IdLista", CodLista);

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
