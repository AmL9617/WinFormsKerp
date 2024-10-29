using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KnkForms.Classes;
using KnkForms.Forms;
using KnkForms.FormsCon;

namespace KnkForms
{
    public partial class FormPrincipal : FormPai
    {
        Interfaces aInter;
        
        Cidades aCidade;
        Clientes oCliente;
        CondicaoPagamentos aCondPag;
        Contadores oContador;
        Contatos oContato;
        Estados oEstado;
        FormaPagamentos aFormaPag;
        Fornecedores oFornecedor;
        Funcionarios oFuncionario;
        Grupos oGrupo;
        ListaPrecos aListaPreco;
        ListaCodST aListaCodST;
        Marcas aMarca;
        Paises oPais;
        Parcelas aParcela;
        RamoAtividades oRamoAtiv;
        RamoAtividadesClientes oRamoAtivClientes;
        Regioes aRegiao;
        Subgrupos oSubgrupo;
        Transportadoras aTransportadora;
        Vendedores oVendedor;

        public FormPrincipal()
        {
            InitializeComponent();
            aInter = new Interfaces();
            aCidade = new Cidades();
            oCliente = new Clientes();
            aCondPag = new CondicaoPagamentos();
            oContador = new Contadores();
            oContato = new Contatos();
            oEstado = new Estados();
            aFormaPag = new FormaPagamentos();
            oFornecedor = new Fornecedores();
            oFuncionario = new Funcionarios();
            oGrupo = new Grupos();
            aListaPreco = new ListaPrecos();
            aListaCodST = new ListaCodST();
            aMarca = new Marcas();
            oPais = new Paises();
            aParcela = new Parcelas();
            oRamoAtiv = new RamoAtividades();
            oRamoAtivClientes = new RamoAtividadesClientes();
            aRegiao = new Regioes();
            oSubgrupo = new Subgrupos();
            aTransportadora = new Transportadoras();
            oVendedor = new Vendedores();
        }

        //Cadastros
        private void cadCidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaCidades(aCidade);
        }

        private void cadClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            aInter.PecaClientes(oCliente);
        }

        private void cadCondicaoDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            aInter.PecaCondicoesPagamento(aCondPag);
        }

        private void cadContadorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            aInter.PecaContadores(oContador);
        }
        private void contatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaContatos(oContato);
        }
        private void cadEstadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            aInter.PecaEstados(oEstado);
        }

        private void cadFormaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            aInter.PecaFormasPagamento(aFormaPag);
        }

        private void cadFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            aInter.PecaFornecedores(oFornecedor);
        }

        private void cadFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            aInter.PecaFuncionarios(oFuncionario);
        }

        private void cadGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {

            aInter.PecaGrupos(oGrupo);
        }

        private void cadListaDePrecosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaListaPrecos(aListaPreco);

        }
        private void listaSTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaListaCodST(aListaCodST);
        }

        private void cadMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            aInter.PecaMarcas(aMarca);
        }

        private void cadPaisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaPaises(oPais);
        }

        private void cadParcelasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            aInter.PecaParcelas(aParcela);
        }

        private void cadRamoDeAtividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            aInter.PecaRamosAtividade(oRamoAtiv);
        }
        private void ramoDeAtividadesDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaRamoAtividadeClientes(oRamoAtivClientes);
        }
        private void cadRegioesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            aInter.PecaRegioes(aRegiao);
        }
        private void subgruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaSubgrupos(oSubgrupo);
        }
        private void cadTransportadorasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            aInter.PecaTransportadoras(aTransportadora);
        }

        private void cadVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            aInter.PecaVendedores(oVendedor);
        }

        
    }
}
