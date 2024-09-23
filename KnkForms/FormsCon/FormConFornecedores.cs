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
    public partial class FormConFornecedores : KnkForms.FormsCon.FormConPai
    {
        FormCadFornecedor oFormCadFornecedor;
        Fornecedores oFornecedor;
        public FormConFornecedores()
        {
            InitializeComponent();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadFornecedor = (FormCadFornecedor)form;
        }

        public override void ConhecaObj(Object obj)
        {
            oFornecedor = (Fornecedores)obj;
        }

        protected override void Incluir()
        {
            oFormCadFornecedor.ConhecaObj(oFornecedor);
            oFormCadFornecedor.LimpaTxt();
            oFormCadFornecedor.ShowDialog();
        }

        protected override void Alterar()
        {
            oFormCadFornecedor.LimpaTxt();
            oFormCadFornecedor.CarregaTxt();
            oFormCadFornecedor.ShowDialog();
        }

        protected override void Excluir()
        {
            oFormCadFornecedor.LimpaTxt();
            oFormCadFornecedor.ConhecaObj(oFornecedor);
            oFormCadFornecedor.CarregaTxt();
            oFormCadFornecedor.BloqueiaTxt();
            oFormCadFornecedor.ShowDialog();
            oFormCadFornecedor.DesbloqueiaTxt();
        }

    }
}
