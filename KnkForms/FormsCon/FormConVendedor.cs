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
    public partial class FormConVendedor : KnkForms.FormsCon.FormConPai
    {
        FormCadVendedor oFormCadVendedor;
        Vendedores oVendedor;
        public FormConVendedor()
        {
            InitializeComponent();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadVendedor = (FormCadVendedor)form;
        }

        public override void ConhecaObj(Object obj)
        {
            oVendedor = (Vendedores)obj;
        }

        protected override void Incluir()
        {
            oFormCadVendedor.ConhecaObj(oVendedor);
            oFormCadVendedor.LimpaTxt();
            oFormCadVendedor.ShowDialog();
        }

        protected override void Alterar()
        {
            oFormCadVendedor.LimpaTxt();
            oFormCadVendedor.CarregaTxt();
            oFormCadVendedor.ShowDialog();
        }

        protected override void Excluir()
        {
            oFormCadVendedor.LimpaTxt();
            oFormCadVendedor.ConhecaObj(oVendedor);
            oFormCadVendedor.CarregaTxt();
            oFormCadVendedor.BloqueiaTxt();
            oFormCadVendedor.ShowDialog();
            oFormCadVendedor.DesbloqueiaTxt();
        }
    }
}
