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
            txtNomeGrupo.Clear();
            chkAtivo.Checked = false;
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
        }

        public override void CarregaTxt()
        {
            txtCod.Text = Convert.ToString(oGrupo.Cod);
            txtNomeGrupo.Text = oGrupo.NomeGrupo;
            chkAtivo.Checked = oGrupo.Ativo;
            txtCodUser.Text = Convert.ToString(oGrupo.CodEmpresa);
            txtDataCad.Text = Convert.ToString(oGrupo.DataCadastro);
            txtDataAlt.Text = Convert.ToString(oGrupo.DataModificacao);
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtNomeGrupo.Enabled = false;
            chkAtivo.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtNomeGrupo.Enabled = true;
            chkAtivo.Enabled = true;
            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
        }

        public override void Salvar()
        {
            oGrupo.Cod = Convert.ToInt32(txtCod.Text);
            oGrupo.NomeGrupo = txtNomeGrupo.Text;
            oGrupo.Ativo = chkAtivo.Checked;
            oGrupo.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            oGrupo.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            oGrupo.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);
        }
    }
}
