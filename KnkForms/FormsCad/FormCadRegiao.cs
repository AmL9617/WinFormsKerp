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
    public partial class FormCadRegiao : KnkForms.FormCadPai
    {
        Regioes oRegiao;
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
            txtNomeRegiao.Clear();
            chkAtivo.Checked = false;
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
        }

        public override void CarregaTxt()
        {
            txtCod.Text = Convert.ToString(oRegiao.Cod);
            txtNomeRegiao.Text = oRegiao.NomeRegiao;
            chkAtivo.Checked = oRegiao.Ativo;
            txtCodUser.Text = Convert.ToString(oRegiao.CodEmpresa);
            txtDataCad.Text = Convert.ToString(oRegiao.DataCadastro);
            txtDataAlt.Text = Convert.ToString(oRegiao.DataModificacao);
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtNomeRegiao.Enabled = false;
            chkAtivo.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtNomeRegiao.Enabled = true;
            chkAtivo.Enabled = true;
            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
        }

        public override void Salvar()
        {
            oRegiao.Cod = Convert.ToInt32(txtCod.Text);
            oRegiao.NomeRegiao = txtNomeRegiao.Text;
            oRegiao.Ativo = chkAtivo.Checked;
            oRegiao.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            oRegiao.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            oRegiao.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);
        }
    }
}
