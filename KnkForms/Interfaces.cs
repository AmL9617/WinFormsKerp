using KnkForms.Classes;
using KnkForms.Forms;
using KnkForms.FormsCad;
using KnkForms.FormsCon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms
{
    internal class Interfaces
    {
        //Consultas
        FormConCidades oFormConCidades;
        FormConClientes oFormConClientes;
        FormConCondicaoPagamentos oFormConCondPag;
        FormConContadores oFormConContadores;
        FormConContatos oFormConContatos;
        FormConEmpresas oFormConEmpresas;
        FormConEstados oFormConEstados;
        FormConFormaPagamentos oFormConFormaPag;
        FormConFornecedores oFormConFornecedores;
        FormConFuncionarios oFormConFuncionarios;
        FormConGrupos oFormConGrupos;
        FormConListaPrecos oFormConListaPrecos;
        FormConMarcas oFormConMarcas;
        FormConPaises oFormConPaises;
        FormConParcelas oFormConParcelas;
        FormConRamoAtividades oFormConRamoAtividades;
        FormConRamoAtivClientes oFormConRamoAtivClientes;
        FormConRegioes oFormConRegioes;
        FormConTransportadoras oFormConTransportadoras;
        FormConVendedores oFormConVendedores;

        //Cadastros
        FormCadCidade oFormCadCidade;
        FormCadCliente oFormCadCliente;
        FormCadCondicaoPagamento oFormCadCondPag;
        FormCadContador oFormCadContador;
        FormCadContato oFormCadContato;
        FormCadEmpresa oFormCadEmpresa;
        FormCadEstado oFormCadEstado;
        FormCadFormaPagamento oFormCadFormaPag;
        FormCadFornecedor oFormCadFornecedor;
        FormCadFuncionario oFormCadFuncionario;
        FormCadGrupo oFormCadGrupo;
        FormCadListaPreco oFormCadListaPreco;
        FormCadMarca oFormCadMarca;
        FormCadPais oFormCadPais;
        FormCadParcela oFormCadParcela;
        FormCadRamoAtividade oFormCadRamoAtiv;
        FormCadRamoAtivCliente oFormCadRamoAtivCliente;
        FormCadRegiao oFormCadRegiao;
        FormCadTransportadora oFormCadTransportadora;
        FormCadVendedor oFormCadVendedor;
       

        public Interfaces()
        {
            // Consultas
            oFormConCidades = new FormConCidades();
            oFormConClientes = new FormConClientes();
            oFormConCondPag = new FormConCondicaoPagamentos();
            oFormConContadores = new FormConContadores();
            oFormConContatos = new FormConContatos();
            oFormConEmpresas = new FormConEmpresas();
            oFormConEstados = new FormConEstados();
            oFormConFormaPag = new FormConFormaPagamentos();
            oFormConFornecedores = new FormConFornecedores();
            oFormConFuncionarios = new FormConFuncionarios();
            oFormConGrupos = new FormConGrupos();
            oFormConListaPrecos = new FormConListaPrecos();
            oFormConMarcas = new FormConMarcas();
            oFormConPaises = new FormConPaises();
            oFormConParcelas = new FormConParcelas();
            oFormConRamoAtividades = new FormConRamoAtividades();
            oFormConRamoAtivClientes = new FormConRamoAtivClientes();
            oFormConRegioes = new FormConRegioes();
            oFormConTransportadoras = new FormConTransportadoras();
            oFormConVendedores = new FormConVendedores();

            // Cadastros
            oFormCadCidade = new FormCadCidade();
            oFormCadCliente = new FormCadCliente();
            oFormCadCondPag = new FormCadCondicaoPagamento();
            oFormCadContador = new FormCadContador();
            oFormCadContato = new FormCadContato();
            oFormCadEmpresa = new FormCadEmpresa();
            oFormCadEstado = new FormCadEstado();
            oFormCadFormaPag = new FormCadFormaPagamento();
            oFormCadFornecedor = new FormCadFornecedor();
            oFormCadFuncionario = new FormCadFuncionario();
            oFormCadGrupo = new FormCadGrupo();
            oFormCadListaPreco = new FormCadListaPreco();
            oFormCadMarca = new FormCadMarca();
            oFormCadPais = new FormCadPais();
            oFormCadParcela = new FormCadParcela();
            oFormCadRamoAtiv = new FormCadRamoAtividade();
            oFormCadRamoAtivCliente = new FormCadRamoAtivCliente();
            oFormCadRegiao = new FormCadRegiao();
            oFormCadTransportadora = new FormCadTransportadora();
            oFormCadVendedor = new FormCadVendedor();

            oFormConCidades.SetFrmCadastro(oFormCadCidade);
            oFormConClientes.SetFrmCadastro(oFormCadCliente);
            oFormConCondPag.SetFrmCadastro(oFormCadCondPag);
            oFormConContadores.SetFrmCadastro(oFormCadContador);
            oFormConContatos.SetFrmCadastro(oFormCadContato);
            oFormConEmpresas.SetFrmCadastro(oFormCadEmpresa);
            oFormConEstados.SetFrmCadastro(oFormCadEstado);
            oFormConFormaPag.SetFrmCadastro(oFormCadFormaPag);
            oFormConFornecedores.SetFrmCadastro(oFormCadFornecedor);
            oFormConFuncionarios.SetFrmCadastro(oFormCadFuncionario);
            oFormConGrupos.SetFrmCadastro(oFormCadGrupo);
            oFormConListaPrecos.SetFrmCadastro(oFormCadListaPreco);
            oFormConMarcas.SetFrmCadastro(oFormCadMarca);
            oFormConPaises.SetFrmCadastro(oFormCadPais);
            oFormConParcelas.SetFrmCadastro(oFormCadParcela);
            oFormConRamoAtividades.SetFrmCadastro(oFormCadRamoAtiv);
            oFormConRamoAtivClientes.SetFrmCadastro(oFormCadRamoAtivCliente);
            oFormConRegioes.SetFrmCadastro(oFormCadRegiao);
            oFormConTransportadoras.SetFrmCadastro(oFormCadTransportadora);
            oFormConVendedores.SetFrmCadastro(oFormCadVendedor);

            //Agregação
            oFormCadCidade.setFrmConEstados(oFormConEstados);
            oFormCadCliente.setFrmConContatos(oFormConContatos);
            oFormCadCliente.setFrmConCondPag(oFormConCondPag);
            oFormCadCliente.setFrmConListaPrecos(oFormConListaPrecos);
            oFormCadCliente.setFrmConRegioes(oFormConRegioes);
            oFormCadCliente.setFrmConTransportadoras(oFormConTransportadoras);
            oFormCadCliente.setFrmConVendedores(oFormConVendedores);
            oFormCadCondPag.setFrmConParcelas(oFormConParcelas);
            oFormCadContador.setFrmConContatos(oFormConContatos);
            oFormCadEstado.setFrmConPaises(oFormConPaises);
            oFormCadFornecedor.setFrmConContatos(oFormConContatos);
            oFormCadListaPreco.setFrmConMarcas(oFormConMarcas);
            oFormCadListaPreco.setFrmConGrupos(oFormConGrupos);
            oFormCadRamoAtivCliente.setFrmConClientes(oFormConClientes);
            oFormCadTransportadora.setFrmConContatos(oFormConContatos);
        }

        public void PecaCidades(Object obj)
        {
            oFormConCidades.ConhecaObj(obj);
            oFormConCidades.ShowDialog();
        }

        public void PecaClientes(Object obj)
        {
            oFormConClientes.ConhecaObj(obj);
            oFormConClientes.ShowDialog();
        }

        public void PecaCondicoesPagamento(Object obj)
        {
            oFormConCondPag.ConhecaObj(obj);
            oFormConCondPag.ShowDialog();
        }

        public void PecaContadores(Object obj)
        {
            oFormConContadores.ConhecaObj(obj);
            oFormConContadores.ShowDialog();
        }

        public void PecaContatos(Object obj)
        {
            oFormConContatos.ConhecaObj(obj);
            oFormConContatos.ShowDialog();
        }
        public void PecaEmpresas(Object obj)
        {
            oFormConEmpresas.ConhecaObj(obj);
            oFormConEmpresas.ShowDialog();
        }

        public void PecaEstados(Object obj)
        {
            oFormConEstados.ConhecaObj(obj);
            oFormConEstados.ShowDialog();
        }

        public void PecaFormasPagamento(Object obj)
        {
            oFormConFormaPag.ConhecaObj(obj);
            oFormConFormaPag.ShowDialog();
        }

        public void PecaFornecedores(Object obj)
        {
            oFormConFornecedores.ConhecaObj(obj);
            oFormConFornecedores.ShowDialog();
        }

        public void PecaFuncionarios(Object obj)
        {
            oFormConFuncionarios.ConhecaObj(obj);
            oFormConFuncionarios.ShowDialog();
        }

        public void PecaGrupos(Object obj)
        {
            oFormConGrupos.ConhecaObj(obj);
            oFormConGrupos.ShowDialog();
        }

        public void PecaListaPrecos(Object obj)
        {
            oFormConListaPrecos.ConhecaObj(obj);
            oFormConListaPrecos.ShowDialog();
        }

        public void PecaMarcas(Object obj)
        {
            oFormConMarcas.ConhecaObj(obj);
            oFormConMarcas.ShowDialog();
        }
        public void PecaPaises(Object obj)
        {
            oFormConPaises.ConhecaObj(obj);
            oFormConPaises.ShowDialog();
        }

        public void PecaParcelas(Object obj)
        {
            oFormConParcelas.ConhecaObj(obj);
            oFormConParcelas.ShowDialog();
        }

        public void PecaRamosAtividade(Object obj)
        {
            oFormConRamoAtividades.ConhecaObj(obj);
            oFormConRamoAtividades.ShowDialog();
        }
        
        public void PecaRamoAtividadeClientes(Object obj)
        {
            oFormConRamoAtivClientes.ConhecaObj(obj);
            oFormConRamoAtivClientes.ShowDialog();
        }
        
        public void PecaRegioes(Object obj)
        {
            oFormConRegioes.ConhecaObj(obj);
            oFormConRegioes.ShowDialog();
        }

        public void PecaTransportadoras(Object obj)
        {
            oFormConTransportadoras.ConhecaObj(obj);
            oFormConTransportadoras.ShowDialog();
        }

        public void PecaVendedores(Object obj)
        {
            oFormConVendedores.ConhecaObj(obj);
            oFormConVendedores.ShowDialog();
        }
    }
}
