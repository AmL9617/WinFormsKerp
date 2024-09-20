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
        FormConParcela oFrmConParcela;
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
            dataPrazo.Value = DateTime.Today;
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
            chkAtivo.Checked = false;
        }

        public override void CarregaTxt()
        {
            txtCod.Text = Convert.ToString(aCondPag.Cod);
            txtCondPag.Text = aCondPag.Nome;
            txtTipo.Text = aCondPag.Tipo;
            txtTaxaJuro.Text = Convert.ToString(aCondPag.TaxaJuro);
            dataPrazo.Value = aCondPag.Prazo;
            txtCodParcela.Text = Convert.ToString(aCondPag.CodParcela);
            txtCodUser.Text = Convert.ToString(aCondPag.CodEmpresa);
            txtDataCad.Text = Convert.ToString(aCondPag.DataCadastro);
            txtDataAlt.Text = Convert.ToString(aCondPag.DataModificacao);
            chkAtivo.Checked = aCondPag.Ativo;
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtCondPag.Enabled = false;
            txtTipo.Enabled = false;
            txtTaxaJuro.Enabled = false;
            txtCodParcela.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
            chkAtivo.Enabled = false;
            dataPrazo.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtCondPag.Enabled = true;
            txtTipo.Enabled = true;
            txtTaxaJuro.Enabled = true;
            txtCodParcela.Enabled = true;
            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
            chkAtivo.Enabled = true;
            dataPrazo.Enabled = true;
        }

        public override void Salvar()
        {
            aCondPag.Cod = Convert.ToInt32(txtCod.Text);
            aCondPag.Nome = txtCondPag.Text;
            aCondPag.Tipo = txtTipo.Text;
            aCondPag.TaxaJuro = Convert.ToDouble(txtTaxaJuro.Text);
            aCondPag.CodParcela = Convert.ToInt32(txtCodParcela.Text);
            aCondPag.Prazo = dataPrazo.Value;
            aCondPag.Ativo = chkAtivo.Checked;
            aCondPag.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            aCondPag.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            aCondPag.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);
        }
        public void setFrmConParcelas(Object obj)
        {
            oFrmConParcela = (FormConParcela)obj;
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            oFrmConParcela.ConhecaObj(aCondPag.Parcelas);
            oFrmConParcela.ShowDialog();
        }
    }
}
