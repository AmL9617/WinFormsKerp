using KnkForms.Classes;
using KnkForms.FormsCon;
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
        FormConCidades oFrmConCidades;
        FormConRegioes oFrmConRegioes;
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
            txtCodRegiao.Clear();
            txtCodCidade.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
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
            txtCodCidade.Text = Convert.ToString(aEmpresa.CodCidades);
            txtCodRegiao.Text = Convert.ToString(aEmpresa.CodRegioes);
            txtEndereco.Text = aEmpresa.Endereco;
            txtNumero.Text = Convert.ToString(aEmpresa.Numero);
            txtComplemento.Text = aEmpresa.Complemento;
            txtBairro.Text = aEmpresa.Bairro;
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
            txtCodRegiao.Enabled = false;
            txtCodCidade.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
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
            txtCodRegiao.Enabled = true;
            txtCodCidade.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            txtBairro.Enabled = true;
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
            aEmpresa.CodCidades = Convert.ToInt32(txtCodCidade.Text);
            aEmpresa.CodRegioes = Convert.ToInt32(txtCodRegiao.Text);
            aEmpresa.Endereco = txtEndereco.Text;
            aEmpresa.Numero = Convert.ToInt32(txtNumero.Text);
            aEmpresa.Complemento = txtComplemento.Text;
            aEmpresa.Bairro = txtBairro.Text;
            aEmpresa.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            aEmpresa.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            aEmpresa.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);

            aEmpresa.SalvarBD();
        }
        public void setFrmConCidades(Object obj)
        {
            oFrmConCidades = (FormConCidades)obj;
        }
        public void setFrmConRegioes(Object obj)
        {
            oFrmConRegioes = (FormConRegioes)obj;
        }
        private void btnConsultaCid_Click(object sender, EventArgs e)
        {
            oFrmConCidades.ConhecaObj(aEmpresa.Cidades);
            oFrmConCidades.ShowDialog();
        }

        private void btnConsultaReg_Click(object sender, EventArgs e)
        {
            oFrmConRegioes.ConhecaObj(aEmpresa.Regioes);
            oFrmConRegioes.ShowDialog();
        }
    }
}
