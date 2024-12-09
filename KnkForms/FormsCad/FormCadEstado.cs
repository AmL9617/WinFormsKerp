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
using KnkForms.FormsCon;

namespace KnkForms.Classes
{
    public partial class FormCadEstado : KnkForms.FormCadPai
    {
        Estados oEstado;
        FormConPaises oFrmConPaises;
        char SalvarAlterar = '\0';
        public FormCadEstado()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(Object obj)
        {
            oEstado = (Estados)obj;
        }

        public override void LimpaTxt()
        {
            txtCod.Clear();
            txtEstado.Clear();
            txtSigla.Clear();
            txtCodPais.Clear();
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
            txtPercIcms.Clear();
            txtIcms.Clear();
            txtPercRedST.Clear();
            txtCodWeb.Clear();
        }

        public void CarregaTxt(string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string campo7, string campo8, string campo9, string campo10, string campo11)
        {
            txtCod.Text = campo1;
            txtCod.Enabled = false;
            txtCodPais.Text = campo2;
            txtEstado.Text = campo3;
            txtSigla.Text = campo4;
            txtPercIcms.Text = campo5;
            txtIcms.Text = campo6;
            txtPercRedST.Text = campo7;
            txtCodWeb.Text = campo8;
            txtCodUser.Text = campo9;
            txtDataCad.Text = campo10;
            txtDataAlt.Text = campo11;
            SalvarAlterar = 'A';

        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtEstado.Enabled = false;
            txtSigla.Enabled = false;
            txtCodPais.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
            txtPercRedST.Enabled = false;
            txtIcms.Enabled = false;
            txtPercIcms.Enabled = false;
            txtCodWeb.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtEstado.Enabled = true;
            txtSigla.Enabled = true;
            txtCodPais.Enabled = true;
            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
            txtPercIcms.Enabled = true;
            txtIcms.Enabled = true;
            txtPercRedST.Enabled=true;
            txtCodWeb.Enabled = true;
        }

        public override void Salvar()
        {
            oEstado.Estado = txtEstado.Text;
            oEstado.Sigla = Convert.ToString(txtSigla.Text);
            oEstado.CodPais = Convert.ToInt32(txtCodPais.Text);
            oEstado.PercIcms = Convert.ToDouble(txtPercIcms.Text) ;
            oEstado.Icms = Convert.ToDouble(txtIcms.Text);
            oEstado.PercRedST = Convert.ToDouble(txtPercIcms.Text);
            oEstado.CodWeb = Convert.ToInt32(txtCodWeb.Text);
            oEstado.CodEmpresa = 1;
            oEstado.DataModificacao = DateTime.Now;

            if (SalvarAlterar == 'A')
            {
                oEstado.Cod = Convert.ToInt32(txtCod.Text);
                oEstado.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
                oEstado.AlterarBD(oEstado.Cod);

            }
            else
            {

                oEstado.DataCadastro = DateTime.Now;
                oEstado.SalvarBD();
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
        public void SetPais(int idPais, string nomePais)
        {
            txtCodPais.Text = Convert.ToString(idPais);
            txtNomePais.Text = nomePais;
        }
        public void setFrmConPaises(Object obj)
        {
            oFrmConPaises = (FormConPaises)obj;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            oFrmConPaises.ConhecaObj(oEstado.Pais);
            oFrmConPaises.Owner = this;
            oFrmConPaises.ShowDialog();
        }
        
    }
}
