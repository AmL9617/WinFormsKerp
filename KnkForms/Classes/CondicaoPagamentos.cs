using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnkForms.Classes
{
    internal class CondicaoPagamentos : Pai
    {
        protected string condPag;
        protected bool ativo;
        protected string tipo;
        protected double taxaJuro;
        protected string operacaoDisponivel;
        protected int numeroParcelas;
        protected string dia;

        //Placeholder
        protected int codParcela;

        //Agregação
        protected Parcelas parcelas;

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\Database1.mdf;Integrated Security=True";

        public CondicaoPagamentos()
        {
            condPag = "";
            ativo = false;
            tipo = "";
            taxaJuro = 0.0f;
            operacaoDisponivel = "";
            numeroParcelas = 0;
            dia = "";
            parcelas = new Parcelas();
            codParcela = 0;
        }

        public string CondPag
        {
            get { return condPag; }
            set { condPag = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public double TaxaJuro
        {
            get { return taxaJuro; }
            set { taxaJuro = value; }
        }

        public string OperacaoDisponivel
        {
            get { return operacaoDisponivel; }
            set { operacaoDisponivel = value; }
        }

        public int NumeroParcelas
        {
            get { return numeroParcelas; }
            set { numeroParcelas = value; }
        }
        public string Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        public int CodParcela
        {
            get { return codParcela; }
            set { codParcela = value; }
        }
        public Parcelas Parcelas
        {
            get { return parcelas; }
            set { parcelas = value; }
        }
        public void SalvarBD()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO CondPagamentos (IdEmpresa, CondicaoPagamento, TaxaJuros, NumeroParcelas, Tipo, Dia, Operacao, Ativo, PorParcela, DataCadastro, DataAlteracao) VALUES (@IdEmpresa, @CondicaoPagamento, @TaxaJuros, @NumeroParcelas, @Tipo, @Dia, @Operacao, @Ativo, @PorParcela, @DataCadastro, @DataAlteracao)";

                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEmpresa", CodEmpresa);
                        command.Parameters.AddWithValue("@CondicaoPagamento", CondPag);
                        command.Parameters.AddWithValue("@TaxaJuros", TaxaJuro);
                        command.Parameters.AddWithValue("@NumeroParcelas", NumeroParcelas);
                        command.Parameters.AddWithValue("@Tipo", Tipo);
                        command.Parameters.AddWithValue("@Dia", Dia);
                        command.Parameters.AddWithValue("@Operacao", OperacaoDisponivel);
                        command.Parameters.AddWithValue("@Ativo", Ativo);
                        command.Parameters.AddWithValue("@PorParcela", CodParcela);
                        command.Parameters.AddWithValue("@DataCadastro", DataCadastro);
                        command.Parameters.AddWithValue("@DataAlteracao", DataModificacao);

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
