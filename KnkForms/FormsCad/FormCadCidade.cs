using KnkForms.Classes;
using KnkForms.FormsCon;
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

namespace KnkForms.Forms
{
    public partial class FormCadCidade : KnkForms.FormCadPai
    {
        Cidades aCidade;
        FormConEstado oFrmConEstados;
        public FormCadCidade()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(Object obj)
        {
            aCidade = (Cidades)obj;
        }

        public override void LimpaTxt()
        {
            txtCod.Clear();
            txtNomeCidade.Clear();
            txtDDD.Clear();
            txtCodEstado.Clear();
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
            chkAtivo.Checked = false;
        }

        public override void CarregaTxt()
        {
            txtCod.Text = Convert.ToString(aCidade.Cod);
            txtNomeCidade.Text = aCidade.NomeCidade;
            txtDDD.Text = Convert.ToString(aCidade.DDD);
            txtCodEstado.Text = Convert.ToString(aCidade.CodEstado);
            txtCodUser.Text = Convert.ToString(aCidade.CodEmpresa);
            txtDataCad.Text = Convert.ToString(aCidade.DataCadastro);
            txtDataAlt.Text = Convert.ToString(aCidade.DataModificacao);
            chkAtivo.Checked = aCidade.Ativo;
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtNomeCidade.Enabled = false;
            txtDDD.Enabled = false;
            txtCodEstado.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
            chkAtivo.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtNomeCidade.Enabled = true;
            txtDDD.Enabled = true;
            txtCodEstado.Enabled = true;
            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
            chkAtivo.Enabled = true;
        }

        public override void Salvar()
        {
            aCidade.Cod = Convert.ToInt32(txtCod.Text);
            aCidade.NomeCidade = txtNomeCidade.Text;
            aCidade.DDD = Convert.ToInt32(txtDDD.Text);
            aCidade.CodEstado = Convert.ToInt32(txtCodEstado.Text);
            aCidade.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            aCidade.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            aCidade.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);
            aCidade.Ativo = chkAtivo.Checked;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
        public void setFrmConEstados(Object obj)
        {
            oFrmConEstados = (FormConEstado)obj;
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            oFrmConEstados.ConhecaObj(aCidade.Estado);
            oFrmConEstados.ShowDialog();
        }
    }
}
