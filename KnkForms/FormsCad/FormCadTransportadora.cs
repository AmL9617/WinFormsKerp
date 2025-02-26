﻿using KnkForms.FormsCon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KnkForms.Classes
{
    public partial class FormCadTransportadora : KnkForms.FormCadPai
    {
        Transportadoras aTransportadora;
        FormConRegioes oFrmConRegioes;
        //FormConContatos oFrmConContatos;
        public FormCadTransportadora()
        {
            InitializeComponent();
            //Padronização das datas para dia/mês/ano
            dataUltCompra.CustomFormat = "dd/MM/yyyy";
            dataUltCompra.Format = DateTimePickerFormat.Custom;
        }
        public override void ConhecaObj(Object obj)
        {
            aTransportadora = (Transportadoras)obj;
        }
        private void chkBox(object sender, KeyEventArgs e)
        {
            CheckBox c1 = this.ActiveControl as CheckBox;
            if (e.KeyData == Keys.Enter && this.ActiveControl.Equals(c1))
                if (c1.Checked == false) c1.Checked = true; else c1.Checked = false;
        }
        public override void LimpaTxt()
        {
            txtCod.Clear();
            boxTransCli.Text = "";
            boxFisJur.Text = "";
            txtNomeFantasia.Clear();
            chkAtivo.Checked = false;
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCep.Clear();
            txtTelefone.Clear();
            txtFax.Clear();
            txtCelular.Clear();
            txtContato.Clear();
            txtWebsite.Clear();
            txtEmail.Clear();
            txtCnpj.Clear();
            txtInscEst.Clear();
            dataUltCompra.Value = DateTime.Today;
            txtObservacao.Clear();
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
        }

        public override void CarregaTxt()
        {
            txtCod.Text = Convert.ToString(aTransportadora.Cod);
            txtCod.Enabled = false;
            boxTransCli.Text = aTransportadora.TransportadoraCliente;
            if (aTransportadora.FisicaJuridica == 'F')
                boxFisJur.Text = "Fisica";
            else if (aTransportadora.FisicaJuridica == 'J')
                boxFisJur.Text = "Juridica";
            txtNomeFantasia.Text = aTransportadora.NomeFantasia;
            if (chkAtivo.Checked == true) { aTransportadora.Ativo = 'S'; } else { aTransportadora.Ativo = 'N'; };
            txtEndereco.Text = aTransportadora.Endereco;
            txtNumero.Text = Convert.ToString(aTransportadora.Numero);
            txtComplemento.Text = aTransportadora.Complemento;
            txtBairro.Text = aTransportadora.Bairro;
            txtCep.Text = aTransportadora.Cep;
            txtTelefone.Text = aTransportadora.Telefone;
            txtFax.Text = aTransportadora.Fax;
            txtCelular.Text = aTransportadora.Celular;
            //txtContato.Text = Convert.ToString(aTransportadora.CodContatos);
            txtWebsite.Text = aTransportadora.Website;
            txtEmail.Text = aTransportadora.Email;
            txtCnpj.Text = aTransportadora.CNPJ;
            txtInscEst.Text = aTransportadora.InscricaoEstadual;
            dataUltCompra.Value = aTransportadora.UltimaCompra;
            txtObservacao.Text = aTransportadora.Observacao; 
            txtCodUser.Text = Convert.ToString(aTransportadora.CodEmpresa);
            txtDataCad.Text = Convert.ToString(aTransportadora.DataCadastro);
            txtDataAlt.Text = Convert.ToString(aTransportadora.DataModificacao);
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            boxTransCli.Enabled = false;
            boxFisJur.Enabled = false;
            txtNomeFantasia.Enabled = false;
            chkAtivo.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            txtCep.Enabled = false;
            txtTelefone.Enabled = false;
            txtFax.Enabled = false;
            txtCelular.Enabled = false;
            txtContato.Enabled = false;
            txtWebsite.Enabled = false;
            txtEmail.Enabled = false;
            txtCnpj.Enabled = false;
            txtInscEst.Enabled = false;
            dataUltCompra.Enabled = false;
            txtObservacao.Enabled = false; 
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            boxTransCli.Enabled = true;
            boxFisJur.Enabled = true;
            txtNomeFantasia.Enabled = true;
            chkAtivo.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            txtBairro.Enabled = true;
            txtCep.Enabled = true;
            txtTelefone.Enabled = true;
            txtFax.Enabled = true;
            txtCelular.Enabled = true;
            txtContato.Enabled = true;
            txtWebsite.Enabled = true;
            txtEmail.Enabled = true;
            txtCnpj.Enabled = true;
            txtInscEst.Enabled = true;
            dataUltCompra.Enabled = true;
            txtObservacao.Enabled = true;
            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
        }

        public override void Salvar()
        {
            aTransportadora.Cod = Convert.ToInt32(txtCod.Text);
            aTransportadora.TransportadoraCliente = boxTransCli.Text;
            if (boxFisJur.Text == "Fisica")
                aTransportadora.FisicaJuridica = 'F';
            else if (boxFisJur.Text == "Juridica")
                aTransportadora.FisicaJuridica = 'J';
            aTransportadora.NomeFantasia = txtNomeFantasia.Text;
            if (chkAtivo.Checked == true) { aTransportadora.Ativo = 'S'; } else { aTransportadora.Ativo = 'N'; };
            aTransportadora.Endereco = txtEndereco.Text;
            aTransportadora.Numero = Convert.ToInt32(txtNumero.Text);
            aTransportadora.Complemento = txtComplemento.Text;
            aTransportadora.Bairro = txtBairro.Text;
            aTransportadora.Cep = txtCep.Text;
            txtTelefone.Text = aTransportadora.Telefone;
            aTransportadora.Fax = txtFax.Text;
            aTransportadora.Celular = txtCelular.Text;
            //aTransportadora.CodContatos = Convert.ToInt32(txtContato.Text);
            aTransportadora.Website = txtWebsite.Text;
            aTransportadora.Email = txtEmail.Text;
            aTransportadora.CNPJ = txtCnpj.Text;
            aTransportadora.InscricaoEstadual = txtInscEst.Text;
            aTransportadora.UltimaCompra = dataUltCompra.Value;
            aTransportadora.Observacao = txtObservacao.Text;
            aTransportadora.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            aTransportadora.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            aTransportadora.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);

            txtCod.Enabled = true;
        }
        public void setFrmConRegioes(Object obj)
        {
            oFrmConRegioes = (FormConRegioes)obj;
        }

        private void btnConsultaReg_Click(object sender, EventArgs e)
        {
            oFrmConRegioes.ConhecaObj(aTransportadora.Regioes);
            oFrmConRegioes.ShowDialog();
        }
        /*
public void setFrmConContatos(Object obj)
{
   oFrmConContatos = (FormConContatos)obj;
}
private void btnPesquisarContato_Click(object sender, EventArgs e)
{
   oFrmConContatos.ConhecaObj(aTransportadora.Contatos);
   oFrmConContatos.ShowDialog();
}*/
    }
}
