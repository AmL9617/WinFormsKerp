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
    public partial class FormCadContador : KnkForms.FormCadPai
    {
        Contadores oContador;
        FormConRegioes oFrmConRegioes;
        //FormConContatos oFrmConContatos;
        public FormCadContador()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(Object obj)
        {
            oContador = (Contadores)obj;
        }

        public override void LimpaTxt()
        {
            txtCod.Clear();
            txtContador.Clear();
            txtCrc.Clear();
            txtCnpj.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCep.Clear();
            txtTelefone.Clear();
            txtFax.Clear();
            txtCelular.Clear();
            txtContato.Clear();
            txtEmail.Clear();
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
        }

        public override void CarregaTxt()
        {
            txtCod.Text = Convert.ToString(oContador.Cod);
            txtContador.Text = oContador.Contador;
            txtCrc.Text = oContador.Crc;
            txtCnpj.Text = oContador.Cnpj;
            txtEndereco.Text = oContador.Endereco;
            txtNumero.Text = Convert.ToString(oContador.Numero);
            txtComplemento.Text = oContador.Complemento;
            txtBairro.Text = oContador.Bairro;
            txtCep.Text = oContador.Cep;
            txtTelefone.Text = oContador.Telefone;
            txtFax.Text = oContador.Fax;
            txtCelular.Text = oContador.Celular;
            //txtContato.Text = Convert.ToString(oContador.CodContatos);
            txtEmail.Text = oContador.Email;
            txtCodUser.Text = Convert.ToString(oContador.CodEmpresa);
            txtDataCad.Text = Convert.ToString(oContador.DataCadastro);
            txtDataAlt.Text = Convert.ToString(oContador.DataModificacao);
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtContador.Enabled = false;
            txtCrc.Enabled = false;
            txtCnpj.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            txtCep.Enabled = false;
            txtTelefone.Enabled = false;
            txtFax.Enabled = false;
            txtCelular.Enabled = false;
            txtContato.Enabled = false;
            txtEmail.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtContador.Enabled = true;
            txtCrc.Enabled = true;
            txtCnpj.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            txtBairro.Enabled = true;
            txtCep.Enabled = true;
            txtTelefone.Enabled = true;
            txtFax.Enabled = true;
            txtCelular.Enabled = true;
            txtContato.Enabled = true;
            txtEmail.Enabled = true;

            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
        }

        public override void Salvar()
        {
            oContador.Cod = Convert.ToInt32(txtCod.Text);
            oContador.Contador = txtContador.Text;
            oContador.Crc = txtCrc.Text;
            oContador.Cnpj = txtCnpj.Text;
            oContador.Endereco = txtEndereco.Text;
            oContador.Numero = Convert.ToInt32(txtNumero);
            oContador.Complemento = txtComplemento.Text;
            oContador.Bairro = txtBairro.Text;
            oContador.Cep = txtCep.Text;
            oContador.Telefone = txtTelefone.Text;
            oContador.Fax = txtFax.Text;
            oContador.Celular = txtCelular.Text;
            //oContador.CodContatos = Convert.ToInt32(txtContato.Text);
            oContador.Email = txtEmail.Text;

            oContador.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            oContador.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            oContador.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);
        }
        public void setFrmConRegioes(Object obj)
        {
            oFrmConRegioes = (FormConRegioes)obj;
        }

        private void btnConsultaReg_Click(object sender, EventArgs e)
        {
            oFrmConRegioes.ConhecaObj(oContador.Regioes);
            oFrmConRegioes.ShowDialog();
        }
        /*
public void setFrmConContatos(Object obj)
{
   oFrmConContatos = (FormConContatos)obj;
}
private void btnPesquisarContato_Click(object sender, EventArgs e)
{
   oFrmConContatos.ConhecaObj(oContador.Contatos);
   oFrmConContatos.ShowDialog();
}*/
    }
}
