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

namespace KnkForms
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            cadCidadesToolStripMenuItem.Click += (sender, e) => OpenRegisterForm(new FormCadCidade());
            cadClientesToolStripMenuItem.Click += (sender, e) => OpenRegisterForm(new FormCadClientes());
            cadCondicaoDePagamentoToolStripMenuItem.Click += (sender, e) => OpenRegisterForm(new FormCadCondicaoPagamento());
            cadContadorToolStripMenuItem.Click += (sender, e) => OpenRegisterForm(new FormCadContador());
            cadEmpresaToolStripMenuItem.Click += (sender, e) => OpenRegisterForm(new FormCadEmpresa());
            cadEstadosToolStripMenuItem.Click += (sender, e) => OpenRegisterForm(new FormCadEstado());
            cadFormaDePagamentoToolStripMenuItem.Click += (sender, e) => OpenRegisterForm(new FormCadFormaPagamento());
            cadFornecedoresToolStripMenuItem.Click += (sender, e) => OpenRegisterForm(new FormCadFornecedor());
            cadFuncionariosToolStripMenuItem.Click += (sender, e) => OpenRegisterForm(new FormCadFuncionario());
            cadGruposToolStripMenuItem.Click += (sender, e) => OpenRegisterForm(new FormCadGrupo());
            cadListaDePrecosToolStripMenuItem.Click += (sender, e) => OpenRegisterForm(new FormCadListaPreco());
            cadMarcasToolStripMenuItem.Click += (sender, e) => OpenRegisterForm(new FormCadMarca());
            cadPaisesToolStripMenuItem.Click += (sender, e) => OpenRegisterForm(new FormCadPais());
            cadParcelasToolStripMenuItem.Click += (sender, e) => OpenRegisterForm(new FormCadParcela());
            cadRamoDeAtividadesToolStripMenuItem.Click += (sender, e) => OpenRegisterForm(new FormCadRamoAtividade());
            cadRegioesToolStripMenuItem.Click += (sender, e) => OpenRegisterForm(new FormCadRegiao());
            cadTransportadorasToolStripMenuItem.Click += (sender, e) => OpenRegisterForm(new FormCadTransportadora());
            cadVendedoresToolStripMenuItem.Click += (sender, e) => OpenRegisterForm(new FormCadVendedor());

            // Register click events for each MenuStrip item for Consultation
            consultaCidadesToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new formConCidades());
            consultaClientesToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new formConClientes());
            consultaCondicaoPagamentoToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new formConCondicaoPagamento());
            consultaContadorToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new formConContador());
            consultaEmpresaToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new formConEmpresa());
            consultaEstadoToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new formConEstado());
            consultaFormaPagamentoToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new formConFormaPagamento());
            consultaFornecedorToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new formConFornecedor());
            consultaFuncionarioToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new formConFuncionario());
            consultaGrupoToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new formConGrupo());
            consultaListaPrecoToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new formConListaPreco());
            consultaMarcaToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new formConMarca());
            consultaPaiToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new formConPai());
            consultaPaisToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new formConPais());
            consultaParcelaToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new formConParcela());
            consultaRamoAtividadeToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new formConRamoAtividade());
            consultaRegiaoToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new formConRegiao());
            consultaTransportadoraToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new formConTransportadora());
            consultaVendedorToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new formConVendedor());
        }

        private void OpenRegisterForm(Form registerForm)
        {
            registerForm.Show();
        }

        private void OpenConsultationForm(Form consultationForm)
        {
            consultationForm.Show();
        }
    }
}
