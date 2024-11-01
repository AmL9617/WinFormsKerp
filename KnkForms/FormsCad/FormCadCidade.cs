using KnkForms.Classes;
using KnkForms.FormsCon;
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
    public partial class FormCadCidade : KnkForms.FormCadPai
    {
        Cidades aCidade;
        FormConEstados oFrmConEstados;
        char SalvarAlterar = '\0';
        public FormCadCidade()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(Object obj)
        {
            aCidade = (Cidades)obj;
        }

        public override void LimpaTxt()
        {
            txtCod.Clear();
            txtCidade.Clear();
            txtDDD.Clear();
            txtCodEstado.Clear();
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
            chkAtivo.Checked = false;
        }

        public void CarregaTxt(string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string campo7, string campo8)
        {
            txtCod.Text = campo1;
            txtCod.Enabled = false;
            txtCodEstado.Text = campo2;
            txtCidade.Text = campo3;
            txtDDD.Text = campo4;
            if (campo5 == "0") { chkAtivo.Checked = false; } else { chkAtivo.Checked = true; };
            txtCodUser.Text = campo6;
            txtDataCad.Text = campo7;
            txtDataAlt.Text = campo8;
            SalvarAlterar = 'A';

        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtCidade.Enabled = false;
            txtDDD.Enabled = false;
            txtCodEstado.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
            chkAtivo.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtCidade.Enabled = true;
            txtDDD.Enabled = true;
            txtCodEstado.Enabled = true;
            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
            chkAtivo.Enabled = true;
        }

        public override void Salvar()
        {
            aCidade.Cod = Convert.ToInt32(txtCod.Text);
            aCidade.Cidade = txtCidade.Text;
            aCidade.DDD = Convert.ToInt32(txtDDD.Text);
            aCidade.CodEstado = Convert.ToInt32(txtCodEstado.Text);
            aCidade.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            aCidade.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            aCidade.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);
            if (aCidade.Ativo == 'S') { chkAtivo.Checked = true; } else { chkAtivo.Enabled = false; };

            if (SalvarAlterar == 'A')
            {
                aCidade.AlterarBD(aCidade.Cod);
                SalvarAlterar = '\0';

            }
            else
                aCidade.SalvarBD();
            
            txtCod.Enabled = true;
            Close();
        }
        private void chkBox(object sender, KeyEventArgs e)
        {
            CheckBox c1 = this.ActiveControl as CheckBox;
            if (e.KeyData == Keys.Enter && this.ActiveControl.Equals(c1))
                if (c1.Checked == false) c1.Checked = true; else c1.Checked = false;
        }

        public void setFrmConEstados(Object obj)
        {
            oFrmConEstados = (FormConEstados)obj;
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            oFrmConEstados.ConhecaObj(aCidade.Estado);
            oFrmConEstados.ShowDialog();
        }
    }
}
