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
        }

        public void CarregaTxt(string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string campo7, string campo8)
        {
            txtCod.Text = campo1;
            txtCod.Enabled = false;
            txtPais.Text = campo2;
            txtSigla.Text = campo3;
            txtDdi.Text = campo4;
            boxNacional.Text = campo5;
            txtCodUser.Text = campo6;
            txtDataCad.Text = campo7;
            txtDataAlt.Text = campo8;
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
            boxNacional.Enabled = true;
        }

        public override void Salvar()
        {
            oPais.Pais = txtPais.Text;
            oPais.Sigla = txtSigla.Text;
            oPais.DDI = txtDdi.Text;
            if (boxNacional.Text == "Sim")
                oPais.Nacional = 'S';
            else if (boxNacional.Text == "Não")
                oPais.Nacional = 'N';
            oPais.CodEmpresa = 1;
            oPais.DataModificacao = DateTime.Now;
            
            if (SalvarAlterar == 'A')
            {
                oPais.Cod = Convert.ToInt32(txtCod.Text);
                oPais.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
                oPais.AlterarBD(oPais);
            }
            else
            {
                oPais.DataCadastro = DateTime.Now;
                oPais.SalvarBD(oPais);
            }
            SalvarAlterar = '\0';

            txtCod.Enabled = true;
            Close();
        }
    }
}
