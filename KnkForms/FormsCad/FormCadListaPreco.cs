﻿using KnkForms.Classes;
using KnkForms.FormsCon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KnkForms.Forms
{
    public partial class FormCadListaPreco : KnkForms.FormCadPai
    {
        ListaPrecos aListaPreco;
        FormConMarcas oFrmConMarcas;
        FormConSubgrupos oFrmConSubgrupos;
        char SalvarAlterar = '\0';
        public FormCadListaPreco()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(Object obj)
        {
            aListaPreco = (ListaPrecos)obj;
        }

        public override void LimpaTxt()
        {
            txtCod.Clear();
            txtLista.Clear();
            txtDescMax.Clear();
            txtMargemLucro.Clear();
            txtPercCom.Clear();
            txtCodMarca.Clear();
            txtCodSubgrupo.Clear();
            chkTodas.Checked = false;
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
        }

        public void CarregaTxt(string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string campo7, string campo8, string campo9)
        {
            txtCod.Text = campo1;
            txtLista.Text = campo2;
            txtDescMax.Text = campo3;
            txtMargemLucro.Text = campo4;
            txtPercCom.Text = campo5;
            if(campo6 == "S") chkTodas.Checked = true; else { chkTodas.Checked = false; }
            txtCodUser.Text = campo7;
            txtDataCad.Text = campo8;
            txtDataAlt.Text = campo9;
            SalvarAlterar = 'A';

        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtLista.Enabled = false;
            txtDescMax.Enabled = false;
            txtMargemLucro.Enabled = false;
            txtPercCom.Enabled = false;
            txtCodMarca.Enabled = false;
            txtCodSubgrupo.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
            chkTodas.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtLista.Enabled = true;
            txtDescMax.Enabled = true;
            txtMargemLucro.Enabled = true;
            txtPercCom.Enabled = true;
            txtCodMarca.Enabled = true;
            txtCodSubgrupo.Enabled = true;
            chkTodas.Enabled = true;
            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
        }

        public override void Salvar()
        {
            aListaPreco.Lista = txtLista.Text;
            aListaPreco.DescontoMaximo = Convert.ToDouble(txtDescMax.Text);
            aListaPreco.MargemLucro = Convert.ToDouble(txtMargemLucro.Text);
            aListaPreco.PercCom = Convert.ToDouble(txtPercCom.Text);
            if(chkTodas.Checked == true) { aListaPreco.Todas = "S"; } else { aListaPreco.Todas = "N"; } 
            aListaPreco.CodEmpresa = 1;
            aListaPreco.DataModificacao = DateTime.Now;

            if (SalvarAlterar == 'A')
            {
                aListaPreco.Cod = Convert.ToInt32(txtCod.Text);
                aListaPreco.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
                aListaPreco.AlterarBD(aListaPreco);
            }
            else
            {
                aListaPreco.DataCadastro = DateTime.Now;
                aListaPreco.SalvarBD(aListaPreco);
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
        public void SetConsulta(int id, string nome, string tipo)
        {
            if(tipo == "Marca")
            {
                txtCodMarca.Text = Convert.ToString(id);
                txtNomeMarca.Text = nome;
            }
            else if(tipo == "Subgrupo")
            {
                txtCodSubgrupo.Text = Convert.ToString(id);
                txtNomeSubgrupo.Text = nome;
            }
        }

        public void setFrmConMarcas(Object obj)
        {
            oFrmConMarcas = (FormConMarcas)obj;
        }
        public void setFrmConSubgrupos(Object obj)
        {
            oFrmConSubgrupos = (FormConSubgrupos)obj;
        }
        private void btnConsultaMarca_Click(object sender, EventArgs e)
        {
            oFrmConMarcas.ConhecaObj(aListaPreco.Marcas);
            oFrmConMarcas.ShowDialog();
        }

        private void btnConsultaGrupo_Click(object sender, EventArgs e)
        {
            oFrmConSubgrupos.ConhecaObj(aListaPreco.Subgrupos);
            oFrmConSubgrupos.ShowDialog();
        }
    }
}
