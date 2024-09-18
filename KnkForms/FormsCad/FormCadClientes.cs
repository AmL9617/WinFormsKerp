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
    public partial class FormCadClientes : KnkForms.FormCadPai
    {
        Clientes oCliente;
        public FormCadClientes()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(Object obj)
        {
            oCliente = (Clientes)obj;
        }

        public override void LimpaTxt()
        {
            txtCod.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCep.Clear();
            txtCodCidade.Clear();
            chkAtivo.Checked = false;

            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();

            chkCons.Checked = false;
            chkRev.Checked = false;
            txtInscEst.Clear();
            txtSuframa.Clear();
            txtCnpj.Clear();
            chkReg.Checked = false;
            chkProdRur.Checked = false;
            dataFundacao.Value = DateTime.Today;

            txtContato.Clear();
            txtTipoContato.Clear();
            txtObsContato.Clear();

            txtIdListPrec.Clear();
            txtIdCondPag.Clear();
            txtIdReg.Clear();
            txtIdVend.Clear();
            txtPessoasAut.Clear();
            chkAtivo.Checked = false;

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
            txtNome.Text = oCliente.Nome;
            txtEndereco.Text = oCliente.Endereco; 
            txtNumero.Text = Convert.ToString(oCliente.Numero);
            txtComplemento.Text = oCliente.Complemento;
            txtBairro.Text = oCliente.Bairro;
            txtCep.Text = oCliente.Cep;
            txtCodCidade.Text = Convert.ToString(oCliente.CodCidades);
            chkAtivo.Checked = oCliente.Ativo;

            txtCodUser.Text = Convert.ToString(oCliente.CodEmpresa);
            txtDataCad.Text = Convert.ToString(oCliente.DataCad2);
            txtDataAlt.Text = Convert.ToString(oCliente.DataCadAlt2);

            chkCons.Checked = oCliente.ConsumidorRevenda;
            chkRev.Checked = false;
            txtInscEst.Clear();
            txtSuframa.Clear();
            txtCnpj.Clear();
            chkReg.Checked = false;
            chkProdRur.Checked = false;
            dataFundacao.Value = DateTime.Today;

            txtContato.Clear();
            txtTipoContato.Clear();
            txtObsContato.Clear();

            txtIdListPrec.Clear();
            txtIdCondPag.Clear();
            txtIdReg.Clear();
            txtIdVend.Clear();
            txtPessoasAut.Clear();
            chkAtivo.Checked = false;

            txtIdRamoAtiv.Clear();

            txtTransp.Clear();

            dataCad.Value = DateTime.Today;
            dataUltAlt.Value = DateTime.Today;
            dataUltComp.Value = DateTime.Today;
            txtObsDiv.Clear();
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtNomePais.Enabled = false;
            txtTipoPais.Enabled = false;
            txtSigla.Enabled = false;
            txtDdi.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtNomePais.Enabled = true;
            txtTipoPais.Enabled = true;
            txtSigla.Enabled = true;
            txtDdi.Enabled = true;
            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
        }

        public override void Salvar()
        {
            oPais.Cod = Convert.ToInt32(txtCod.Text);
            oPais.NomePais = txtNomePais.Text;
            oPais.TipoPais = txtTipoPais.Text;
            oPais.Sigla = Convert.ToChar(txtSigla.Text);
            oPais.DDI = Convert.ToInt32(txtDdi.Text);
            oPais.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            oPais.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            oPais.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);
        }
    }
}
