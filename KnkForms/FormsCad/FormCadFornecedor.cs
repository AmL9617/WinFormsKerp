using KnkForms.Classes;
using KnkForms.FormsCon;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Windows.Forms;

namespace KnkForms.Forms
{
    public partial class FormCadFornecedor : KnkForms.FormCadPai
    {
        Fornecedores oFornecedor;
        FormConCidades oFrmConCidades;
        FormConRegioes oFrmConRegioes;
        FormConListaPrecos oFrmConListaPrecos;
        FormConCondicaoPagamentos oFrmCondicaoPagamentos;
        char SalvarAlterar = '\0';
        public FormCadFornecedor()
        {
            InitializeComponent();
            //Padronização das datas para dia/mês/ano
            dataUltMov.CustomFormat = "dd/MM/yyyy";
            dataUltMov.Format = DateTimePickerFormat.Custom;
        }

        public override void ConhecaObj(Object obj)
        {
            oFornecedor = (Fornecedores)obj;
        }

        public override void LimpaTxt()
        {
            txtCod.Clear();
            boxIndustria.SelectedIndex = -1; 
            boxFisJur.SelectedIndex = -1; 
            txtRazaoSocial.Clear();
            txtNomeFantasia.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCodCidade.Clear();
            txtNomeCidade.Clear();
            txtCep.Clear();
            txtCodRegiao.Clear();
            txtNomeRegiao.Clear();
            txtCodLista.Clear();
            txtNomeLista.Clear();
            txtCodCondPag.Clear();
            txtNomeCondPag.Clear();
            txtTrade.Clear();
            txtCodProd.Clear();
            txtLimite.Clear();
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

        public void CarregaTxt(string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string campo7, string campo8, string campo9, string campo10, string campo11, string campo12, string campo13, string campo14, string campo15, string campo16, string campo17, string campo18, string campo19, string campo20, string campo21, string campo22, string campo23, string campo24, string campo25)
        {
            txtCod.Text = campo1;
            txtCod.Enabled = false;
            txtRazaoSocial.Text = campo2;
            txtNomeFantasia.Text = campo3;
            txtInscEst.Text = campo4;
            if (campo6 == "A") chkVerCliente.Checked = true; else chkVerCliente.Checked = false;
            txtCnpj.Text = campo5;
            txtCodCidade.Text = campo7;
            txtCodRegiao.Text = campo8;
            txtEndereco.Text = campo9;
            txtNumero.Text = campo10;
            txtComplemento.Text = campo11;
            txtBairro.Text = campo12;
            txtCep.Text = campo13;       
            txtCodLista.Text = campo14;
            txtCodCondPag.Text = campo15;
            if (campo16 == "N") boxIndustria.Text = "Não"; else boxIndustria.Text = "Sim";
            txtObservacao.Text = campo17;
            txtTrade.Text = campo18;
            txtCodProd.Text = campo19;
            txtLimite.Text = campo20;
            if(campo21 == "N") chkAtivo.Checked = false; else chkAtivo.Checked = true;
            if (campo22 == "Fisica") boxFisJur.Text = "Fisica"; else boxFisJur.Text = "Juridica";    
            txtCodUser.Text = campo23;
            txtDataCad.Text = campo24;
            txtDataAlt.Text = campo25;
            SalvarAlterar = 'A';
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            boxIndustria.Enabled = false;
            boxFisJur.Enabled = false;
            txtRazaoSocial.Enabled = false;
            txtNomeFantasia.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            txtCodCidade.Enabled = false;
            txtCep.Enabled = false;
            txtCodRegiao.Enabled = false;
            txtCodLista.Enabled = false;
            txtCodCondPag.Enabled = false;
            txtTrade.Enabled = false;
            txtCodProd.Enabled = false;
            txtLimite.Enabled = false;
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
            boxIndustria.Enabled = true;
            boxFisJur.Enabled = true;
            txtRazaoSocial.Enabled = true;
            txtNomeFantasia.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            txtBairro.Enabled = true;
            txtCodCidade.Enabled = true;
            txtCep.Enabled = true;
            txtCodRegiao.Enabled = true;
            txtCodLista.Enabled = true;
            txtCodCondPag.Enabled = true;
            txtTrade.Enabled = true;
            txtCodProd.Enabled = true;
            txtLimite.Enabled = true;
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
            if (boxIndustria.Text == "Não")
                oFornecedor.Industria = "N";
            else if (boxIndustria.Text == "Sim")
                oFornecedor.Industria = "S";
            if (boxFisJur.Text == "Fisica")
                oFornecedor.FisicaJuridica = "F";
            else if (boxFisJur.Text == "Juridica")
                oFornecedor.FisicaJuridica = "J";
            oFornecedor.RazaoSocial = txtRazaoSocial.Text;
            oFornecedor.NomeFantasia = txtNomeFantasia.Text;
            oFornecedor.Endereco = txtEndereco.Text;
            oFornecedor.Numero = txtNumero.Text;
            oFornecedor.Complemento = txtComplemento.Text;
            oFornecedor.Bairro = txtBairro.Text;
            oFornecedor.CodCidades = Convert.ToInt32(txtCodCidade.Text);
            oFornecedor.NomeCidade = txtNomeCidade.Text;
            oFornecedor.Cep = txtCep.Text;
            oFornecedor.CodRegioes = Convert.ToInt32(txtCodRegiao.Text);
            oFornecedor.NomeRegiao = txtNomeRegiao.Text;
            oFornecedor.CodListaPrecos = Convert.ToInt32(txtCodLista.Text);
            oFornecedor.CodCondPag = Convert.ToInt32(txtCodCondPag.Text);
            oFornecedor.Trade = txtTrade.Text;
            oFornecedor.CodProdIgual = txtCodProd.Text;
            oFornecedor.LimiteCredito = Convert.ToDouble(txtLimite.Text);
            oFornecedor.InscricaoEstadual = txtInscEst.Text;
            oFornecedor.CNPJ = txtCnpj.Text;
            oFornecedor.UltimoMovimento = dataUltMov.Value;
            if (chkVerCliente.Checked == false)
                oFornecedor.VerEmClientes = "F";
            if (chkVerCliente.Checked == true)
                oFornecedor.VerEmClientes = "A";
            oFornecedor.Observacoes = txtObservacao.Text;
            if (chkAtivo.Checked == false)
                oFornecedor.Ativo = "N";
            if (chkAtivo.Checked == true)
                oFornecedor.Ativo = "S";
            oFornecedor.CodEmpresa = 1;
            oFornecedor.DataModificacao = DateTime.Now;

            if (SalvarAlterar == 'A')
            {
                oFornecedor.Cod = Convert.ToInt32(txtCod.Text);
                oFornecedor.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
                oFornecedor.AlterarBD(oFornecedor);
            }
            else
            {
                oFornecedor.DataCadastro = DateTime.Now;
                oFornecedor.SalvarBD(oFornecedor);
            }
            SalvarAlterar ='\0';

            txtCod.Enabled = true;
            Close();
        }

        private void chkBox(object sender, KeyEventArgs e)
        {
            CheckBox c1 = this.ActiveControl as CheckBox;
            if (e.KeyData == Keys.Enter && this.ActiveControl.Equals(c1))
                if (c1.Checked == false) c1.Checked = true; else c1.Checked = false;
        }
        public void SetConsultas(int id, string nome, string tipo)
        {
            if(tipo == "Cidade")
            {
                txtCodCidade.Text = Convert.ToString(id);
                txtNomeCidade.Text = nome;
            }
            else if (tipo == "Regiao")
            {
                txtCodRegiao.Text = Convert.ToString(id);
                txtNomeRegiao.Text = nome;
            }
            else if (tipo == "ListaPreco")
            {
                txtCodLista.Text = Convert.ToString(id);
                txtNomeLista.Text = nome;
            }
            else if (tipo == "CondPag")
            {
                txtCodCondPag.Text = Convert.ToString(id);
                txtNomeCondPag.Text = nome;
            }
        }


        public void setFrmConCidades(Object obj)
        {
            oFrmConCidades = (FormConCidades)obj;
        }
        public void setFrmConRegioes(Object obj)
        {
            oFrmConRegioes = (FormConRegioes)obj;
        }
        public void setFrmConListaPrecos(Object obj)
        {
            oFrmConListaPrecos = (FormConListaPrecos)obj;
        }
        public void setFrmConCondPagamentos(Object obj)
        {
            oFrmCondicaoPagamentos = (FormConCondicaoPagamentos)obj;
        }
       
        private void btnConsultaReg_Click(object sender, EventArgs e)
        {
            oFrmConRegioes.ConhecaObj(oFornecedor.Regioes);
            oFrmConRegioes.Owner = this;
            oFrmConRegioes.ShowDialog();
        }

        private void btnConsultaCid_Click(object sender, EventArgs e)
        {
            oFrmConCidades.ConhecaObj(oFornecedor.Cidades);
            oFrmConCidades.Owner = this;
            oFrmConCidades.ShowDialog();
        }

        private void btnConsultaLista_Click(object sender, EventArgs e)
        {
            oFrmConListaPrecos.ConhecaObj(oFornecedor.ListaPrecos);
            oFrmConListaPrecos.Owner = this;
            oFrmConListaPrecos.ShowDialog();
        }

        private void btnCondPag_Click(object sender, EventArgs e)
        {
            oFrmCondicaoPagamentos.ConhecaObj(oFornecedor.CondicaoPagamentos);
            oFrmCondicaoPagamentos.Owner = this;
            oFrmCondicaoPagamentos.ShowDialog();
        }
    }
}
