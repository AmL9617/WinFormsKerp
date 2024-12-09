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
        FormConRamoAtividades oFrmConRamoAtiv;
        FormConTransportadoras oFrmConTransportadoras;
        char SalvarAlterar = '\0';
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

        public void CarregaTxt(string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string campo7, string campo8, string campo9, string campo10, string campo11, string campo12, string campo13, string campo14, string campo15, string campo16, string campo17, string campo18, string campo19, string campo20, string campo21, string campo22, string campo23, string campo24, string campo25)
        {
            txtCod.Text = Convert.ToString(oCliente.Cod);
            txtCod.Enabled = false;
            txtCliente.Text = oCliente.Cliente;
            txtEndereco.Text = oCliente.Endereco; 
            txtNumero.Text = Convert.ToString(oCliente.Numero);
            txtComplemento.Text = oCliente.Complemento;
            txtBairro.Text = oCliente.Bairro;
            txtCep.Text = oCliente.Cep;
            if (oCliente.FisicaJuridica == 'F')
                boxFisJur.Text = "Fisica";
            else if (oCliente.FisicaJuridica == 'J')
                boxFisJur.Text = "Juridica";
            txtCodCidade.Text = Convert.ToString(oCliente.CodCidades);
            if (chkAtivo.Checked == true) { oCliente.Ativo = 'S'; } else { oCliente.Ativo = 'N'; }

            txtCodUser.Text = Convert.ToString(oCliente.CodEmpresa);
            txtDataCad.Text = Convert.ToString(oCliente.DataCadastro);
            txtDataAlt.Text = Convert.ToString(oCliente.DataModificacao);

            if (oCliente.ConsumidorRevenda == 'S') { chkConsRev.Checked = true; } else { chkConsRev.Checked = false; };
            txtInscEst.Text = oCliente.InscricaoEstadual;
            txtSuframa.Text = oCliente.InscMunicipalSuframa;
            txtCnpj.Text = oCliente.CNPJ;
            if (oCliente.RegimeSemSt == 'S') { chkReg.Checked = true; } else { chkReg.Checked = false; };
            if (oCliente.ProdutorRural == 'S') { chkProdRur.Checked = true; } else { chkProdRur.Checked = false; };
            dataFundacao.Value = oCliente.DataFundacao;

            txtIdListPrec.Text = Convert.ToString(oCliente.CodListaPrecos);
            txtIdCondPag.Text = Convert.ToString(oCliente.CodCondicaoPagamentos);
            txtIdVend.Text = Convert.ToString(oCliente.CodVendedores);
            txtPessoasAut.Text = Convert.ToString(oCliente.PessoasAutorizadas);
            if (oCliente.VerEmFornecedores == 'S') { chkVerForn.Checked = true; } else { chkVerForn.Checked = false; };

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
            oCliente.Cliente = txtCliente.Text;
            oCliente.Endereco = txtEndereco.Text;
            oCliente.Numero = Convert.ToInt32(txtNumero.Text);
            oCliente.Complemento = txtComplemento.Text;
            oCliente.Bairro = txtBairro.Text;
            oCliente.Cep = txtCep.Text;
            if (boxFisJur.Text == "Fisica")
                oCliente.FisicaJuridica = 'F';
            else if (boxFisJur.Text == "Juridica")
                oCliente.FisicaJuridica = 'J';
            oCliente.CodCidades = Convert.ToInt32(txtCodCidade.Text);
            if (chkAtivo.Enabled == true) { oCliente.Ativo = 'S'; } else { oCliente.Ativo = 'N'; };


            oCliente.CodEmpresa = 1;
            oCliente.DataModificacao = DateTime.Now;

            if (chkConsRev.Checked == true) { oCliente.ConsumidorRevenda = 'S'; } else { oCliente.ConsumidorRevenda = 'N'; };
            oCliente.InscricaoEstadual = txtInscEst.Text;
            oCliente.InscMunicipalSuframa = txtSuframa.Text;
            oCliente.CNPJ = txtCnpj.Text;
            if (chkReg.Checked == true) { oCliente.RegimeSemSt = 'S'; } else { oCliente.RegimeSemSt = 'N'; };
            if (chkProdRur.Checked == true) { oCliente.ProdutorRural = 'S'; } else { oCliente.ProdutorRural = 'N'; };
            oCliente.DataFundacao = dataFundacao.Value; 

            oCliente.CodListaPrecos = Convert.ToInt32(txtIdListPrec.Text);
            oCliente.CodCondicaoPagamentos = Convert.ToInt32(txtIdCondPag.Text);
            oCliente.CodVendedores = Convert.ToInt32(txtIdVend.Text);
            oCliente.PessoasAutorizadas = txtPessoasAut.Text;
            if (chkVerForn.Checked == true) { oCliente.VerEmFornecedores = 'S'; } else { oCliente.VerEmFornecedores = 'N'; };

            oCliente.CodRamoAtividades = Convert.ToInt32(txtIdRamoAtiv.Text);

            oCliente.CodTransportadoras = Convert.ToInt32(txtTransp.Text);

            oCliente.DataCad2 = dataCad.Value;
            oCliente.DataUltAlt2 = dataUltAlt.Value;
            oCliente.UltimaCompra = dataUltComp.Value;
            oCliente.ObsDiv = txtObsDiv.Text;

            if (SalvarAlterar == 'A')
                oCliente.AlterarBD(oCliente.Cod);
            else
            {

                oCliente.DataCadastro = DateTime.Now;
                oCliente.SalvarBD();
            }
            SalvarAlterar = '\0';

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
            if (tipo == "Cidade")
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
                txtIdListPrec.Text = Convert.ToString(id);
                txtNomeLista.Text = nome;
            }
            else if (tipo == "CondPag")
            {
                txtIdCondPag.Text = Convert.ToString(id);
                txtNomeCondPag.Text = nome;
            }
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
        public void setFrmConRamoAtiv(Object obj)
        {
            oFrmConRamoAtiv = (FormConRamoAtividades)obj;
        }
        public void setFrmConTransportadoras(Object obj)
        {
            oFrmConTransportadoras = (FormConTransportadoras)obj;
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            oFrmConCidades.ConhecaObj(oCliente.Cidades);
            oFrmConCidades.Owner = this;
            oFrmConCidades.ShowDialog();
        }
        private void btnPesquisarListaPreco_Click(object sender, EventArgs e)
        {
            oFrmConListaPrecos.ConhecaObj(oCliente.ListaPrecos);
            oFrmConListaPrecos.Owner = this;
            oFrmConListaPrecos.ShowDialog();
        }

        private void btnPesquisarCondPag_Click(object sender, EventArgs e)
        {
            oFrmConCondPag.ConhecaObj(oCliente.CondicaoPagamentos);
            oFrmConCondPag.Owner = this;
            oFrmConCondPag.ShowDialog();
        }

        private void btnPesquisarRegiao_Click(object sender, EventArgs e)
        {
            oFrmConRegioes.ConhecaObj(oCliente.Regioes);
            oFrmConRegioes.Owner = this;
            oFrmConRegioes.ShowDialog();
        }

        private void btnPesquisarVendedor_Click(object sender, EventArgs e)
        {
            oFrmConVendedores.ConhecaObj(oCliente.Vendedores);
            oFrmConVendedores.Owner = this;
            oFrmConVendedores.ShowDialog();
        }

        private void btnPesquisarTransportadora_Click(object sender, EventArgs e)
        {
            oFrmConTransportadoras.ConhecaObj(oCliente.Transportadoras);
            oFrmConTransportadoras.Owner = this;
            oFrmConTransportadoras.ShowDialog();
        }

        private void btnConsultaReg_Click(object sender, EventArgs e)
        {
            oFrmConRegioes.ConhecaObj(oCliente.Regioes);
            oFrmConRegioes.Owner = this;
            oFrmConRegioes.ShowDialog();
        }

        private void btnPesquisarRamoAtiv_Click(object sender, EventArgs e)
        {
            oFrmConRamoAtiv.ConhecaObj(oCliente.RamoAtividades);
            oFrmConRamoAtiv.Owner = this;
            oFrmConRamoAtiv.ShowDialog();
        }
    }
}
