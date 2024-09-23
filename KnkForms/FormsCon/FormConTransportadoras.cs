using KnkForms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KnkForms.Classes
{
    public partial class FormConTransportadoras : KnkForms.FormsCon.FormConPai
    {
        FormCadTransportadora oFormCadTransportadora;
        Transportadoras aTransportadora;
        public FormConTransportadoras()
        {
            InitializeComponent();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadTransportadora = (FormCadTransportadora)form;
        }

        public override void ConhecaObj(Object obj)
        {
            aTransportadora = (Transportadoras)obj;
        }

        protected override void Incluir()
        {
            oFormCadTransportadora.ConhecaObj(aTransportadora);
            oFormCadTransportadora.LimpaTxt();
            oFormCadTransportadora.ShowDialog();
        }

        protected override void Alterar()
        {
            oFormCadTransportadora.LimpaTxt();
            oFormCadTransportadora.CarregaTxt();
            oFormCadTransportadora.ShowDialog();
        }

        protected override void Excluir()
        {
            oFormCadTransportadora.LimpaTxt();
            oFormCadTransportadora.ConhecaObj(aTransportadora);
            oFormCadTransportadora.CarregaTxt();
            oFormCadTransportadora.BloqueiaTxt();
            oFormCadTransportadora.ShowDialog();
            oFormCadTransportadora.DesbloqueiaTxt();
        }
    }
}
