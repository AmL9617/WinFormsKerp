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
    public partial class FormCadRamoAtividade : KnkForms.FormCadPai
    {
        RamoAtividades oRamo;
        char SalvarAlterar = '\0';
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

        public void CarregaTxt(string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            txtCod.Text = campo1;
            txtNomeRamo.Text = campo2;
            if (campo3 == "S") chkAtivo.Checked = true; else chkAtivo.Checked = false;
            txtCodUser.Text = campo4;
            txtDataCad.Text = campo5;
            txtDataAlt.Text = campo6;
            SalvarAlterar = 'A';
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
            oRamo.Ramo = txtNomeRamo.Text;
            if (chkAtivo.Checked == true) { oRamo.Ativo = "S"; } else { oRamo.Ativo = "N"; }; 
            oRamo.CodEmpresa = 1;
            oRamo.DataModificacao = DateTime.Now;

            if (SalvarAlterar == 'A')
            {
                oRamo.Cod = Convert.ToInt32(txtCod.Text);
                oRamo.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
                oRamo.AlterarBD(oRamo);
            }
            else
            {
                oRamo.DataCadastro = DateTime.Today;
                oRamo.SalvarBD(oRamo);
            }

            SalvarAlterar = '\0';
            Close();
        }
    }
}
