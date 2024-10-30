using KnkForms.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnkForms.Forms
{
    public partial class FormCadPais : KnkForms.FormCadPai
    {
        Paises oPais;
        char SalvarAlterar = '\0';
        public FormCadPais()
        {
            InitializeComponent();
        }


        public override void ConhecaObj(Object obj)
        {
            oPais = (Paises)obj;
        }

        public override void LimpaTxt()
        {
            txtCod.Clear();
            txtPais.Clear();
            txtSigla.Clear();
            txtDdi.Clear();
            boxNacional.Text = "";
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
            chkAtivo.Checked = false;
        }

        public void CarregaTxt(string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string campo7, string campo8, string campo9)
        {
            txtCod.Text = campo1;
            txtCod.Enabled = false;
            txtPais.Text = campo2;
            txtSigla.Text = campo3;
            txtDdi.Text = campo4;
            boxNacional.Text = campo5;
            if (campo6 == "true") chkAtivo.Enabled = true; else { chkAtivo.Enabled = false; }
            txtCodUser.Text = campo7;
            txtDataCad.Text = campo8;
            txtDataAlt.Text = campo9;
            SalvarAlterar = 'A';
            
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtPais.Enabled = false;
            txtSigla.Enabled = false;
            txtDdi.Enabled = false;
            boxNacional.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
            chkAtivo.Enabled = false;
            boxNacional.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtPais.Enabled = true;
            txtSigla.Enabled = true;
            txtDdi.Enabled = true;
            boxNacional.Enabled = true;
            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
            chkAtivo.Enabled = true;
            boxNacional.Enabled = true;
        }

        public override void Salvar()
        {
            oPais.Cod = Convert.ToInt32(txtCod.Text);
            oPais.Pais = txtPais.Text;
            oPais.Sigla = txtSigla.Text;
            oPais.DDI = Convert.ToInt32(txtDdi.Text);
            if (boxNacional.Text == "Sim")
                oPais.Nacional = 's';
            else if (boxNacional.Text == "Não")
                oPais.Nacional = 'n';
            oPais.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            oPais.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            oPais.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);
            if (chkAtivo.Checked == true) { oPais.Ativo = 'S'; } else { oPais.Ativo = 'N'; };

            if (SalvarAlterar == 'A')
                oPais.AlterarBD(oPais.Cod);
            else
                oPais.SalvarBD();
            SalvarAlterar = '\0';
            txtCod.Enabled = true;
            Close();
        }
        private void chkBox(object sender, KeyEventArgs e)
        {
            CheckBox c1 = this.ActiveControl as CheckBox;
            if (e.KeyData == Keys.Enter && this.ActiveControl.Equals(c1))
                c1.Checked = true;
        }
    }
}
