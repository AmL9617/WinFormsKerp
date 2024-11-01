using KnkForms.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KnkForms.Forms
{
    public partial class FormCadMarca : KnkForms.FormCadPai
    {
        Marcas aMarca;
        public FormCadMarca()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(Object obj)
        {
            aMarca = (Marcas)obj;
        }

        public override void LimpaTxt()
        {
            txtCod.Clear();
            txtMarca.Clear();
            chkAtivo.Checked = false;
        }

        public override void CarregaTxt()
        {
            txtCod.Text = Convert.ToString(aMarca.Cod);
            txtCod.Enabled = false;
            txtMarca.Text = aMarca.Marca;
            if (chkAtivo.Checked == true) { aMarca.Ativo = 'S'; } else { aMarca.Ativo = 'N'; };
            txtCodUser.Text = Convert.ToString(aMarca.CodEmpresa);
            txtDataCad.Text = Convert.ToString(aMarca.DataCadastro);
            txtDataAlt.Text = Convert.ToString(aMarca.DataModificacao);
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtMarca.Enabled = false;
            chkAtivo.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtMarca.Enabled = true;
            chkAtivo.Enabled = true;
            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
        }

        public override void Salvar()
        {
            aMarca.Cod = Convert.ToInt32(txtCod.Text);
            aMarca.Marca = txtMarca.Text;
            if (chkAtivo.Checked == true) { aMarca.Ativo = 'S'; } else { aMarca.Ativo = 'N'; };
            aMarca.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            aMarca.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            aMarca.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);

            txtCod.Enabled = true;
        }
        private void chkBox(object sender, KeyEventArgs e)
        {
            CheckBox c1 = this.ActiveControl as CheckBox;
            if (e.KeyData == Keys.Enter && this.ActiveControl.Equals(c1))
                if (c1.Checked == false) c1.Checked = true; else c1.Checked = false;
        }
    }
}
