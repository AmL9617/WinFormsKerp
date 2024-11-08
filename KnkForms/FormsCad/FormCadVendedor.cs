﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KnkForms.Classes
{
    public partial class FormCadVendedor : KnkForms.FormCadPai
    {
        Vendedores oVendedor;
        public FormCadVendedor()
        {
            InitializeComponent();
            //Padronização das datas para dia/mês/ano
            dataComissao.CustomFormat = "dd/MM/yyyy";
            dataComissao.Format = DateTimePickerFormat.Custom;

        }
        public override void ConhecaObj(Object obj)
        {
            oVendedor = (Vendedores)obj;
        }
        private void chkBox(object sender, KeyEventArgs e)
        {
            CheckBox c1 = this.ActiveControl as CheckBox;
            if (e.KeyData == Keys.Enter && this.ActiveControl.Equals(c1))
                if (c1.Checked == false) c1.Checked = true; else c1.Checked = false;
        }
        public override void LimpaTxt()
        {
            txtCod.Clear();
            txtVendedor.Clear();
            txtTipo.Clear();
            txtComissao.Clear();
            dataComissao.Value = DateTime.Today;
            chkAtivo.Checked = false;
            txtObservacao.Clear();
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
        }

        public override void CarregaTxt()
        {
            txtCod.Text = Convert.ToString(oVendedor.Cod);
            txtCod.Enabled = false;
            txtVendedor.Text = oVendedor.Vendedor;
            txtTipo.Text = oVendedor.Tipo;
            txtComissao.Text = Convert.ToString(oVendedor.Comissao);
            if (oVendedor.Ativo == 'S') { chkAtivo.Checked = true; } else { chkAtivo.Checked = false; };
            dataComissao.Value = oVendedor.ComissaoPrazo;
            txtObservacao.Text = Convert.ToString(oVendedor.Observacao);
            txtCodUser.Text = Convert.ToString(oVendedor.CodEmpresa);
            txtDataCad.Text = Convert.ToString(oVendedor.DataCadastro);
            txtDataAlt.Text = Convert.ToString(oVendedor.DataModificacao);
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtVendedor.Enabled = false;
            txtTipo.Enabled = false;
            txtComissao.Enabled = false;
            chkAtivo.Enabled = false;
            dataComissao.Enabled = false;
            txtObservacao.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtVendedor.Enabled = true;
            txtTipo.Enabled = true;
            txtComissao.Enabled = true;
            chkAtivo.Enabled = true;
            dataComissao.Enabled = true;
            txtObservacao.Enabled = true;
            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
        }

        public override void Salvar()
        {
            oVendedor.Cod = Convert.ToInt32(txtCod.Text);
            oVendedor.Vendedor = txtVendedor.Text;
            oVendedor.Tipo = txtTipo.Text;
            oVendedor.Comissao = Convert.ToDouble(txtComissao.Text);
            oVendedor.ComissaoPrazo = dataComissao.Value;
            if (chkAtivo.Checked == true) { oVendedor.Ativo = 'S'; } else { oVendedor.Ativo = 'N'; };
            oVendedor.Observacao = txtObservacao.Text;
            oVendedor.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            oVendedor.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            oVendedor.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);

            txtCod.Enabled = true;
        }
    }
}
