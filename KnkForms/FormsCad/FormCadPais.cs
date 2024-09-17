using KnkForms.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public FormCadPais()
        {
            InitializeComponent();
        }

        public override void SetFrmCadastro(Object obj)
        {
            oFormCadPais = (FormCadPais)obj;
        }


        public override void CarregaObj(Object obj)
        {
            oPais = (Paises)obj;
        }

        public override void LimpaTxt()
        {
            txtCod.Clear();
            txtNomePais.Clear();
            txtTipoPais.Clear();
            txtSigla.Clear();
            txtDdi.Clear();
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
        }

        public override void CarregaTxt()
        {
            txtCod.Text = oPais.Cod;
            txtNomePais.Text = oPais.NomePais;
            txtTipoPais.Text=oPais.TipoPais;
            txtSigla.Text = oPais.Sigla;
            txtDdi.Text = oPais.DDI;
            txtCodUser.Text = oPais.CodUser;
            txtDataCad.Text= oPais.DataCadastro;

        }

        public override void DesbloqueiaTxt()
        {

        }

        public override void Salvar()
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
