using KnkForms.Classes;
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
        ListaPrecos aLista;
        public FormCadListaPreco()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(Object obj)
        {
            aLista = (ListaPrecos)obj;
        }

        public override void LimpaTxt()
        {
            txtCod.Clear();
            txtNomeLista.Clear();
            txtDescMax.Clear();
            txtMargemLucro.Clear();
            txtCodMarca.Clear();
            txtCodGrupo.Clear();
            chkTodas.Checked = false;
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
        }

        public override void CarregaTxt()
        {
            txtCod.Text = Convert.ToString(aLista.Cod);
            txtNomeLista.Text = aLista.NomeLista;
            txtDescMax.Text = Convert.ToString(aLista.DescontoMaximo);
            txtMargemLucro.Text = Convert.ToString(aLista.MargemLucro);
            txtCodMarca.Text = Convert.ToString(aLista.CodMarca);
            txtCodGrupo.Text = Convert.ToString(aLista.CodGrupo);
            txtCodUser.Text = Convert.ToString(aLista.CodEmpresa);
            txtDataCad.Text = Convert.ToString(aLista.DataCadastro);
            txtDataAlt.Text = Convert.ToString(aLista.DataModificacao);
            chkTodas.Checked = aLista.Todas;
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtNomeLista.Enabled = false;
            txtDescMax.Enabled = false;
            txtMargemLucro.Enabled = false;
            txtCodMarca.Enabled = false;
            txtCodGrupo.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
            chkTodas.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtNomeLista.Enabled = true;
            txtDescMax.Enabled = true;
            txtMargemLucro.Enabled = true;
            txtCodMarca.Enabled = true;
            txtCodGrupo.Enabled = true;
            chkTodas.Enabled = true;
            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
        }

        public override void Salvar()
        {
            aLista.Cod = Convert.ToInt32(txtCod.Text);
            aLista.NomeLista = txtNomeLista.Text;
            aLista.DescontoMaximo = Convert.ToDouble(txtDescMax.Text);
            aLista.MargemLucro = Convert.ToDouble(txtMargemLucro.Text);
            aLista.CodMarca = Convert.ToInt32(txtCodMarca.Text);
            aLista.CodGrupo = Convert.ToInt32(txtCodGrupo.Text);
            aLista.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            aLista.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            aLista.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);
        }
    }
}
