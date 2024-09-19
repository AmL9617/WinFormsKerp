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
    public partial class FormCadParcela : KnkForms.FormCadPai
    {
        Parcelas aParcela;
        public FormCadParcela()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(Object obj)
        {
            aParcela = (Parcelas)obj;
        }

        public override void LimpaTxt()
        {
            txtCod.Clear();
            txtQtd.Clear();
            txtValor.Clear();
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
        }

        public override void CarregaTxt()
        {
            txtCod.Text = Convert.ToString(aParcela.Cod);
            txtQtd.Text = Convert.ToString(aParcela.Quantidade);
            txtValor.Text = Convert.ToString(aParcela.Valor);
            txtCodUser.Text = Convert.ToString(aParcela.CodEmpresa);
            txtDataCad.Text = Convert.ToString(aParcela.DataCadastro);
            txtDataAlt.Text = Convert.ToString(aParcela.DataModificacao);
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtQtd.Enabled = false;
            txtValor.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtQtd.Enabled = true;
            txtValor.Enabled = true;
            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
        }

        public override void Salvar()
        {
            aParcela.Cod = Convert.ToInt32(txtCod.Text);
            aParcela.Quantidade = Convert.ToInt32(txtQtd.Text);
            aParcela.Valor = Convert.ToDouble(txtValor.Text);
            aParcela.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            aParcela.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            aParcela.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);
        }
    }
}
