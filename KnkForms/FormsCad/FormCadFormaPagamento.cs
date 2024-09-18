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
    public partial class FormCadFormaPagamento : KnkForms.FormCadPai
    {
        FormaPagamentos aFormaPag;
        public FormCadFormaPagamento()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(Object obj)
        {
            aFormaPag = (FormaPagamentos)obj;
        }

        public override void LimpaTxt()
        {
            txtCod.Clear();
            txtNomePagamento.Clear();
            txtOpDisp.Clear();
            txtNfce.Clear();
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
        }

        public override void CarregaTxt()
        {
            txtCod.Text = Convert.ToString(aFormaPag.Cod);
            txtNomePagamento.Text = aFormaPag.Nome;
            txtOpDisp.Text = aFormaPag.OperacaoDisponivel;
            txtNfce.Text = aFormaPag.Nfce;
            txtCodUser.Text = Convert.ToString(aFormaPag.CodEmpresa);
            txtDataCad.Text = Convert.ToString(aFormaPag.DataCadastro);
            txtDataAlt.Text = Convert.ToString(aFormaPag.DataModificacao);
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtNomePagamento.Enabled = false;
            txtOpDisp.Enabled = false;
            txtNfce.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtNomePagamento.Enabled = true;
            txtOpDisp.Enabled = true;
            txtNfce.Enabled = true;
            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
        }

        public override void Salvar()
        {
            aFormaPag.Cod = Convert.ToInt32(txtCod.Text);
            aFormaPag.Nome = txtNomePagamento.Text;
            aFormaPag.OperacaoDisponivel = txtOpDisp.Text;
            aFormaPag.Nfce = txtNfce.Text;
            aFormaPag.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            aFormaPag.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            aFormaPag.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);
        }
    }
}
