using System;
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
        FormConClientes oFrmConClientes;
        char SalvarAlterar = '\0';
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
            txtFornCliente.Clear();
            txtTipo.Clear();
            txtContato.Clear();
            txtObservacao.Clear();
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
        }

        public void CarregaTxt(string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            txtCod.Text = campo1;
            txtFornCliente.Text = campo2;
            txtTipo.Text = campo3;
            txtContato.Text = campo4;
            txtObservacao.Text = campo5;
            txtCodUser.Text = campo6;
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtFornCliente.Enabled = false;
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
            txtFornCliente.Enabled = true;
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
            oContato.CodFornCliente = Convert.ToInt32(txtFornCliente.Text);
            oContato.Tipo = txtTipo.Text;
            oContato.Contato = txtContato.Text;
            oContato.Observacao = txtObservacao.Text;
            oContato.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            oContato.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            oContato.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);

            if (SalvarAlterar == 'A')
                oContato.AlterarBD(oContato.Cod);
            else
                oContato.SalvarBD();
            SalvarAlterar = '\0';
            txtCod.Enabled = true;
            Close();
        }
        public void setFrmConClientes(Object obj)
        {
            oFrmConClientes = (FormConClientes)obj;
        }
        private void btnConsultaCid_Click(object sender, EventArgs e)
        {
            oFrmConClientes.ConhecaObj(oContato.Clientes);
            oFrmConClientes.ShowDialog();
        }
    }
}
