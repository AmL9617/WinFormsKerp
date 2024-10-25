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
        protected bool todas;

        //Placeholder
        protected int codMarca;
        protected int codSubgrupo;

        //Agregação
        protected Marcas marcas;
        protected Subgrupos subgrupos;
        
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\Database1.mdf;Integrated Security=True";
        public ListaPrecos()
        {
            lista = "";
            descontoMaximo = 0.0f;
            margemLucro = 0.0f;
            percCom = 0.0f;
            todas = false;
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

        public bool Todas
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
                    string query = "INSERT INTO Listas (IdEmpresa, Lista, DescMax, MargemLucro, PerComissao, DataModificacao) VALUES (@IdEmpresa, @Lista, @DescMax, @MargemLucro, @PerComissao, @DataModificacao)";

                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEmpresa", CodEmpresa);
                        command.Parameters.AddWithValue("@Lista", Lista);
                        command.Parameters.AddWithValue("@DescMax", DescontoMaximo);
                        command.Parameters.AddWithValue("@MargemLucro", MargemLucro);
                        command.Parameters.AddWithValue("@PerComissao", PercCom);
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
                    string query = "UPDATE Listas SET IdEmpresa=@IdEmpresa, Lista=@Lista, DescMax=@DescMax,, MargemLucro=@MargemLucro, PerComissao=@PerComissao, DataModificacao=@DataModificacao WHERE IdLista = @IdLista";
                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEmpresa", CodEmpresa);
                        command.Parameters.AddWithValue("@Lista", Lista);
                        command.Parameters.AddWithValue("@DescMax", DescontoMaximo);
                        command.Parameters.AddWithValue("@MargemLucro", MargemLucro);
                        command.Parameters.AddWithValue("@PerComissao", PercCom);
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
    }

}
