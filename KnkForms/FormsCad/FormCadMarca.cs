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
    public partial class FormCadMarca : KnkForms.FormCadPai
    {
        Marcas aMarca;
        public FormCadMarca()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(Object obj)
        {
            aMarca = (Marcas)obj;
        }

        public override void LimpaTxt()
        {
            txtCod.Clear();
            txtMarca.Clear();
            chkAtivo.Checked = false;
        }

        public override void CarregaTxt()
        {
            txtCod.Text = Convert.ToString(aMarca.Cod);
            txtMarca.Text = aMarca.Marca;
            chkAtivo.Checked = aMarca.Ativo;
            txtCodUser.Text = Convert.ToString(aMarca.CodEmpresa);
            txtDataCad.Text = Convert.ToString(aMarca.DataCadastro);
            txtDataAlt.Text = Convert.ToString(aMarca.DataModificacao);
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtMarca.Enabled = false;
            chkAtivo.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtMarca.Enabled = true;
            chkAtivo.Enabled = true;
            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
        }

        public override void Salvar()
        {
            aMarca.Cod = Convert.ToInt32(txtCod.Text);
            aMarca.Marca = txtMarca.Text;
            aMarca.Ativo = chkAtivo.Checked;
            aMarca.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            aMarca.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            aMarca.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);
        }
    }
}
