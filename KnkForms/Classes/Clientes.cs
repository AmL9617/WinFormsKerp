﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnkForms.Classes
{
    internal class Clientes : Pai
    {
        protected string cliente;
        protected string razaoSocial;
        protected string cpf;
        protected string endereco;
        protected int numero;
        protected string complemento;
        protected string bairro;
        protected string cep;
        protected char fisicaJuridica;
        protected char ativo;
        protected char consumidorRevenda;
        protected string inscricaoEstadual;
        protected string inscMunicipalSuframa;
        protected string cnpj;
        protected string regimeTributarioDaEmpresa;
       
        protected DateTime dataFundacao;
        protected char regimeSemSt;
        protected char produtorRural;
        protected char verEmFornecedores;
        protected string pessoasAutorizadas;
        protected string obsDiv;
        protected DateTime dataCad2;
        protected DateTime dataUltAlt2;
        protected DateTime ultimaCompra;

        //Placeholder
        protected int codRamoAtividades;
        protected int codRegioes;
        protected int codVendedores;
        protected int codFuncionarios;
        protected int codCondicaoPagamentos;
        protected int codCidades;
        protected int codTransportadoras;
        protected int codContadores;
        protected int codFornecedores;
        protected int codListaPrecos;

        //Agregação
        protected RamoAtividades ramoAtividades;
        protected Regioes regioes;
        protected Vendedores vendedores;
        protected Funcionarios funcionarios;
        protected CondicaoPagamentos condicaoPagamentos;
        protected Cidades cidades;
        protected Transportadoras transportadoras;
        protected Contadores contadores;
        protected Fornecedores fornecedores;
        protected ListaPrecos listaPrecos;

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\localKerp.mdf;Integrated Security=True;Connect Timeout=30";
        //"Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";


        public Clientes()
        {
            cliente = "";
            razaoSocial = "";
            cpf = "";
            endereco = "";
            numero = 0;
            complemento = "";
            bairro = "";
            cep = "";
            fisicaJuridica = '\0';
            ativo = '\0';
            consumidorRevenda = '\0';
            inscricaoEstadual = "";
            inscMunicipalSuframa = "";
            cnpj = "";
            regimeTributarioDaEmpresa = "";
            dataCad2 = DateTime.MinValue;
            dataUltAlt2 = DateTime.MinValue;
            dataFundacao = DateTime.MinValue;
            regimeSemSt = '\0';
            produtorRural = '\0';
            verEmFornecedores = '\0';
            pessoasAutorizadas = "";
            obsDiv = "";
            ultimaCompra = DateTime.MinValue;

            
            ramoAtividades = new RamoAtividades();
            regioes = new Regioes();
            vendedores = new Vendedores();
            funcionarios = new Funcionarios();
            condicaoPagamentos = new CondicaoPagamentos();
            cidades = new Cidades();
            transportadoras = new Transportadoras();
            contadores = new Contadores();
            fornecedores = new Fornecedores();
            listaPrecos = new ListaPrecos();

            codRamoAtividades = 0;
            codRegioes = 0;
            codVendedores = 0;
            codFuncionarios = 0;
            codCondicaoPagamentos = 0;
            codCidades = 0;
            codTransportadoras = 0;
            codContadores = 0;
            codFornecedores = 0;
            codListaPrecos = 0;
        }

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public string RazaoSocial
        {
            get { return razaoSocial; }
            set { razaoSocial = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
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

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
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

        public char ConsumidorRevenda
        {
            get { return consumidorRevenda; }
            set { consumidorRevenda = value; }
        }

        public string InscricaoEstadual
        {
            get { return inscricaoEstadual; }
            set { inscricaoEstadual = value; }
        }

        public string InscMunicipalSuframa
        {
            get { return inscMunicipalSuframa; }
            set { inscMunicipalSuframa = value; }
        }

        public string CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public string RegimeTributarioDaEmpresa
        {
            get { return regimeTributarioDaEmpresa; }
            set { regimeTributarioDaEmpresa = value; }
        }

        public DateTime DataCad2
        {
            get { return dataCad2; }
            set { dataCad2 = value; }
        }

        public DateTime DataUltAlt2
        {
            get { return dataUltAlt2; }
            set { dataUltAlt2 = value; }
        }

        public DateTime DataFundacao
        {
            get { return dataFundacao; }
            set { dataFundacao = value; }
        }

        public char RegimeSemSt
        {
            get { return regimeSemSt; }
            set { regimeSemSt = value; }
        }

        public char ProdutorRural
        {
            get { return produtorRural; }
            set { produtorRural = value; }
        }

        public char VerEmFornecedores
        {
            get { return verEmFornecedores; }
            set { verEmFornecedores = value; }
        }

        public string PessoasAutorizadas
        {
            get { return pessoasAutorizadas; }
            set { pessoasAutorizadas = value; }
        }

        public string ObsDiv
        {
            get { return obsDiv; }
            set { obsDiv = value; }
        }


        public DateTime UltimaCompra
        {
            get { return ultimaCompra; }
            set { ultimaCompra = value; }
        }


     
        public RamoAtividades RamoAtividades
        {
            get { return ramoAtividades; }
            set { ramoAtividades = value; }
        }

        public Regioes Regioes
        {
            get { return regioes; }
            set { regioes = value; }
        }

        public Vendedores Vendedores
        {
            get { return vendedores; }
            set { vendedores = value; }
        }

        public Funcionarios Funcionarios
        {
            get { return funcionarios; }
            set { funcionarios = value; }
        }

        public CondicaoPagamentos CondicaoPagamentos
        {
            get { return condicaoPagamentos; }
            set { condicaoPagamentos = value; }
        }

        public Cidades Cidades
        {
            get { return cidades; }
            set { cidades = value; }
        }

        public Transportadoras Transportadoras
        {
            get { return transportadoras; }
            set { transportadoras = value; }
        }

        public Contadores Contadores
        {
            get { return contadores; }
            set { contadores = value; }
        }

        public Fornecedores Fornecedores
        {
            get { return fornecedores; }
            set { fornecedores = value; }
        }

        public ListaPrecos ListaPrecos
        {
            get { return listaPrecos; }
            set { listaPrecos = value; }
        }



        public int CodRamoAtividades
        {
            get { return codRamoAtividades; }
            set { codRamoAtividades = value; }
        }

        public int CodRegioes
        {
            get { return codRegioes; }
            set { codRegioes = value; }
        }

        public int CodVendedores
        {
            get { return codVendedores; }
            set { codVendedores = value; }
        }

        public int CodFuncionarios
        {
            get { return codFuncionarios; }
            set { codFuncionarios = value; }
        }

        public int CodCondicaoPagamentos
        {
            get { return codCondicaoPagamentos; }
            set { codCondicaoPagamentos = value; }
        }

        public int CodCidades
        {
            get { return codCidades; }
            set { codCidades = value; }
        }

        public int CodTransportadoras
        {
            get { return codTransportadoras; }
            set { codTransportadoras = value; }
        }

        public int CodContadores
        {
            get { return codContadores; }
            set { codContadores = value; }
        }

        public int CodFornecedores
        {
            get { return codFornecedores; }
            set { codFornecedores = value; }
        }

        public int CodListaPrecos
        {
            get { return codListaPrecos; }
            set { codListaPrecos = value; }
        }
        public void SalvarBD()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO FornCliente (IdEmpresa, NomeFantasia, InscricaoEstadual, CpfCnpj, Tipo, IdCidade, IdRegiao, Logradouro, Numero, Complemento, Bairro, Cep, ConsumidorRevenda, Observacao, RegimeSemSt, ProdutorRural, DataUltimaCompra, Ativo, FisicaJuridica, DataCadastro, DataModificacao, IdCidadeEmp) VALUES (@IdEmpresa, @NomeFantasia, @InscricaoEstadual, @CpfCnpj, @Tipo, @IdCidade, @IdRegiao, @Logradouro, @Numero, @Complemento, @Bairro, @Cep, @ConsumidorRevenda, @Observacao, @RegimeSemSt, @ProdutorRural, @DataUltimaCompra, @Ativo, @FisicaJuridica, @DataCadastro, @DataModificacao, @IdCidadeEmp)";

                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEmpresa", CodEmpresa);
                        command.Parameters.AddWithValue("@NomeFantasia", Cliente);
                        command.Parameters.AddWithValue("@InscricaoEstadual", InscricaoEstadual);
                        command.Parameters.AddWithValue("@CpfCnpj", Cpf);
                        command.Parameters.AddWithValue("@Tipo", VerEmFornecedores);
                        command.Parameters.AddWithValue("@IdCidade", CodCidades);
                        command.Parameters.AddWithValue("@IdRegiao", CodRegioes);
                        command.Parameters.AddWithValue("@Logradouro", Endereco);
                        command.Parameters.AddWithValue("@Numero", Numero);
                        command.Parameters.AddWithValue("@Complemento", Complemento);
                        command.Parameters.AddWithValue("@Bairro", Bairro);
                        command.Parameters.AddWithValue("@Cep", Cep);
                        command.Parameters.AddWithValue("@ConsumidorRevenda", ConsumidorRevenda);
                        command.Parameters.AddWithValue("@Observacao", ObsDiv);
                        command.Parameters.AddWithValue("@RegimeSemSt", RegimeSemSt);
                        command.Parameters.AddWithValue("@ProdutorRural", ProdutorRural);
                        command.Parameters.AddWithValue("@DataUltimaCompra", UltimaCompra);
                        command.Parameters.AddWithValue("@Ativo", Ativo);
                        command.Parameters.AddWithValue("@FisicaJuridica", FisicaJuridica);
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
                    string query = "UPDATE FornCliente SET IdEmpresa=@IdEmpresa, NomeFantasia=@NomeFantasia, InscricaoEstadual=@InscricaoEstadual, CpfCnpj=@CpfCnpj, Tipo=@Tipo, IdCidade=@IdCidade, IdRegiao=@IdRegiao, Logradouro=@Logradouro, Numero=@Numero, Complemento=@Complemento, Bairro=@Bairro, Cep=@Cep, ConsumidorRevenda=@ConsumidorRevenda, Observacao=@Observacao, RegimeSemSt=@RegimeSemSt, ProdutorRural=@ProdutorRural, DataUltimaCompra=@DataUltimaCompra, Ativo=@Ativo, FisicaJuridica=@FisicaJuridica, DataCadastro=@DataCadastro, DataModificacao=@DataModificacao, IdCidadeEmp=@IdCidadeEmp WHERE IdFornCliente = @IdFornCliente";
                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEmpresa", CodEmpresa);
                        command.Parameters.AddWithValue("@NomeFantasia", Cliente);
                        command.Parameters.AddWithValue("@InscricaoEstadual", InscricaoEstadual);
                        command.Parameters.AddWithValue("@CpfCnpj", Cpf);
                        command.Parameters.AddWithValue("@Tipo", VerEmFornecedores);
                        command.Parameters.AddWithValue("@IdCidade", CodCidades);
                        command.Parameters.AddWithValue("@IdRegiao", CodRegioes);
                        command.Parameters.AddWithValue("@Logradouro", Endereco);
                        command.Parameters.AddWithValue("@Numero", Numero);
                        command.Parameters.AddWithValue("@Complemento", Complemento);
                        command.Parameters.AddWithValue("@Bairro", Bairro);
                        command.Parameters.AddWithValue("@Cep", Cep);
                        command.Parameters.AddWithValue("@ConsumidorRevenda", ConsumidorRevenda);
                        command.Parameters.AddWithValue("@Observacao", ObsDiv);
                        command.Parameters.AddWithValue("@RegimeSemSt", RegimeSemSt);
                        command.Parameters.AddWithValue("@ProdutorRural", ProdutorRural);
                        command.Parameters.AddWithValue("@DataUltimaCompra", UltimaCompra);
                        command.Parameters.AddWithValue("@Ativo", Ativo);
                        command.Parameters.AddWithValue("@FisicaJuridica", FisicaJuridica);
                        command.Parameters.AddWithValue("@IdCidadeEmp", CodEmpresa);
                        command.Parameters.AddWithValue("@DataCadastro", DataCadastro);
                        command.Parameters.AddWithValue("@DataModificacao", DataModificacao);

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
