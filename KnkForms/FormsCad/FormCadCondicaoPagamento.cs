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
            boxTipo.Text = "";
            txtTaxaJuro.Clear();
            boxOpDisp.Text = "";
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
            if(campo5 == "P") { boxTipo.Text = "Prazo"; } else { boxTipo.Text = "Mensal"; }
            txtDia.Text = campo6;
            if (campo7 == "C") { boxOpDisp.Text = "Compras"; }
            else if (campo7 == "V") { boxOpDisp.Text = "Vendas"; }
            else { boxOpDisp.Text = "Ambos"; }
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
            boxTipo.Enabled = false;
            txtTaxaJuro.Enabled = false;
            boxOpDisp.Enabled = false;
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
            boxTipo.Enabled = true;
            txtTaxaJuro.Enabled = true;
            boxOpDisp.Enabled = true;
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
            aCondPag.CondPag = txtCondPag.Text;
            if(boxTipo.Text == "Prazo") { aCondPag.Tipo = "P"; } else { aCondPag.Tipo = "M"; }
            aCondPag.TaxaJuro = !string.IsNullOrEmpty(txtTaxaJuro.Text) ? (double?)Convert.ToInt32(txtTaxaJuro.Text) : null; ;
            if(boxOpDisp.Text == "Compras") { aCondPag.OperacaoDisponivel = "C"; }
            else if(boxOpDisp.Text == "Vendas") { aCondPag.OperacaoDisponivel = "V"; }
            else { aCondPag.OperacaoDisponivel = "A"; }
            aCondPag.NumeroParcelas = !string.IsNullOrEmpty(txtNumParc.Text) ? (int?)Convert.ToInt32(txtNumParc.Text) : null; ;
            aCondPag.PorParcela = txtPorParcela.Text;
            aCondPag.Dia = txtDia.Text;
            if (chkAtivo.Checked == true) { aCondPag.Ativo = 'S'; } else { aCondPag.Ativo = 'N'; };
            aCondPag.CodEmpresa = 1;
            aCondPag.DataModificacao = DateTime.Now;

            if (SalvarAlterar == 'A')
            {
                aCondPag.Cod = Convert.ToInt32(txtCod.Text);
                aCondPag.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
                aCondPag.AlterarBD(aCondPag.Cod);
            }
                
            else
            {
                aCondPag.DataCadastro = DateTime.Now;
                aCondPag.SalvarBD();
            }
                
            SalvarAlterar = '\0';
            Close();
        }
        private void chkBox(object sender, KeyEventArgs e)
        {
            CheckBox c1 = this.ActiveControl as CheckBox;
            if (e.KeyData == Keys.Enter && this.ActiveControl.Equals(c1))
                if (c1.Checked == false) c1.Checked = true; else c1.Checked = false;
        }
    }
}
