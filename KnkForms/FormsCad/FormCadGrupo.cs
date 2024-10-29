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
    public partial class FormCadGrupo : KnkForms.FormCadPai
    {
        Grupos oGrupo;
        public FormCadGrupo()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(Object obj)
        {
            oGrupo = (Grupos)obj;
        }

        public override void LimpaTxt()
        {
            txtCod.Clear();
            txtGrupo.Clear();
            chkAtivo.Checked = false;
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
        }

        public override void CarregaTxt()
        {
            txtCod.Text = Convert.ToString(oGrupo.Cod);
            txtGrupo.Text = oGrupo.Grupo;
            if (chkAtivo.Checked == true) { oGrupo.Ativo = 'S'; } else { oGrupo.Ativo = 'N'; };
            txtCodUser.Text = Convert.ToString(oGrupo.CodEmpresa);
            txtDataCad.Text = Convert.ToString(oGrupo.DataCadastro);
            txtDataAlt.Text = Convert.ToString(oGrupo.DataModificacao);
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtGrupo.Enabled = false;
            chkAtivo.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtGrupo.Enabled = true;
            chkAtivo.Enabled = true;
            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
        }

        public override void Salvar()
        {
            oGrupo.Cod = Convert.ToInt32(txtCod.Text);
            oGrupo.Grupo = txtGrupo.Text;
            if (chkAtivo.Checked == true) { oGrupo.Ativo = 'S'; } else { oGrupo.Ativo = 'N'; };
            oGrupo.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            oGrupo.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            oGrupo.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);
        }
    }
}
