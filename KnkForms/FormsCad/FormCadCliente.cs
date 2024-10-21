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
    public partial class FormCadCliente : KnkForms.FormCadPai
    {
        Clientes oCliente;

        FormConCidades oFrmConCidades;
        FormConListaPrecos oFrmConListaPrecos;
        FormConCondicaoPagamentos oFrmConCondPag;
        FormConRegioes oFrmConRegioes;
        FormConVendedores oFrmConVendedores;
        FormConTransportadoras oFrmConTransportadoras;
        public FormCadCliente()
        {
            InitializeComponent();

            //Padronização das datas para dia/mês/ano
            dataFundacao.CustomFormat = "dd/MM/yyyy";
            dataFundacao.Format = DateTimePickerFormat.Custom;
            dataCad.CustomFormat = "dd/MM/yyyy";
            dataCad.Format = DateTimePickerFormat.Custom;
            dataUltAlt.CustomFormat = "dd/MM/yyyy";
            dataUltAlt.Format = DateTimePickerFormat.Custom;
            dataUltComp.CustomFormat = "dd/MM/yyyy";
            dataUltComp.Format = DateTimePickerFormat.Custom;
        }
        public override void ConhecaObj(Object obj)
        {
            oCliente = (Clientes)obj;
        }

        public override void LimpaTxt()
        {
            txtCod.Clear();
            txtCliente.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCep.Clear();
            boxFisJur.Text = "";
            txtCodCidade.Clear();
            chkAtivo.Checked = false;

            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();

            chkConsRev.Checked = false;
            txtInscEst.Clear();
            txtSuframa.Clear();
            txtCnpj.Clear();
            chkReg.Checked = false;
            chkProdRur.Checked = false;
            dataFundacao.Value = DateTime.Today;

            txtIdListPrec.Clear();
            txtIdCondPag.Clear();
            txtIdReg.Clear();
            txtIdVend.Clear();
            txtPessoasAut.Clear();
            chkVerForn.Checked = false;

            txtIdRamoAtiv.Clear();

            txtTransp.Clear();

            dataCad.Value = DateTime.Today;
            dataUltAlt.Value = DateTime.Today;
            dataUltComp.Value = DateTime.Today;
            txtObsDiv.Clear();
        }

        public override void CarregaTxt()
        {
            txtCod.Text = Convert.ToString(oCliente.Cod);
            txtCliente.Text = oCliente.Cliente;
            txtEndereco.Text = oCliente.Endereco; 
            txtNumero.Text = Convert.ToString(oCliente.Numero);
            txtComplemento.Text = oCliente.Complemento;
            txtBairro.Text = oCliente.Bairro;
            txtCep.Text = oCliente.Cep;
            if (oCliente.FisicaJuridica == false)
                boxFisJur.Text = "Fisica";
            else if (oCliente.FisicaJuridica == true)
                boxFisJur.Text = "Juridica";
            txtCodCidade.Text = Convert.ToString(oCliente.CodCidades);
            chkAtivo.Checked = oCliente.Ativo;

            txtCodUser.Text = Convert.ToString(oCliente.CodEmpresa);
            txtDataCad.Text = Convert.ToString(oCliente.DataCadastro);
            txtDataAlt.Text = Convert.ToString(oCliente.DataModificacao);

            chkConsRev.Checked = oCliente.ConsumidorRevenda;
            txtInscEst.Text = oCliente.InscricaoEstadual;
            txtSuframa.Text = oCliente.InscMunicipalSuframa;
            txtCnpj.Text = oCliente.CNPJ;
            chkReg.Checked = oCliente.RegimeSemSt;
            chkProdRur.Checked = oCliente.ProdutorRural;
            dataFundacao.Value = oCliente.DataFundacao;

            txtIdListPrec.Text = Convert.ToString(oCliente.CodListaPrecos);
            txtIdCondPag.Text = Convert.ToString(oCliente.CodCondicaoPagamentos);
            txtIdReg.Text = Convert.ToString(oCliente.CodRegioes);
            txtIdVend.Text = Convert.ToString(oCliente.CodVendedores);
            txtPessoasAut.Text = Convert.ToString(oCliente.PessoasAutorizadas);
            chkVerForn.Checked = oCliente.VerEmFornecedores;

            txtIdRamoAtiv.Text = Convert.ToString(oCliente.CodRamoAtividades);

            txtTransp.Text = Convert.ToString(oCliente.CodTransportadoras);

            dataCad.Value = oCliente.DataCad2;
            dataUltAlt.Value = oCliente.DataUltAlt2;
            dataUltComp.Value = oCliente.UltimaCompra;
            txtObsDiv.Text = oCliente.ObsDiv;
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtCliente.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            txtCep.Enabled = false;
            boxFisJur.Enabled = false;
            txtCodCidade.Enabled = false;
            chkAtivo.Enabled = false;

            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false; 

            chkConsRev.Enabled = false;
            txtInscEst.Enabled = false;
            txtSuframa.Enabled = false;
            txtCnpj.Enabled = false;
            chkReg.Enabled = false;
            chkProdRur.Enabled = false;
            dataFundacao.Enabled = false;

            txtIdListPrec.Enabled = false;
            txtIdCondPag.Enabled = false;
            txtIdReg.Enabled = false;
            txtIdVend.Enabled = false;
            txtPessoasAut.Enabled = false;
            chkVerForn.Enabled = false;

            txtIdRamoAtiv.Enabled = false;

            txtTransp.Enabled = false;

            dataCad.Enabled = false;
            dataUltAlt.Enabled = false;
            dataUltComp.Enabled = false;
            txtObsDiv.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtCliente.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            txtBairro.Enabled = true;
            txtCep.Enabled = true;
            boxFisJur.Enabled = true;
            txtCodCidade.Enabled = true;
            chkAtivo.Enabled = true;

            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;

            chkConsRev.Enabled = true;
            txtInscEst.Enabled = true;
            txtSuframa.Enabled = true;
            txtCnpj.Enabled = true;
            chkReg.Enabled = true;
            chkProdRur.Enabled = true;
            dataFundacao.Enabled = true;

            txtIdListPrec.Enabled = true;
            txtIdCondPag.Enabled = true;
            txtIdReg.Enabled = true;
            txtIdVend.Enabled = true;
            txtPessoasAut.Enabled = true;
            chkVerForn.Enabled = true;

            txtIdRamoAtiv.Enabled = true;

            txtTransp.Enabled = true;

            dataCad.Enabled = true;
            dataUltAlt.Enabled = true;
            dataUltComp.Enabled = true;
            txtObsDiv.Enabled = true;
        }

        public override void Salvar()
        {
            oCliente.Cod = Convert.ToInt32(txtCod.Text);
            oCliente.Cliente = txtCliente.Text;
            oCliente.Endereco = txtEndereco.Text;
            oCliente.Numero = Convert.ToInt32(txtNumero.Text);
            oCliente.Complemento = txtComplemento.Text;
            oCliente.Bairro = txtBairro.Text;
            oCliente.Cep = txtCep.Text;
            if (boxFisJur.Text == "Fisica")
                oCliente.FisicaJuridica = false;
            else if (boxFisJur.Text == "Juridica")
                oCliente.FisicaJuridica = true;
            oCliente.CodCidades = Convert.ToInt32(txtCodCidade.Text);
            oCliente.Ativo = chkAtivo.Checked;

            oCliente.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            oCliente.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            oCliente.DataModificacao = Convert.ToDateTime(txtDataAlt);

            oCliente.ConsumidorRevenda = chkConsRev.Checked;
            oCliente.InscricaoEstadual = txtInscEst.Text;
            oCliente.InscMunicipalSuframa = txtSuframa.Text;
            oCliente.CNPJ = txtCnpj.Text;
            oCliente.RegimeSemSt = chkReg.Checked;
            oCliente.ProdutorRural = chkProdRur.Checked;
            oCliente.DataFundacao = dataFundacao.Value; 

            oCliente.CodListaPrecos = Convert.ToInt32(txtIdListPrec.Text);
            oCliente.CodCondicaoPagamentos = Convert.ToInt32(txtIdCondPag.Text);
            oCliente.CodRegioes = Convert.ToInt32(txtIdReg.Text);
            oCliente.CodVendedores = Convert.ToInt32(txtIdVend.Text);
            oCliente.PessoasAutorizadas = txtPessoasAut.Text;
            oCliente.VerEmFornecedores = chkVerForn.Checked;

            oCliente.CodRamoAtividades = Convert.ToInt32(txtIdRamoAtiv.Text);

            oCliente.CodTransportadoras = Convert.ToInt32(txtTransp.Text);

            oCliente.DataCad2 = dataCad.Value;
            oCliente.DataUltAlt2 = dataUltAlt.Value;
            oCliente.UltimaCompra = dataUltComp.Value;
            oCliente.ObsDiv = txtObsDiv.Text;
        }

        public void setFrmConCidades(Object obj)
        {
            oFrmConCidades =(FormConCidades)obj;
        }

        public void setFrmConListaPrecos(Object obj)
        {
            oFrmConListaPrecos = (FormConListaPrecos)obj;
        }

        public void setFrmConCondPag(Object obj)
        {
            oFrmConCondPag = (FormConCondicaoPagamentos)obj;
        }

        public void setFrmConRegioes(Object obj)
        {
            oFrmConRegioes = (FormConRegioes)obj;
        }

        public void setFrmConVendedores(Object obj)
        {
            oFrmConVendedores = (FormConVendedores)obj;
        }

        public void setFrmConTransportadoras(Object obj)
        {
            oFrmConTransportadoras = (FormConTransportadoras)obj;
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            oFrmConCidades.ConhecaObj(oCliente.Cidades);
            oFrmConCidades.ShowDialog();
        }
        private void btnPesquisarListaPreco_Click(object sender, EventArgs e)
        {
            oFrmConListaPrecos.ConhecaObj(oCliente.ListaPrecos);
            oFrmConListaPrecos.ShowDialog();
        }

        private void btnPesquisarCondPag_Click(object sender, EventArgs e)
        {
            oFrmConCondPag.ConhecaObj(oCliente.CondicaoPagamentos);
            oFrmConCondPag.ShowDialog();
        }

        private void btnPesquisarRegiao_Click(object sender, EventArgs e)
        {
            oFrmConRegioes.ConhecaObj(oCliente.Regioes);
            oFrmConRegioes.ShowDialog();
        }

        private void btnPesquisarVendedor_Click(object sender, EventArgs e)
        {
            oFrmConVendedores.ConhecaObj(oCliente.Vendedores);
            oFrmConVendedores.ShowDialog();
        }

        private void btnPesquisarTransportadora_Click(object sender, EventArgs e)
        {
            oFrmConTransportadoras.ConhecaObj(oCliente.Transportadoras);
            oFrmConTransportadoras.ShowDialog();
        }

        private void btnConsultaReg_Click(object sender, EventArgs e)
        {
            oFrmConRegioes.ConhecaObj(oCliente.Regioes);
            oFrmConRegioes.ShowDialog();
        }
    }
}
