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
    internal class CondicaoPagamentos : Pai
    {
        protected string condPag;
        protected char ativo;
        protected string tipo;
        protected double taxaJuro;
        protected string operacaoDisponivel;
        protected int numeroParcelas;
        protected string dia;
        protected string porParcela;

        string connectionString = "Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";

        public CondicaoPagamentos()
        {
            condPag = "";
            ativo = '\0';
            tipo = "";
            taxaJuro = 0.0f;
            operacaoDisponivel = "";
            numeroParcelas = 0;
            dia = "";
            porParcela = "";
        }

        public string CondPag
        {
            get { return condPag; }
            set { condPag = value; }
        }

        public char Ativo
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
        public string PorParcela
        {
            get { return porParcela; }
            set { porParcela = value; }
        }
        public void SalvarBD()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO CondicaoPagamento (IdEmpresa, CondicaoPagamento, TaxaJuros, NumeroParcelas, Tipo, Dia, Operacao, Ativo, PorParcela, DataCadastro, DataModificacao) VALUES (@IdEmpresa, @CondicaoPagamento, @TaxaJuros, @NumeroParcelas, @Tipo, @Dia, @Operacao, @Ativo, @PorParcela, @DataCadastro, @DataModificacao)";

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
                        command.Parameters.AddWithValue("@PorParcela", PorParcela);
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
        public void AlterarBD(int CodCondPag)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE CondicaoPagamento SET IdEmpresa=@IdEmpresa, CondicaoPagamento=@CondicaoPagamento, TaxaJuros=@TaxaJuros, NumeroParcelas=@NumeroParcelas, Tipo=@Tipo, Dia=@Dia, Operacao=@Operacao, Ativo=@Ativo, PorParcela=@PorParcela, DataCadastro=@DataCadastro, DataModificacao=@DataModificacao WHERE IdCondicaoPagamento = @IdCondicaoPagamento";
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
                        command.Parameters.AddWithValue("@PorParcela", PorParcela);
                        command.Parameters.AddWithValue("@DataCadastro", DataCadastro);
                        command.Parameters.AddWithValue("@DataModificacao", DataModificacao);
                        command.Parameters.AddWithValue("@IdCondicaoPagamento", CodCondPag);

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
