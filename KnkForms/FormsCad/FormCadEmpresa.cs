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
    public partial class FormCadEmpresa : KnkForms.FormCadPai
    {
        Empresas aEmpresa;
        public FormCadEmpresa()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(Object obj)
        {
            aEmpresa = (Empresas)obj;
        }

        public override void LimpaTxt()
        {
            txtCod.Clear();
            txtRazaoSocial.Clear();
            txtNomeFant.Clear();
            txtCnpj.Clear();
            txtCep.Clear();
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
        }

        public override void CarregaTxt()
        {
            txtCod.Text = Convert.ToString(aEmpresa.Cod);
            txtRazaoSocial.Text = aEmpresa.RazaoSocial;
            txtNomeFant.Text = aEmpresa.NomeFantasia;
            txtCnpj.Text = aEmpresa.Cnpj;
            txtCep.Text = aEmpresa.Cep;
            txtCodUser.Text = Convert.ToString(aEmpresa.CodEmpresa);
            txtDataCad.Text = Convert.ToString(aEmpresa.DataCadastro);
            txtDataAlt.Text = Convert.ToString(aEmpresa.DataModificacao);
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtRazaoSocial.Enabled = false;
            txtNomeFant.Enabled = false;
            txtCnpj.Enabled = false;
            txtCep.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtRazaoSocial.Enabled = true;
            txtNomeFant.Enabled = true;
            txtCnpj.Enabled = true;
            txtCep.Enabled = true;
            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
        }

        public override void Salvar()
        {
            aEmpresa.Cod = Convert.ToInt32(txtCod.Text);
            aEmpresa.RazaoSocial = txtRazaoSocial.Text;
            aEmpresa.NomeFantasia = txtNomeFant.Text;
            aEmpresa.Cnpj = txtCnpj.Text;
            aEmpresa.Cep = txtCep.Text;
            aEmpresa.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            aEmpresa.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            aEmpresa.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);
        }
    }
}
