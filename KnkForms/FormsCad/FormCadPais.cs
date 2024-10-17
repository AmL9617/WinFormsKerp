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

        string connectionString = "Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";
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

        public override void CarregaTxt()
        {
            txtCod.Text = Convert.ToString(oPais.Cod);
            txtPais.Text = oPais.Pais;
            txtSigla.Text = Convert.ToString(oPais.Sigla);
            txtDdi.Text = Convert.ToString(oPais.DDI);
            if (oPais.Nacional == 's')
                boxNacional.Text = "Sim";
            else if (oPais.Nacional == 'n')
                boxNacional.Text = "Não";
            txtCodUser.Text = Convert.ToString(oPais.CodEmpresa);
            txtDataCad.Text= Convert.ToString(oPais.DataCadastro);
            txtDataAlt.Text = Convert.ToString(oPais.DataModificacao);
            chkAtivo.Checked = oPais.Ativo;
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
            oPais.Sigla = Convert.ToChar(txtSigla.Text);
            oPais.DDI = Convert.ToInt32(txtDdi.Text);
            if (boxNacional.Text == "Sim")
                oPais.Nacional = 's';
            else if (boxNacional.Text == "Não")
                oPais.Nacional = 'n';
            oPais.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            oPais.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            oPais.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);
            oPais.Ativo = chkAtivo.Checked;

            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
