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
            txtRegiao.Clear();
            chkAtivo.Checked = false;
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
            txtDescricao.Clear();
        }

        public override void CarregaTxt()
        {
            txtCod.Text = Convert.ToString(oRegiao.Cod);
            txtRegiao.Text = oRegiao.Regiao;
            chkAtivo.Checked = oRegiao.Ativo;
            txtCodUser.Text = Convert.ToString(oRegiao.CodEmpresa);
            txtDataCad.Text = Convert.ToString(oRegiao.DataCadastro);
            txtDataAlt.Text = Convert.ToString(oRegiao.DataModificacao);
            txtDescricao.Text = oRegiao.Descricao;
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
            oRegiao.Cod = Convert.ToInt32(txtCod.Text);
            oRegiao.Regiao = txtRegiao.Text;
            oRegiao.Ativo = chkAtivo.Checked;
            oRegiao.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            oRegiao.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            oRegiao.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);
            oRegiao.Descricao = txtDescricao.Text;
        }
    }
}
