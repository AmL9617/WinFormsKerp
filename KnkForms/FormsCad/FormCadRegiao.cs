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
    public partial class FormCadRegiao : KnkForms.FormCadPai
    {
        Regioes oRegiao;
        FormConRegioes oFormConRegioes;
        char SalvarAlterar = '\0';
        public FormCadRegiao()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(Object obj)
        {
            oRegiao = (Regioes)obj;
        }

        public override void LimpaTxt()
        {
            txtCod.Clear();
            txtRegiao.Clear();
            chkAtivo.Checked = false;
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
            txtDescricao.Clear();
        }

        public void CarregaTxt(string campo1, string campo2, string campo3, string campo4, string campo6, string campo7, string campo8)
        {
            txtCod.Text = campo1;
            txtCod.Enabled = false;
            txtRegiao.Text = campo2;
            txtDescricao.Text = campo3;
            if (campo4 == "0") { chkAtivo.Checked = false; } else { chkAtivo.Checked = true; } ;
            txtCodUser.Text = campo6;
            txtDataCad.Text = campo7;
            txtDataAlt.Text = campo8;
            SalvarAlterar = 'A';
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtRegiao.Enabled = false;
            chkAtivo.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
            txtDescricao.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtRegiao.Enabled = true;
            chkAtivo.Enabled = true;
            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
            txtDescricao.Enabled = true;
        }

        public override void Salvar()
        {
            oRegiao.Regiao = txtRegiao.Text;
            if (chkAtivo.Checked == true) { oRegiao.Ativo = 'S'; } else { oRegiao.Ativo = 'N'; };
            //Vai ficar valor 1 até eu implementar login
            oRegiao.CodEmpresa = 1;
            oRegiao.DataModificacao = DateTime.Today;
            oRegiao.Descricao = txtDescricao.Text;

            if (SalvarAlterar == 'A')
            {
                oRegiao.Cod = Convert.ToInt32(txtCod.Text);
                oRegiao.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
                oRegiao.AlterarBD(oRegiao.Cod);
            }
            else
            {
                oRegiao.DataCadastro = DateTime.Today;
                oRegiao.SalvarBD();
            }
                
            SalvarAlterar = '\0';
            Close();
        }
        private void chkBox(object sender, KeyEventArgs e)
        {
            CheckBox c1 = this.ActiveControl as CheckBox;
            if (e.KeyData == Keys.Enter && this.ActiveControl.Equals(c1))
                if(c1.Checked == false) c1.Checked = true;else c1.Checked = false;
        }
    }
}
