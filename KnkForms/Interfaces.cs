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
        FormConEstados oFormConEstados;
        FormConFormaPagamentos oFormConFormaPag;
        FormConFornecedores oFormConFornecedores;
        FormConFuncionarios oFormConFuncionarios;
        FormConGrupos oFormConGrupos;
        FormConListaPrecos oFormConListaPrecos;
        FormConListaCodST oFormConListaCodST;
        FormConMarcas oFormConMarcas;
        FormConPaises oFormConPaises;
        FormConParcelas oFormConParcelas;
        FormConRamoAtividades oFormConRamoAtividades;
        FormConRamoAtivClientes oFormConRamoAtivClientes;
        FormConRegioes oFormConRegioes;
        FormConSubgrupos oFormConSubgrupos;
        FormConTransportadoras oFormConTransportadoras;
        FormConVendedores oFormConVendedores;

        //Cadastros
        FormCadCidade oFormCadCidade;
        FormCadCliente oFormCadCliente;
        FormCadCondicaoPagamento oFormCadCondPag;
        FormCadContador oFormCadContador;
        FormCadContato oFormCadContato;
        FormCadEstado oFormCadEstado;
        FormCadFormaPagamento oFormCadFormaPag;
        FormCadFornecedor oFormCadFornecedor;
        FormCadFuncionario oFormCadFuncionario;
        FormCadGrupo oFormCadGrupo;
        FormCadListaPreco oFormCadListaPreco;
        FormCadListaCodST oFormCadListaCodST;
        FormCadMarca oFormCadMarca;
        FormCadPais oFormCadPais;
        FormCadParcela oFormCadParcela;
        FormCadRamoAtividade oFormCadRamoAtiv;
        FormCadRamoAtivCliente oFormCadRamoAtivCliente;
        FormCadRegiao oFormCadRegiao;
        FormCadSubgrupo oFormCadSubgrupo;
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
            oFormConEstados = new FormConEstados();
            oFormConFormaPag = new FormConFormaPagamentos();
            oFormConFornecedores = new FormConFornecedores();
            oFormConFuncionarios = new FormConFuncionarios();
            oFormConGrupos = new FormConGrupos();
            oFormConListaPrecos = new FormConListaPrecos();
            oFormConListaCodST = new FormConListaCodST();
            oFormConMarcas = new FormConMarcas();
            oFormConPaises = new FormConPaises();
            oFormConParcelas = new FormConParcelas();
            oFormConRamoAtividades = new FormConRamoAtividades();
            oFormConRamoAtivClientes = new FormConRamoAtivClientes();
            oFormConRegioes = new FormConRegioes();
            oFormConSubgrupos = new FormConSubgrupos();
            oFormConTransportadoras = new FormConTransportadoras();
            oFormConVendedores = new FormConVendedores();

            // Cadastros
            oFormCadCidade = new FormCadCidade();
            oFormCadCliente = new FormCadCliente();
            oFormCadCondPag = new FormCadCondicaoPagamento();
            oFormCadContador = new FormCadContador();
            oFormCadContato = new FormCadContato();
            oFormCadEstado = new FormCadEstado();
            oFormCadFormaPag = new FormCadFormaPagamento();
            oFormCadFornecedor = new FormCadFornecedor();
            oFormCadFuncionario = new FormCadFuncionario();
            oFormCadGrupo = new FormCadGrupo();
            oFormCadListaPreco = new FormCadListaPreco();
            oFormCadListaCodST = new FormCadListaCodST();
            oFormCadMarca = new FormCadMarca();
            oFormCadPais = new FormCadPais();
            oFormCadParcela = new FormCadParcela();
            oFormCadRamoAtiv = new FormCadRamoAtividade();
            oFormCadRamoAtivCliente = new FormCadRamoAtivCliente();
            oFormCadRegiao = new FormCadRegiao();
            oFormCadSubgrupo = new FormCadSubgrupo();
            oFormCadTransportadora = new FormCadTransportadora();
            oFormCadVendedor = new FormCadVendedor();

            oFormConCidades.SetFrmCadastro(oFormCadCidade);
            oFormConClientes.SetFrmCadastro(oFormCadCliente);
            oFormConCondPag.SetFrmCadastro(oFormCadCondPag);
            oFormConContadores.SetFrmCadastro(oFormCadContador);
            oFormConContatos.SetFrmCadastro(oFormCadContato);
            oFormConEstados.SetFrmCadastro(oFormCadEstado);
            oFormConFormaPag.SetFrmCadastro(oFormCadFormaPag);
            oFormConFornecedores.SetFrmCadastro(oFormCadFornecedor);
            oFormConFuncionarios.SetFrmCadastro(oFormCadFuncionario);
            oFormConGrupos.SetFrmCadastro(oFormCadGrupo);
            oFormConListaPrecos.SetFrmCadastro(oFormCadListaPreco);
            oFormConListaCodST.SetFrmCadastro(oFormCadListaCodST);
            oFormConMarcas.SetFrmCadastro(oFormCadMarca);
            oFormConPaises.SetFrmCadastro(oFormCadPais);
            oFormConParcelas.SetFrmCadastro(oFormCadParcela);
            oFormConRamoAtividades.SetFrmCadastro(oFormCadRamoAtiv);
            oFormConRamoAtivClientes.SetFrmCadastro(oFormCadRamoAtivCliente);
            oFormConRegioes.SetFrmCadastro(oFormCadRegiao);
            oFormConSubgrupos.SetFrmCadastro(oFormCadSubgrupo);
            oFormConTransportadoras.SetFrmCadastro(oFormCadTransportadora);
            oFormConVendedores.SetFrmCadastro(oFormCadVendedor);

            //Agregação
            oFormCadCidade.setFrmConEstados(oFormConEstados);
            oFormCadCliente.setFrmConCondPag(oFormConCondPag);
            oFormCadCliente.setFrmConListaPrecos(oFormConListaPrecos);
            oFormCadCliente.setFrmConRegioes(oFormConRegioes);
            oFormCadCliente.setFrmConTransportadoras(oFormConTransportadoras);
            oFormCadCliente.setFrmConVendedores(oFormConVendedores);
            //oFormCadContador.setFrmConContatos(oFormConContatos);
            oFormCadContato.setFrmConClientes(oFormConClientes);
            oFormCadContador.setFrmConRegioes(oFormConRegioes);
            oFormCadEstado.setFrmConPaises(oFormConPaises);
            oFormCadFornecedor.setFrmConCidades(oFormConCidades);
            oFormCadFornecedor.setFrmConRegioes(oFormConRegioes);
            oFormCadFornecedor.setFrmConListaPrecos(oFormConListaPrecos);
            oFormCadFornecedor.setFrmConCondPagamentos(oFormConCondPag);
            oFormCadFuncionario.setFrmConRegioes(oFormConRegioes);
            oFormCadListaPreco.setFrmConMarcas(oFormConMarcas);
            oFormCadListaPreco.setFrmConSubgrupos(oFormConSubgrupos);
            oFormCadRamoAtivCliente.setFrmConClientes(oFormConClientes);
            oFormCadSubgrupo.setFrmConGrupos(oFormConGrupos);
            //oFormCadTransportadora.setFrmConContatos(oFormConContatos);
            oFormCadTransportadora.setFrmConRegioes(oFormConRegioes);
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
        public void PecaListaCodST(Object obj)
        {
            oFormConListaCodST.ConhecaObj(obj);
            oFormConListaCodST.ShowDialog();
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
        public void PecaSubgrupos(Object obj)
        {
            oFormConSubgrupos.ConhecaObj(obj);
            oFormConSubgrupos.ShowDialog();
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

        //TESTE
        public interface IConsultas
        {
            void SetConsultaId(string id, string tipo);
        }
    }
}
