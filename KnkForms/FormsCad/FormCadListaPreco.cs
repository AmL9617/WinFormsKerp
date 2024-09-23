using KnkForms.Classes;
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
        FormConGrupos oFrmConGrupos;
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
            txtCod.Text = Convert.ToString(aListaPreco.Cod);
            txtNomeLista.Text = aListaPreco.NomeLista;
            txtDescMax.Text = Convert.ToString(aListaPreco.DescontoMaximo);
            txtMargemLucro.Text = Convert.ToString(aListaPreco.MargemLucro);
            txtCodMarca.Text = Convert.ToString(aListaPreco.CodMarca);
            txtCodGrupo.Text = Convert.ToString(aListaPreco.CodGrupo);
            txtCodUser.Text = Convert.ToString(aListaPreco.CodEmpresa);
            txtDataCad.Text = Convert.ToString(aListaPreco.DataCadastro);
            txtDataAlt.Text = Convert.ToString(aListaPreco.DataModificacao);
            chkTodas.Checked = aListaPreco.Todas;
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
            aListaPreco.Cod = Convert.ToInt32(txtCod.Text);
            aListaPreco.NomeLista = txtNomeLista.Text;
            aListaPreco.DescontoMaximo = Convert.ToDouble(txtDescMax.Text);
            aListaPreco.MargemLucro = Convert.ToDouble(txtMargemLucro.Text);
            aListaPreco.CodMarca = Convert.ToInt32(txtCodMarca.Text);
            aListaPreco.CodGrupo = Convert.ToInt32(txtCodGrupo.Text);
            aListaPreco.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            aListaPreco.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            aListaPreco.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);
        }
        public void setFrmConMarcas(Object obj)
        {
            oFrmConMarcas = (FormConMarcas)obj;
        }
        public void setFrmConGrupos(Object obj)
        {
            oFrmConGrupos = (FormConGrupos)obj;
        }
        private void btnConsultaMarca_Click(object sender, EventArgs e)
        {
            oFrmConMarcas.ConhecaObj(aListaPreco.Marcas);
            oFrmConMarcas.ShowDialog();
        }

        private void btnConsultaGrupo_Click(object sender, EventArgs e)
        {
            oFrmConGrupos.ConhecaObj(aListaPreco.Grupos);
            oFrmConGrupos.ShowDialog();
        }
    }
}
