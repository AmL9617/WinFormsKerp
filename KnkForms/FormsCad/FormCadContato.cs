﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KnkForms.Classes;
using KnkForms.FormsCon;

namespace KnkForms.FormsCad
{
    public partial class FormCadContato : KnkForms.FormCadPai
    {
        Contatos oContato;
        public FormCadContato()
        {
            InitializeComponent();
        }
      
        public override void ConhecaObj(Object obj)
        {
            oContato = (Contatos)obj;
        }

        public override void LimpaTxt()
        {
            txtCod.Clear();
            txtTipo.Clear();
            txtContato.Clear();
            txtObservacao.Clear();
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
        }

        public override void CarregaTxt()
        {
            txtCod.Text = Convert.ToString(oContato.Cod);
            txtTipo.Text = oContato.Tipo;
            txtContato.Text = oContato.Contato;
            txtObservacao.Text = oContato.Observacao;
            txtCodUser.Text = Convert.ToString(oContato.CodEmpresa);
            txtDataCad.Text = Convert.ToString(oContato.DataCadastro);
            txtDataAlt.Text = Convert.ToString(oContato.DataModificacao);
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtTipo.Enabled = false;
            txtContato.Enabled = false;
            txtObservacao.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtTipo.Enabled = true;
            txtContato.Enabled = true;
            txtObservacao.Enabled = true;
            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
        }

        public override void Salvar()
        {
            oContato.Cod = Convert.ToInt32(txtCod.Text);
            oContato.Tipo = txtTipo.Text;
            oContato.Contato = txtContato.Text;
            oContato.Observacao = txtObservacao.Text;
            oContato.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            oContato.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            oContato.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);
        }

    }
}