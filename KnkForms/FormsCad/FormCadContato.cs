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
            txtCodFornCliente.Clear();
            txtFornCliente.Clear();
            txtTipo.Clear();
            txtContato.Clear();
            txtObservacao.Clear();
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
        }

        public void CarregaTxt(string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string campo7, string campo8)
        {
            txtCod.Text = campo1;
            txtCodFornCliente.Text = campo2;
            txtTipo.Text = campo3;
            txtContato.Text = campo4;
            txtObservacao.Text = campo5;
            txtCodUser.Text = campo6;
            txtDataCad.Text = campo7;
            txtDataAlt.Text = campo8;
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtCodFornCliente.Enabled = false;
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
            txtCodFornCliente.Enabled = true;
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
            
            oContato.CodFornCliente = Convert.ToInt32(txtCodFornCliente.Text);
            oContato.Tipo = txtTipo.Text;
            oContato.Contato = txtContato.Text;
            oContato.Observacao = txtObservacao.Text;
            oContato.CodEmpresa = 1;
            oContato.DataModificacao = DateTime.Now;

            if (SalvarAlterar == 'A')
            {
                oContato.Cod = Convert.ToInt32(txtCod.Text);
                oContato.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
                oContato.AlterarBD(oContato.Cod);
            }

            else
            {
                oContato.DataCadastro = DateTime.Now;
                oContato.SalvarBD();
            }
                
            SalvarAlterar = '\0';

            txtCod.Enabled = true;
            Close();
        }
        public void SetClientes(int idCliente, string nomeCliente)
        {
            txtCodFornCliente.Text = Convert.ToString(idCliente);
            txtFornCliente.Text = nomeCliente;
        }
        public void setFrmConClientes(Object obj)
        {
            oFrmConClientes = (FormConClientes)obj;
        }
        private void btnConsultaCid_Click(object sender, EventArgs e)
        {
            oFrmConClientes.ConhecaObj(oContato.Clientes);
            oFrmConClientes.Owner = this;
            oFrmConClientes.ShowDialog();
        }
    }
}
