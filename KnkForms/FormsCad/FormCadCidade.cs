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
            txtNomeEstado.Clear();
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
            chkAtivo.Checked = false;
        }

        public void CarregaTxt(string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string campo7, string campo8, string campo9)
        {
            txtCod.Text = campo1;
            txtNomeEstado.Text = campo2;
            txtCodEstado.Text = campo3;
            txtCidade.Text = campo4;
            txtDDD.Text = campo5;
            if (campo6 == "N") { chkAtivo.Checked = false; } else { chkAtivo.Checked = true; };
            txtCodUser.Text = campo7;
            txtDataCad.Text = campo8;
            txtDataAlt.Text = campo9;
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

            aCidade.Cidade = txtCidade.Text;
            aCidade.DDD = !string.IsNullOrEmpty(txtDDD.Text) ? txtDDD.Text : null;
            aCidade.CodEstado = Convert.ToInt32(txtCodEstado.Text);
            aCidade.Estado = txtNomeEstado.Text;
            aCidade.CodEmpresa = 1;
            aCidade.DataModificacao = DateTime.Today;
            if (chkAtivo.Checked == true) { aCidade.Ativo = 'S'; } else { aCidade.Ativo = 'N'; };

            if (SalvarAlterar == 'A')
            {
                aCidade.Cod = Convert.ToInt32(txtCod.Text);
                aCidade.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
                aCidade.AlterarBD(aCidade);

            }
            else
            {
                aCidade.DataCadastro = DateTime.Today;
                aCidade.SalvarBD(aCidade);
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

        public void SetEstado(int idEstado, string nomeEstado)
        {
            txtCodEstado.Text = Convert.ToString(idEstado);
            txtNomeEstado.Text = nomeEstado;
        }
       
        public void setFrmConEstados(Object obj)
        {
            oFrmConEstados = (FormConEstados)obj;
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            oFrmConEstados.ConhecaObj(aCidade.Estados);
            oFrmConEstados.Owner = this;
            oFrmConEstados.ShowDialog();
        }
    }
}
