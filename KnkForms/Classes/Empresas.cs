using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnkForms.Classes
{
    internal class Empresas : Pai
    {
        protected string razaoSocial;
        protected string nomeFantasia;
        protected string cnpj;
        protected string cep;
        protected string endereco;
        protected int numero;
        protected string complemento;
        protected string bairro;

        protected int codCidades;
        protected int codRegiao;

        protected Cidades cidades;
        protected Regioes regioes;

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\Database1.mdf;Integrated Security=True";
        public Empresas()
        {
            razaoSocial = "";
            nomeFantasia = "";
            cnpj = "";
            cep = "";
            endereco = "";
            numero = 0;
            complemento = "";
            bairro = "";

            codCidades = 0;
            codRegiao = 0;
            cidades = new Cidades();
            regioes = new Regioes();
        }

        public string RazaoSocial
        {
            get { return razaoSocial; }
            set { razaoSocial = value; }
        }

        public string NomeFantasia
        {
            get { return nomeFantasia; }
            set { nomeFantasia = value; }
        }

        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public int CodCidades
        {
            get { return codCidades; }
            set { codCidades = value; }
        }
        public int CodRegioes
        {
            get { return codRegiao; }
            set { codRegiao = value; }
        }
        public Cidades Cidades
        {
            get { return cidades; }
            set { cidades = value; }
        }
        public Regioes Regioes
        {
            get { return regioes; }
            set { regioes = value; }
        }
        public void SalvarBD()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Empresas (RazaoSocial, NomeFantasia, Cnpj, Cep, IdCidade, IdRegiao, Logradouro, Numero, Complemento, Bairro) VALUES (@RazaoSocial, @NomeFantasia, @Cnpj, @Cep, @IdCidade, @IdRegiao, @Logradouro, @Numero, @Complemento, @Bairro)";

                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@RazaoSocial", RazaoSocial);
                        command.Parameters.AddWithValue("@NomeFantasia", NomeFantasia);
                        command.Parameters.AddWithValue("@Cnpj", Cnpj);
                        command.Parameters.AddWithValue("@Cep", Cep);
                        command.Parameters.AddWithValue("@IdCidade", CodCidades);
                        command.Parameters.AddWithValue("@IdRegiao", CodRegioes);
                        command.Parameters.AddWithValue("@Logradouro", Endereco);
                        command.Parameters.AddWithValue("@Numero", Numero);
                        command.Parameters.AddWithValue("@Complemento", Complemento);
                        command.Parameters.AddWithValue("@Bairro", Bairro);

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
    }

}
