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
    public partial class FormCadRegiao : KnkForms.FormCadPai
    {
        public FormCadRegiao()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(Object obj)
        {
            oPais = (Paises)obj;
        }

        public override void LimpaTxt()
        {
            txtCod.Clear();
            txtNomePais.Clear();
            txtTipoPais.Clear();
            txtSigla.Clear();
            txtDdi.Clear();
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
        }

        public override void CarregaTxt()
        {
            txtCod.Text = Convert.ToString(oPais.Cod);
            txtNomePais.Text = oPais.NomePais;
            txtTipoPais.Text = oPais.TipoPais;
            txtSigla.Text = Convert.ToString(oPais.Sigla);
            txtDdi.Text = Convert.ToString(oPais.DDI);
            txtCodUser.Text = Convert.ToString(oPais.CodEmpresa);
            txtDataCad.Text = Convert.ToString(oPais.DataCadastro);
            txtDataAlt.Text = Convert.ToString(oPais.DataModificacao);
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtNomePais.Enabled = false;
            txtTipoPais.Enabled = false;
            txtSigla.Enabled = false;
            txtDdi.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtNomePais.Enabled = true;
            txtTipoPais.Enabled = true;
            txtSigla.Enabled = true;
            txtDdi.Enabled = true;
            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
        }

        public override void Salvar()
        {
            oPais.Cod = Convert.ToInt32(txtCod.Text);
            oPais.NomePais = txtNomePais.Text;
            oPais.TipoPais = txtTipoPais.Text;
            oPais.Sigla = Convert.ToChar(txtSigla.Text);
            oPais.DDI = Convert.ToInt32(txtDdi.Text);
            oPais.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            oPais.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            oPais.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);
        }
    }
}
