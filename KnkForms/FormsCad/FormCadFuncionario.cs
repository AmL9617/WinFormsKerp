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
    public partial class FormCadFuncionario : KnkForms.FormCadPai
    {
        Funcionarios oFuncionario;
        FormConRegioes oFrmConRegioes;
        public FormCadFuncionario()
        {
            InitializeComponent();
            //Padronização das datas para dia/mês/ano
            dataAdmissao.CustomFormat = "dd/MM/yyyy";
            dataAdmissao.Format = DateTimePickerFormat.Custom;
            dataDemissao.CustomFormat = "dd/MM/yyyy";
            dataDemissao.Format = DateTimePickerFormat.Custom;
            dataNascimento.CustomFormat = "dd/MM/yyyy";
            dataNascimento.Format = DateTimePickerFormat.Custom;
        }
        public override void ConhecaObj(Object obj)
        {
            oFuncionario = (Funcionarios)obj;
        }

        public override void LimpaTxt()
        {
            txtCod.Clear();
            txtFuncionario.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            chkAtivo.Checked = false;
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCep.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtEmail.Clear();
            txtSalario.Clear();
            dataAdmissao.Value = DateTime.Today;
            dataDemissao.Value = DateTime.Today;
            dataNascimento.Value = DateTime.Today;
            txtSexo.Clear();
            txtRg.Clear();
            txtCpf.Clear();
            txtObservacao.Clear();
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
        }

        public override void CarregaTxt()
        {
            txtCod.Text = Convert.ToString(oFuncionario.Cod);
            txtFuncionario.Text = oFuncionario.Funcionario;
            txtEndereco.Text = oFuncionario.Endereco;
            txtNumero.Text = Convert.ToString(oFuncionario.Numero);
            chkAtivo.Checked = oFuncionario.Ativo;
            txtComplemento.Text = oFuncionario.Complemento;
            txtBairro.Text = oFuncionario.Bairro;
            txtCep.Text = oFuncionario.Cep;
            txtTelefone.Text = oFuncionario.Telefone;
            txtCelular.Text = oFuncionario.Celular;
            txtEmail.Text = oFuncionario.Email;
            txtSalario.Text = Convert.ToString(oFuncionario.Salario);
            dataAdmissao.Value = oFuncionario.DataAdmissao;
            dataDemissao.Value = oFuncionario.DataDemissao;
            dataNascimento.Value = oFuncionario.DataNascimento;
            txtSexo.Text = oFuncionario.Sexo;
            txtRg.Text = oFuncionario.Rg;
            txtCpf.Text = oFuncionario.Cpf;
            txtObservacao.Text = oFuncionario.Observacoes;

            txtCodUser.Text = Convert.ToString(oFuncionario.CodEmpresa);
            txtDataCad.Text = Convert.ToString(oFuncionario.DataCadastro);
            txtDataAlt.Text = Convert.ToString(oFuncionario.DataModificacao);
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtFuncionario.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            chkAtivo.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            txtCep.Enabled = false;
            txtTelefone.Enabled = false;
            txtCelular.Enabled = false;
            txtEmail.Enabled = false;
            txtSalario.Enabled = false;
            dataAdmissao.Enabled = false;
            dataDemissao.Enabled = false;
            dataNascimento.Enabled = false;
            txtSexo.Enabled = false;
            txtRg.Enabled = false;
            txtCpf.Enabled = false;
            txtObservacao.Enabled = false;

            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtFuncionario.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            chkAtivo.Enabled = true;
            txtComplemento.Enabled = true;
            txtBairro.Enabled = true;
            txtCep.Enabled = true;
            txtTelefone.Enabled = true;
            txtCelular.Enabled = true;
            txtEmail.Enabled = true;
            txtSalario.Enabled = true;
            dataAdmissao.Enabled = true;
            dataDemissao.Enabled = true;
            dataNascimento.Enabled = true;
            txtSexo.Enabled = true;
            txtRg.Enabled = true;
            txtCpf.Enabled = true;
            txtObservacao.Enabled = true;

            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
        }

        public override void Salvar()
        {
            oFuncionario.Cod = Convert.ToInt32(txtCod.Text);
            oFuncionario.Funcionario = txtFuncionario.Text;
            oFuncionario.Endereco = txtEndereco.Text;
            oFuncionario.Numero = Convert.ToInt32(txtNumero.Text);
            oFuncionario.Ativo = chkAtivo.Checked;
            oFuncionario.Complemento = txtComplemento.Text;
            oFuncionario.Bairro = txtBairro.Text;
            oFuncionario.Cep = txtCep.Text;
            oFuncionario.Telefone = txtTelefone.Text;
            oFuncionario.Celular = txtCelular.Text;
            oFuncionario.Email = txtEmail.Text;
            oFuncionario.Salario = Convert.ToDouble(txtSalario.Text);
            oFuncionario.DataAdmissao = dataAdmissao.Value;
            oFuncionario.DataDemissao = dataDemissao.Value;
            oFuncionario.DataNascimento = dataNascimento.Value;
            oFuncionario.Sexo = txtSexo.Text;
            oFuncionario.Rg = txtRg.Text;
            oFuncionario.Cpf = txtCpf.Text;
            oFuncionario.Observacoes = txtObservacao.Text;
            oFuncionario.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            oFuncionario.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            oFuncionario.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);
        }

        public void setFrmConRegioes(Object obj)
        {
            oFrmConRegioes = (FormConRegioes)obj;
        }

        private void btnConsultaReg_Click(object sender, EventArgs e)
        {
            oFrmConRegioes.ConhecaObj(oFuncionario.Regioes);
            oFrmConRegioes.ShowDialog();
        }
    }
}
