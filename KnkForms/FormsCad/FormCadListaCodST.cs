﻿using KnkForms.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KnkForms.FormsCad
{
    public partial class FormCadListaCodST : KnkForms.FormCadPai
    {
        ListaCodST aListaCodST;
        public FormCadListaCodST()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(Object obj)
        {
            aListaCodST = (ListaCodST)obj;
        }

        public override void LimpaTxt()
        {
            txtCod.Clear();
            txtTipo.Clear();
            txtDescricao.Clear();
            chkAtivo.Checked = false;
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
        }

        public override void CarregaTxt()
        {
            txtCod.Text = Convert.ToString(aListaCodST.Cod);
            txtCod.Enabled = false;
            txtTipo.Text = aListaCodST.Tipo;
            txtDescricao.Text = aListaCodST.Descricao;
            if (chkAtivo.Checked == true) { aListaCodST.Ativo = 'S'; } else { aListaCodST.Ativo = 'N'; };
            txtCodUser.Text = Convert.ToString(aListaCodST.CodEmpresa);
            txtDataCad.Text = Convert.ToString(aListaCodST.DataCadastro);
            txtDataAlt.Text = Convert.ToString(aListaCodST.DataModificacao);
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtTipo.Enabled = false;
            txtDescricao.Enabled = false;
            chkAtivo.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtTipo.Enabled = true;
            txtDescricao.Enabled = true;
            chkAtivo.Enabled = true;
            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
        }

        public override void Salvar()
        {
            aListaCodST.Cod = Convert.ToInt32(txtCod.Text);
            aListaCodST.Tipo = txtTipo.Text;
            aListaCodST.Descricao = txtDescricao.Text;
            if (chkAtivo.Checked == true) { aListaCodST.Ativo = 'S'; } else { aListaCodST.Ativo = 'N'; };
            aListaCodST.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            aListaCodST.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            aListaCodST.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);

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
