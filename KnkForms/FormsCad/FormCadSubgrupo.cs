using KnkForms.Classes;
using KnkForms.FormsCon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KnkForms.FormsCad
{
    public partial class FormCadSubgrupo : KnkForms.FormCadPai
    {
        Subgrupos oSubgrupo;
        FormConGrupos oFrmConGrupos;
        public FormCadSubgrupo()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(Object obj)
        {
            oSubgrupo = (Subgrupos)obj;
        }

        public override void LimpaTxt()
        {
            txtCod.Clear();
            txtGrupo.Clear();
            txtSubgrupo.Clear();
            chkAtivo.Checked = false;
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
        }

        public override void CarregaTxt()
        {
            txtCod.Text = Convert.ToString(oSubgrupo.Cod);
            txtCod.Enabled = false;
            txtGrupo.Text = Convert.ToString(oSubgrupo.Grupos.Cod);
            txtSubgrupo.Text = oSubgrupo.Subgrupo;
            if (chkAtivo.Checked == true) { oSubgrupo.Ativo = 'S'; } else { oSubgrupo.Ativo = 'N'; };
            txtCodUser.Text = Convert.ToString(oSubgrupo.CodEmpresa);
            txtDataCad.Text = Convert.ToString(oSubgrupo.DataCadastro);
            txtDataAlt.Text = Convert.ToString(oSubgrupo.DataModificacao);
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtGrupo.Enabled = false;
            txtSubgrupo.Enabled = false;
            chkAtivo.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtGrupo.Enabled = true;
            txtSubgrupo.Enabled = true;
            chkAtivo.Enabled = true;
            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
        }

        public override void Salvar()
        {
            oSubgrupo.Cod = Convert.ToInt32(txtCod.Text);
            oSubgrupo.Grupos.Cod = Convert.ToInt32(txtGrupo.Text);
            oSubgrupo.Subgrupo = txtSubgrupo.Text;
            if (chkAtivo.Checked == true) { oSubgrupo.Ativo = 'S'; } else { oSubgrupo.Ativo = 'N'; };
            oSubgrupo.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            oSubgrupo.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            oSubgrupo.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);

            txtCod.Enabled = true;
        }
        private void chkBox(object sender, KeyEventArgs e)
        {
            CheckBox c1 = this.ActiveControl as CheckBox;
            if (e.KeyData == Keys.Enter && this.ActiveControl.Equals(c1))
                if (c1.Checked == false) c1.Checked = true; else c1.Checked = false;
        }
        public void setFrmConGrupos(Object obj)
        {
            oFrmConGrupos = (FormConGrupos)obj;
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            oFrmConGrupos.ConhecaObj(oSubgrupo.Grupos);
            oFrmConGrupos.ShowDialog();
        }
    }
}
