﻿using Newtonsoft.Json;
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

        public void CarregaTxt(string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string campo7, string campo8, string campo9, string campo10, string campo11, string campo12)
        {
            txtCod.Text = campo1;
            txtEstado.Text = campo2;
            txtCodPais.Text = campo3;
            txtNomePais.Text = campo4;
            txtSigla.Text = campo5;
            txtPercIcms.Text = campo6;
            txtIcms.Text = campo7;
            txtPercRedST.Text = campo8;
            txtCodWeb.Text = campo9;
            txtCodUser.Text = campo10;
            txtDataCad.Text = campo11;
            txtDataAlt.Text = campo12;
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
            oEstado.PercIcms = !string.IsNullOrEmpty(txtPercIcms.Text) ? (decimal?)Convert.ToDecimal(txtPercIcms.Text) : null;
            oEstado.Icms = !string.IsNullOrEmpty(txtIcms.Text) ? (decimal?)Convert.ToDecimal(txtIcms.Text) : null;
            oEstado.PercRedST = !string.IsNullOrEmpty(txtPercRedST.Text) ? (decimal?)Convert.ToDecimal(txtPercRedST.Text) : null; ;
            oEstado.CodWeb = !string.IsNullOrEmpty(txtCodWeb.Text) ? (int?)Convert.ToInt32(txtCodWeb.Text) : null; ;
            oEstado.CodEmpresa = 1;
            oEstado.DataModificacao = DateTime.Now;
            oEstado.NomePais = txtNomePais.Text;
            
            if (SalvarAlterar == 'A')
            {
                oEstado.Cod = Convert.ToInt32(txtCod.Text);
                oEstado.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
                oEstado.AlterarBD(oEstado);

            }
            else
            {

                oEstado.DataCadastro = DateTime.Now;
                oEstado.SalvarBD(oEstado);
            }
            SalvarAlterar = '\0';

            Close();
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
