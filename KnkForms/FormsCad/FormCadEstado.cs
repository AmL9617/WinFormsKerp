using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KnkForms.FormsCon;

namespace KnkForms.Classes
{
    public partial class FormCadEstado : KnkForms.FormCadPai
    {
        Estados oEstado;
        FormConPaises oFrmConPaises;
        public FormCadEstado()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(Object obj)
        {
            oEstado = (Estados)obj;
        }

        public override void LimpaTxt()
        {
            txtCod.Clear();
            txtNomeEstado.Clear();
            txtSigla.Clear();
            txtCodPais.Clear();
            chkAtivo.Checked = false;
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
        }

        public override void CarregaTxt()
        {
            txtCod.Text = Convert.ToString(oEstado.Cod);
            txtNomeEstado.Text = oEstado.NomeEstado;
            txtSigla.Text = Convert.ToString(oEstado.Sigla);
            txtCodPais.Text = Convert.ToString(oEstado.CodPais);
            chkAtivo.Checked = oEstado.Ativo;
            txtCodUser.Text = Convert.ToString(oEstado.CodEmpresa);
            txtDataCad.Text = Convert.ToString(oEstado.DataCadastro);
            txtDataAlt.Text = Convert.ToString(oEstado.DataModificacao);
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtNomeEstado.Enabled = false;
            txtSigla.Enabled = false;
            txtCodPais.Enabled = false;
            chkAtivo.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtNomeEstado.Enabled = true;
            txtSigla.Enabled = true;
            txtCodPais.Enabled = true;
            txtCodUser.Enabled = true;
            chkAtivo.Enabled=true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
        }

        public override void Salvar()
        {
            oEstado.Cod = Convert.ToInt32(txtCod.Text);
            oEstado.NomeEstado = txtNomeEstado.Text;
            oEstado.Sigla = Convert.ToChar(txtSigla.Text);
            oEstado.CodPais = Convert.ToInt32(txtCodPais.Text);
            oEstado.Ativo = chkAtivo.Checked;
            oEstado.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            oEstado.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            oEstado.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        public void setFrmConPaises(Object obj)
        {
            oFrmConPaises = (FormConPaises)obj;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            oFrmConPaises.ConhecaObj(oEstado.Pais);
            oFrmConPaises.ShowDialog();
        }
    }
}
