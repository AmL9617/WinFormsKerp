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
    public partial class FormCadFornecedor : KnkForms.FormCadPai
    {
        Fornecedores oFornecedor;
        public FormCadFornecedor()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(Object obj)
        {
            oFornecedor = (Fornecedores)obj;
        }

        public override void LimpaTxt()
        {
            txtCod.Clear();
            txtIndustria.Clear();
            txtRazaoSocial.Clear();
            txtNomeFantasia.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCep.Clear();
            txtTrade.Clear();
            txtCodProd.Clear();
            txtLimite.Clear();
            txtTipoCont.Clear();
            txtInscEst.Clear();
            txtCnpj.Clear();
            dataUltMov.Value = DateTime.Today;
            chkVerCliente.Checked = false;
            txtObservacao.Clear();
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
            chkAtivo.Checked = false;
        }

        public override void CarregaTxt()
        {
            txtCod.Text = Convert.ToString(oFornecedor.Cod);
            txtIndustria.Text = oFornecedor.Industria;
            txtRazaoSocial.Text = oFornecedor.RazaoSocial;
            txtNomeFantasia.Text = Convert.ToString(oFornecedor.NomeFantasia);
            txtEndereco.Text = oFornecedor.Endereco;
            txtNumero.Text = Convert.ToString(oFornecedor.Numero);
            txtComplemento.Text = oFornecedor.Complemento;
            txtBairro.Text = oFornecedor.Bairro;
            txtCep.Text = oFornecedor.Cep;
            txtTrade.Text = oFornecedor.Trade;
            txtCodProd.Text = Convert.ToString(oFornecedor.CodProdIgual);
            txtLimite.Text = Convert.ToString(oFornecedor.LimiteCredito);
            txtTipoCont.Text = oFornecedor.TipoContato;
            txtInscEst.Text = oFornecedor.InscricaoEstadual;
            txtCnpj.Text = oFornecedor.CNPJ;
            dataUltMov.Value = oFornecedor.UltimoMovimento;
            chkVerCliente.Checked = oFornecedor.VerEmClientes;
            txtObservacao.Text = oFornecedor.Observacao;
            chkAtivo.Checked = oFornecedor.Ativo;
            txtCodUser.Text = Convert.ToString(oFornecedor.CodEmpresa);
            txtDataCad.Text = Convert.ToString(oFornecedor.DataCadastro);
            txtDataAlt.Text = Convert.ToString(oFornecedor.DataModificacao);
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtIndustria.Enabled = false;
            txtRazaoSocial.Enabled = false;
            txtNomeFantasia.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            txtCep.Enabled = false;
            txtTrade.Enabled = false;
            txtCodProd.Enabled = false;
            txtLimite.Enabled = false;
            txtTipoCont.Enabled = false;
            txtInscEst.Enabled = false;
            txtCnpj.Enabled = false;
            dataUltMov.Enabled = false;
            chkVerCliente.Checked = false;
            txtObservacao.Enabled = false;
            chkAtivo.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtIndustria.Enabled = true;
            txtRazaoSocial.Enabled = true;
            txtNomeFantasia.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            txtBairro.Enabled = true;
            txtCep.Enabled = true;
            txtTrade.Enabled = true;
            txtCodProd.Enabled = true;
            txtLimite.Enabled = true;
            txtTipoCont.Enabled = true;
            txtInscEst.Enabled = true;
            txtCnpj.Enabled = true;
            dataUltMov.Enabled = true;
            chkVerCliente.Enabled = true;
            txtObservacao.Enabled = true;
            chkAtivo .Enabled = true;
            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
        }

        public override void Salvar()
        {
            oFornecedor.Cod = Convert.ToInt32(txtCod.Text);
            oFornecedor.Industria = txtIndustria.Text;
            oFornecedor.RazaoSocial = txtRazaoSocial.Text;
            oFornecedor.NomeFantasia = txtNomeFantasia.Text;
            oFornecedor.Endereco = txtEndereco.Text;
            oFornecedor.Numero = Convert.ToInt32(txtNumero);
            oFornecedor.Complemento = txtComplemento.Text;
            oFornecedor.Bairro = txtBairro.Text;
            oFornecedor.Cep = txtCep.Text;
            oFornecedor.Trade = txtTrade.Text;
            oFornecedor.CodProdIgual = Convert.ToInt32(txtCodProd);
            oFornecedor.LimiteCredito = Convert.ToDouble(txtLimite);
            oFornecedor.TipoContato = txtContato.Text;
            oFornecedor.InscricaoEstadual = txtInscEst.Text;
            oFornecedor.CNPJ = txtCnpj.Text;
            oFornecedor.UltimoMovimento = dataUltMov.Value;
            oFornecedor.VerEmClientes = chkAtivo.Checked;
            oFornecedor.Observacao = txtObservacao.Text;
            oFornecedor.Ativo = chkAtivo.Checked;
            oFornecedor.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            oFornecedor.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            oFornecedor.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);
        }
    }
}
