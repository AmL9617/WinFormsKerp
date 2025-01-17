﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnkForms.Classes
{
    internal class Fornecedores : Pai
    {
        protected char industria;
        protected char fisicaJuridica;
        protected char ativo;
        protected string razaoSocial;
        protected string nomeFantasia;
        protected string endereco;
        protected int? numero;
        protected string complemento;
        protected string bairro;
        protected string cep;
        protected string cnpj;
        protected string inscricaoEstadual;
        protected string trade;
        protected string codProdIgual;
        protected double? limiteCredito;
        protected string observacoes;
        protected char verEmClientes;
        protected DateTime? ultimoMovimento;

        //Placeholder
        protected int? codCidades;
        protected int? codRegioes;
        protected int? codListaPrecos;
        protected int? codCondPag;
        //Agregação
        protected Cidades cidades;
        protected Regioes regioes;
        protected ListaPrecos listaPrecos;
        protected CondicaoPagamentos condicaoPagamentos;

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\localKerp.mdf;Integrated Security=True;Connect Timeout=30";
        //"Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";
        public Fornecedores()
        {
            industria = '\0';
            fisicaJuridica = '\0';
            ativo = '\0';
            razaoSocial = "";
            nomeFantasia = "";
            endereco = "";
            numero = 0;
            complemento = "";
            bairro = "";
            cep = "";
            cnpj = "";
            inscricaoEstadual = "";
            trade = "";
            codProdIgual = "";
            limiteCredito = 0.0f;
            observacoes = "";
            verEmClientes = '\0';
            ultimoMovimento = DateTime.MinValue;

            codCidades = 0;
            cidades = new Cidades();
            codRegioes = 0;
            regioes = new Regioes();
            codListaPrecos = 0;
            listaPrecos = new ListaPrecos();
            codCondPag = 0;
            condicaoPagamentos = new CondicaoPagamentos();
        }

        public char Industria
        {
            get { return industria; }
            set { industria = value; }
        }

        public char FisicaJuridica
        {
            get { return fisicaJuridica; }
            set { fisicaJuridica = value; }
        }

        public char Ativo
        {
            get { return ativo; }
            set { ativo = value; }
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

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public int? Numero
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

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public string CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public string InscricaoEstadual
        {
            get { return inscricaoEstadual; }
            set { inscricaoEstadual = value; }
        }

        public string Trade
        {
            get { return trade; }
            set { trade = value; }
        }

        public string CodProdIgual
        {
            get { return codProdIgual; }
            set { codProdIgual = value; }
        }

        public double? LimiteCredito
        {
            get { return limiteCredito; }
            set { limiteCredito = value; }
        }

        public string Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }

        public char VerEmClientes
        {
            get { return verEmClientes; }
            set { verEmClientes = value; }
        }

        public DateTime? UltimoMovimento
        {
            get { return ultimoMovimento; }
            set { ultimoMovimento = value; }
        }


        public int? CodCidades
        {
            get { return codCidades; }
            set { codCidades = value; }
        }

        public int? CodRegioes
        {
            get { return codRegioes; }
            set { codRegioes = value; }
        }
        public int? CodListaPrecos
        {
            get { return codListaPrecos; }
            set { codListaPrecos = value; }
        }
        public int? CodCondPag
        {
            get { return codCondPag; }
            set { codCondPag = value; }
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
        public ListaPrecos ListaPrecos
        {
            get { return listaPrecos; }
            set { listaPrecos = value; }
        }
        public CondicaoPagamentos CondicaoPagamentos
        {
            get { return condicaoPagamentos; }
            set { condicaoPagamentos = value; }
        }

        public void SalvarBD()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO FornCliente (IdEmpresa, RazaoSocial, NomeFantasia, InscricaoEstadual, CpfCnpj, Tipo, IdCidade, IdRegiao, Logradouro, Numero, Complemento, Bairro, Cep, ConsumidorRevenda, Observacao, Trade, CodProdIgual, LimiteCredito, Ativo, FisicaJuridica, DataCadastro, DataModificacao, IdLista, IdListaEmp, IdCondPag, IdCondPagEmp, IdCidadeEmp) VALUES (@IdEmpresa, @RazaoSocial, @NomeFantasia, @InscricaoEstadual, @CpfCnpj, @Tipo, @IdCidade, @IdRegiao, @Logradouro, @Numero, @Complemento, @Bairro, @Cep, @ConsumidorRevenda, @Observacao, @Trade, @CodProdIgual, @LimiteCredito, @Ativo, @FisicaJuridica, @DataCadastro, @DataModificacao, @IdLista, @IdListaEmp, @IdCondPag, @IdCondPagEmp, @IdCidadeEmp)";

                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEmpresa", CodEmpresa);
                        command.Parameters.AddWithValue("@RazaoSocial", RazaoSocial);
                        command.Parameters.AddWithValue("@NomeFantasia", NomeFantasia);
                        command.Parameters.AddWithValue("@InscricaoEstadual", InscricaoEstadual);
                        command.Parameters.AddWithValue("@CpfCnpj", CNPJ);
                        command.Parameters.AddWithValue("@Tipo", VerEmClientes);
                        command.Parameters.AddWithValue("@IdCidade", CodCidades);
                        command.Parameters.AddWithValue("@IdRegiao", CodRegioes);
                        command.Parameters.AddWithValue("@Logradouro", Endereco);
                        command.Parameters.AddWithValue("@Numero", Numero);
                        command.Parameters.AddWithValue("@Complemento", Complemento);
                        command.Parameters.AddWithValue("@Bairro", Bairro);
                        command.Parameters.AddWithValue("@Cep", Cep);
                        command.Parameters.AddWithValue("@ConsumidorRevenda", Industria);
                        command.Parameters.AddWithValue("@Observacao", Observacoes);
                        command.Parameters.AddWithValue("@Trade", Trade);
                        command.Parameters.AddWithValue("@CodProdIgual", CodProdIgual);
                        command.Parameters.AddWithValue("@LimiteCredito", LimiteCredito);
                        command.Parameters.AddWithValue("@Ativo", Ativo);
                        command.Parameters.AddWithValue("@FisicaJuridica", FisicaJuridica);
                        command.Parameters.AddWithValue("@IdLista", CodListaPrecos);
                        command.Parameters.AddWithValue("@IdListaEmp", CodEmpresa);
                        command.Parameters.AddWithValue("@IdCondPag", CodCondPag);
                        command.Parameters.AddWithValue("@IdCondPagEmp", CodEmpresa);
                        command.Parameters.AddWithValue("@IdCidadeEmp", CodEmpresa);
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
        public void AlterarBD(int CodFornCli)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE FornCliente SET IdEmpresa=@IdEmpresa, RazaoSocial=@RazaoSocial, NomeFantasia=@NomeFantasia, InscricaoEstadual=@InscricaoEstadual, CpfCnpj=@CpfCnpj, Tipo=@Tipo, IdCidade=@IdCidade, IdRegiao=@IdRegiao, Logradouro=@Logradouro, Numero=@Numero, Complemento=@Complemento, Bairro=@Bairro, Cep=@Cep, ConsumidorRevenda=@ConsumidorRevenda, Observacao=@Observacao, Trade=@Trade, CodProdIgual=@CodProdIgual, LimiteCredito=@LimiteCredito, Ativo=@Ativo, FisicaJuridica=@FisicaJuridica, DataCadastro=@DataCadastro, DataModificacao=@DataModificacao WHERE IdFornCliente = @IdFornCliente";
                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEmpresa", CodEmpresa);
                        command.Parameters.AddWithValue("@RazaoSocial", RazaoSocial);
                        command.Parameters.AddWithValue("@NomeFantasia", NomeFantasia);
                        command.Parameters.AddWithValue("@InscricaoEstadual", InscricaoEstadual);
                        command.Parameters.AddWithValue("@CpfCnpj", CNPJ);
                        command.Parameters.AddWithValue("@Tipo", VerEmClientes);
                        command.Parameters.AddWithValue("@IdCidade", CodCidades);
                        command.Parameters.AddWithValue("@IdRegiao", CodRegioes);
                        command.Parameters.AddWithValue("@Logradouro", Endereco);
                        command.Parameters.AddWithValue("@Numero", Numero);
                        command.Parameters.AddWithValue("@Complemento", Complemento);
                        command.Parameters.AddWithValue("@Bairro", Bairro);
                        command.Parameters.AddWithValue("@Cep", Cep);
                        command.Parameters.AddWithValue("@ConsumidorRevenda", Industria);
                        command.Parameters.AddWithValue("@Observacao", Observacoes);
                        command.Parameters.AddWithValue("@Trade", Trade);
                        command.Parameters.AddWithValue("@CodProdIgual", CodProdIgual);
                        command.Parameters.AddWithValue("@LimiteCredito", LimiteCredito);
                        command.Parameters.AddWithValue("@Ativo", Ativo);
                        command.Parameters.AddWithValue("@FisicaJuridica", FisicaJuridica);
                        command.Parameters.AddWithValue("@IdLista", CodListaPrecos);
                        command.Parameters.AddWithValue("@IdListaEmp", CodEmpresa);
                        command.Parameters.AddWithValue("@IdCondPag", CodCondPag);
                        command.Parameters.AddWithValue("@IdCondPagEmp", CodEmpresa);
                        command.Parameters.AddWithValue("@IdCidadeEmp", CodEmpresa);
                        command.Parameters.AddWithValue("@DataCadastro", DataCadastro);
                        command.Parameters.AddWithValue("@DataModificacao", DataModificacao);
                        command.Parameters.AddWithValue("@IdFornCliente", CodFornCli);

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
        public void ExcluirBD(int CodFornCliente)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM FornCliente WHERE IdFornCliente = @IdFornCliente";
                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdFornCliente", CodFornCliente);

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
