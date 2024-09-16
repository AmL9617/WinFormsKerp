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
            conCidadesToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new FormConCidades());
            conClientesToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new FormConCliente());
            conCondicaoDePagamentoToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new FormConCondicaoPagamento());
            conContadoresToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new FormConContador());
            conEmpresasToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new FormConEmpresa());
            conEstadosToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new FormConEstado());
            conFormasDePagamentoToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new FormConFormaPagamento());
            conFornecedoresToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new FormConFornecedor());
            conFuncionariosToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new FormConFuncionario());
            conGruposToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new FormConGrupo());
            conListaDePrecosToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new FormConListaPreco());
            conMarcasToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new FormConMarca());
            conPaisToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new FormConPais());
            conParcelasToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new FormConParcela());
            conRamoDeAtividadesToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new FormConRamoAtividade());
            conRegiaoToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new FormConRegiao());
            conTransportadorasToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new FormConTransportadora());
            conVendedoresToolStripMenuItem.Click += (sender, e) => OpenConsultationForm(new FormConVendedor());
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
