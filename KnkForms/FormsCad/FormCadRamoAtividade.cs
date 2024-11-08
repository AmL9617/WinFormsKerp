﻿using KnkForms.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KnkForms.Forms
{
    public partial class FormCadRamoAtividade : KnkForms.FormCadPai
    {
        RamoAtividades oRamo;
        public FormCadRamoAtividade()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(Object obj)
        {
            oRamo = (RamoAtividades)obj;
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
            txtNomeRamo.Clear();
            chkAtivo.Checked = false;
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
        }

        public override void CarregaTxt()
        {
            txtCod.Text = Convert.ToString(oRamo.Cod);
            txtCod.Enabled = false;
            txtNomeRamo.Text = oRamo.Ramo;
            if (chkAtivo.Checked == true) { oRamo.Ativo = 'S'; } else { oRamo.Ativo = 'N'; };
            txtCodUser.Text = Convert.ToString(oRamo.CodEmpresa);
            txtDataCad.Text = Convert.ToString(oRamo.DataCadastro);
            txtDataAlt.Text = Convert.ToString(oRamo.DataModificacao);
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtNomeRamo.Enabled = false;
            chkAtivo.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtNomeRamo.Enabled = true;
            chkAtivo.Enabled = true;
            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
        }

        public override void Salvar()
        {
            oRamo.Cod = Convert.ToInt32(txtCod.Text);
            oRamo.Ramo = txtNomeRamo.Text;
            if (chkAtivo.Checked == true) { oRamo.Ativo = 'S'; } else { oRamo.Ativo = 'N'; }; 
            oRamo.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            oRamo.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            oRamo.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);

            txtCod.Enabled = true;
        }
    }
}
