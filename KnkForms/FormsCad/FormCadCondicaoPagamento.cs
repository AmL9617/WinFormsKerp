using KnkForms.Classes;
using KnkForms.FormsCon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KnkForms.Forms
{
    public partial class FormCadCondicaoPagamento : KnkForms.FormCadPai
    {
        CondicaoPagamentos aCondPag;
        char SalvarAlterar = '\0';
        public FormCadCondicaoPagamento()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(Object obj)
        {
            aCondPag = (CondicaoPagamentos)obj;
        }

        public override void LimpaTxt()
        {
            txtCod.Clear();
            txtCondPag.Clear();
            txtTipo.Clear();
            txtTaxaJuro.Clear();
            txtOpDisp.Clear();
            txtNumParc.Clear();
            txtDia.Clear();
            txtPorParcela.Clear();
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
            chkAtivo.Checked = false;
        }

        public void CarregaTxt(string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string campo7, string campo8, string campo9, string campo10, string campo11, string campo12)
        {
            txtCod.Text = campo1;
            txtCondPag.Text = campo2;
            txtTaxaJuro.Text = campo3;
            txtNumParc.Text = campo4;
            txtTipo.Text = campo5;
            txtDia.Text = campo6;
            txtOpDisp.Text = campo7;
            if (campo8 == "0") chkAtivo.Checked = false; else chkAtivo.Checked = true;
            txtPorParcela.Text = campo9;
            txtCodUser.Text = campo10;
            txtDataCad.Text = campo11;
            txtDataAlt.Text = campo12;
            SalvarAlterar = 'A';
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtCondPag.Enabled = false;
            txtTipo.Enabled = false;
            txtTaxaJuro.Enabled = false;
            txtOpDisp.Enabled = false;
            txtNumParc.Enabled = false;
            txtPorParcela.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
            chkAtivo.Enabled = false;
            txtDia.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtCondPag.Enabled = true;
            txtTipo.Enabled = true;
            txtTaxaJuro.Enabled = true;
            txtOpDisp.Enabled = true;
            txtNumParc.Enabled = true;
            txtPorParcela.Enabled = true;
            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
            chkAtivo.Enabled = true;
            txtDia.Enabled = true;
        }

        public override void Salvar()
        {
            aCondPag.Cod = Convert.ToInt32(txtCod.Text);
            aCondPag.CondPag = txtCondPag.Text;
            aCondPag.Tipo = txtTipo.Text;
            aCondPag.TaxaJuro = Convert.ToDouble(txtTaxaJuro.Text);
            aCondPag.OperacaoDisponivel = txtOpDisp.Text;
            aCondPag.NumeroParcelas = Convert.ToInt32(txtNumParc.Text);
            aCondPag.PorParcela = txtPorParcela.Text;
            aCondPag.Dia = txtDia.Text;
            if (chkAtivo.Checked == true) { aCondPag.Ativo = 'S'; } else { aCondPag.Ativo = 'N'; };
            aCondPag.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            aCondPag.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            aCondPag.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);

            if (SalvarAlterar == 'A')
                aCondPag.AlterarBD(aCondPag.Cod);
            else
                aCondPag.SalvarBD();
            SalvarAlterar = '\0';
            txtCod.Enabled = true;
            Close();
        }
        private void chkBox(object sender, KeyEventArgs e)
        {
            CheckBox c1 = this.ActiveControl as CheckBox;
            if (e.KeyData == Keys.Enter && this.ActiveControl.Equals(c1))
                c1.Checked = true;
        }
    }
}
