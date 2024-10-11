using KnkForms.Classes;
using KnkForms.FormsCon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KnkForms.FormsCad
{
    public partial class FormCadRamoAtivCliente : KnkForms.Forms.FormCadRamoAtividade
    {
        RamoAtividadesClientes oRamoAtivClientes;
        FormConClientes oFrmConClientes;
       
        public FormCadRamoAtivCliente()
        {
            InitializeComponent();
        }
        
        public override void ConhecaObj(Object obj)
        {
            oRamoAtivClientes = (RamoAtividadesClientes)obj;
        }

        public override void LimpaTxt()
        {
            txtCod.Clear();
            txtCodCliForn.Clear();
            txtPrioridade.Clear();
            txtCodUser.Clear();
            txtDataCad.Clear();
            txtDataAlt.Clear();
        }

        public override void CarregaTxt()
        {
            txtCod.Text = Convert.ToString(oRamoAtivClientes.Cod);
            txtCodCliForn.Text = Convert.ToString(oRamoAtivClientes.CodClienteFornecedor);
            txtPrioridade.Text = Convert.ToString(oRamoAtivClientes.Prioridade);
            txtCodUser.Text = Convert.ToString(oRamoAtivClientes.CodEmpresa);
            txtDataCad.Text = Convert.ToString(oRamoAtivClientes.DataCadastro);
            txtDataAlt.Text = Convert.ToString(oRamoAtivClientes.DataModificacao);
        }

        public override void BloqueiaTxt()
        {
            txtCod.Enabled = false;
            txtCodCliForn.Enabled = false;
            txtPrioridade.Enabled = false;
            txtCodUser.Enabled = false;
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            txtCod.Enabled = true;
            txtCodCliForn.Enabled = true;
            txtPrioridade.Enabled = true;
            txtCodUser.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataAlt.Enabled = true;
        }

        public override void Salvar()
        {
            oRamoAtivClientes.Cod = Convert.ToInt32(txtCod.Text);
            oRamoAtivClientes.CodClienteFornecedor = Convert.ToInt32(txtCodCliForn.Text);
            oRamoAtivClientes.Prioridade = Convert.ToInt32(txtPrioridade.Text);
            oRamoAtivClientes.CodEmpresa = Convert.ToInt32(txtCodUser.Text);
            oRamoAtivClientes.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
            oRamoAtivClientes.DataModificacao = Convert.ToDateTime(txtDataAlt.Text);
        }
        public void setFrmConClientes(Object obj)
        {
            oFrmConClientes = (FormConClientes)obj;
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            oFrmConClientes.ConhecaObj(oRamoAtivClientes.Clientes);
            oFrmConClientes.ShowDialog();
        }
    }
}

