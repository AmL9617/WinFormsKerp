using KnkForms.Classes;
using KnkForms.Forms;
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
        FormConCidades oFormConCidade;
        FormConCliente oFormConCliente;
        FormConCondicaoPagamento oFormConCondPag;
        FormConContador oFormConContador;
        FormConEmpresa oFormConEmpresa;
        FormConEstado oFormConEstado;
        FormConFormaPagamento oFormConFormaPag;
        FormConFornecedor oFormConFornecedor;
        FormConFuncionario oFormConFuncionario;
        FormConGrupo oFormConGrupo;
        FormConListaPreco oFormConListaPreco;
        FormConMarca oFormConMarca;
        FormConPais oFormConPais;
        FormConParcela oFormConParcela;
        FormConRamoAtividade oFormConRamoAtiv;
        FormConRegiao oFormConRegiao;
        FormConTransportadora oFormConTransportadora;
        FormConVendedor oFormConVendedor;

        //Cadastros
        FormCadCidade oFormCadCidade;
        FormCadCliente oFormCadCliente;
        FormCadCondicaoPagamento oFormCadCondPag;
        FormCadContador oFormCadContador;
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
        FormCadRegiao oFormCadRegiao;
        FormCadTransportadora oFormCadTransportadora;
        FormCadVendedor oFormCadVendedor;
       

        public Interfaces()
        {
            // Consultas
            oFormConCidade = new FormConCidades();
            oFormConCliente = new FormConCliente();
            oFormConCondPag = new FormConCondicaoPagamento();
            oFormConContador = new FormConContador();
            oFormConEmpresa = new FormConEmpresa();
            oFormConEstado = new FormConEstado();
            oFormConFormaPag = new FormConFormaPagamento();
            oFormConFornecedor = new FormConFornecedor();
            oFormConFuncionario = new FormConFuncionario();
            oFormConGrupo = new FormConGrupo();
            oFormConListaPreco = new FormConListaPreco();
            oFormConMarca = new FormConMarca();
            oFormConPais = new FormConPais();
            oFormConParcela = new FormConParcela();
            oFormConRamoAtiv = new FormConRamoAtividade();
            oFormConRegiao = new FormConRegiao();
            oFormConTransportadora = new FormConTransportadora();
            oFormConVendedor = new FormConVendedor();

            // Cadastros
            oFormCadCidade = new FormCadCidade();
            oFormCadCliente = new FormCadCliente();
            oFormCadCondPag = new FormCadCondicaoPagamento();
            oFormCadContador = new FormCadContador();
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
            oFormCadRegiao = new FormCadRegiao();
            oFormCadTransportadora = new FormCadTransportadora();
            oFormCadVendedor = new FormCadVendedor();

            oFormConCidade.SetFrmCadastro(oFormCadCidade);
            oFormConCliente.SetFrmCadastro(oFormCadCliente);
            oFormConCondPag.SetFrmCadastro(oFormCadCondPag);
            oFormConContador.SetFrmCadastro(oFormCadContador);
            oFormConEmpresa.SetFrmCadastro(oFormCadEmpresa);
            oFormConEstado.SetFrmCadastro(oFormCadEstado);
            oFormConFormaPag.SetFrmCadastro(oFormCadFormaPag);
            oFormConFornecedor.SetFrmCadastro(oFormCadFornecedor);
            oFormConFuncionario.SetFrmCadastro(oFormCadFuncionario);
            oFormConGrupo.SetFrmCadastro(oFormCadGrupo);
            oFormConListaPreco.SetFrmCadastro(oFormCadListaPreco);
            oFormConMarca.SetFrmCadastro(oFormCadMarca);
            oFormConPais.SetFrmCadastro(oFormCadPais);
            oFormConParcela.SetFrmCadastro(oFormCadParcela);
            oFormConRamoAtiv.SetFrmCadastro(oFormCadRamoAtiv);
            oFormConRegiao.SetFrmCadastro(oFormCadRegiao);
            oFormConTransportadora.SetFrmCadastro(oFormCadTransportadora);
            oFormConVendedor.SetFrmCadastro(oFormCadVendedor);

            //Agregação
            oFormCadCidade.setFrmConEstados(oFormConEstado);
            oFormCadCondPag.setFrmConParcelas(oFormConParcela);
            oFormCadEstado.setFrmConPaises(oFormConPais);
            oFormCadListaPreco.setFrmConMarcas(oFormConMarca);
            oFormCadListaPreco.setFrmConGrupos(oFormConGrupo);
        }

        public void PecaCidades(Object obj)
        {
            oFormConCidade.ConhecaObj(obj);
            oFormConCidade.ShowDialog();
        }

        public void PecaClientes(Object obj)
        {
            oFormConCliente.ConhecaObj(obj);
            oFormConCliente.ShowDialog();
        }

        public void PecaCondicoesPagamento(Object obj)
        {
            oFormConCondPag.ConhecaObj(obj);
            oFormConCondPag.ShowDialog();
        }

        public void PecaContadores(Object obj)
        {
            oFormConContador.ConhecaObj(obj);
            oFormConContador.ShowDialog();
        }

        public void PecaEmpresas(Object obj)
        {
            oFormConEmpresa.ConhecaObj(obj);
            oFormConEmpresa.ShowDialog();
        }

        public void PecaEstados(Object obj)
        {
            oFormConEstado.ConhecaObj(obj);
            oFormConEstado.ShowDialog();
        }

        public void PecaFormasPagamento(Object obj)
        {
            oFormConFormaPag.ConhecaObj(obj);
            oFormConFormaPag.ShowDialog();
        }

        public void PecaFornecedores(Object obj)
        {
            oFormConFornecedor.ConhecaObj(obj);
            oFormConFornecedor.ShowDialog();
        }

        public void PecaFuncionarios(Object obj)
        {
            oFormConFuncionario.ConhecaObj(obj);
            oFormConFuncionario.ShowDialog();
        }

        public void PecaGrupos(Object obj)
        {
            oFormConGrupo.ConhecaObj(obj);
            oFormConGrupo.ShowDialog();
        }

        public void PecaListaPrecos(Object obj)
        {
            oFormConListaPreco.ConhecaObj(obj);
            oFormConListaPreco.ShowDialog();
        }

        public void PecaMarcas(Object obj)
        {
            oFormConMarca.ConhecaObj(obj);
            oFormConMarca.ShowDialog();
        }
        public void PecaPaises(Object obj)
        {
            oFormConPais.ConhecaObj(obj);
            oFormConPais.ShowDialog();
        }

        public void PecaParcelas(Object obj)
        {
            oFormConParcela.ConhecaObj(obj);
            oFormConParcela.ShowDialog();
        }

        public void PecaRamosAtividade(Object obj)
        {
            oFormConRamoAtiv.ConhecaObj(obj);
            oFormConRamoAtiv.ShowDialog();
        }

        public void PecaRegioes(Object obj)
        {
            oFormConRegiao.ConhecaObj(obj);
            oFormConRegiao.ShowDialog();
        }

        public void PecaTransportadoras(Object obj)
        {
            oFormConTransportadora.ConhecaObj(obj);
            oFormConTransportadora.ShowDialog();
        }

        public void PecaVendedores(Object obj)
        {
            oFormConVendedor.ConhecaObj(obj);
            oFormConVendedor.ShowDialog();
        }
    }
}
