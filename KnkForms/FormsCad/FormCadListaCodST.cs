using KnkForms.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KnkForms.FormsCad
{
    public partial class FormCadListaCodST : KnkForms.FormCadPai
    {
        ListaCodST aListaCodST;
        char SalvarAlterar = '\0';

        public FormCadListaCodST()
        {
            txtCod.Enabled = true;
            InitializeComponent();
        }
        public override void ConhecaObj(Object obj)
        {
            aListaCodST = (ListaCodST)obj;
        }

        public override void LimpaTxt()
        {
            txtCod.Clear();
            txtTipo.Clear();
            txtDescricao.Clear();
            chkAtivo.Checked = false;
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
        }

        public void CarregaTxt(string campo1, string campo2, string campo3, string campo4, string campo5)
        {
            txtCod.Enabled = false;
            txtCod.Text = campo1;
            txtTipo.Text = campo2;
            txtDescricao.Text = campo3;
            if (campo4 == "S") { chkAtivo.Checked = true; } else { chkAtivo.Checked = false; };
            txtCodUser.Text = campo5;

            SalvarAlterar = 'A';
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtTipo.Enabled = false;
            txtDescricao.Enabled = false;
            chkAtivo.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtTipo.Enabled = true;
            txtDescricao.Enabled = true;
            chkAtivo.Enabled = true;
            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
        }

        public override void Salvar()
        {
            aListaCodST.CodCst = txtCod.Text;
            aListaCodST.Tipo = txtTipo.Text;
            aListaCodST.Descricao = txtDescricao.Text;
            if (chkAtivo.Checked == true) { aListaCodST.Ativo = 'S'; } else { aListaCodST.Ativo = 'N'; };
            aListaCodST.CodEmpresa = 1;
            aListaCodST.DataModificacao = DateTime.Now;

            if (SalvarAlterar == 'A')
            {
                //aListaCodST.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
                aListaCodST.AlterarBD(aListaCodST);
                
            }
            else
            {
                aListaCodST.DataCadastro = DateTime.Now;
                aListaCodST.SalvarBD(aListaCodST);
            }
            
            SalvarAlterar = '\0';
            Close();
        }
        private void chkBox(object sender, KeyEventArgs e)
        {
            CheckBox c1 = this.ActiveControl as CheckBox;
            if (e.KeyData == Keys.Enter && this.ActiveControl.Equals(c1))
                if (c1.Checked == false) c1.Checked = true; else c1.Checked = false;
        }
    }
}
