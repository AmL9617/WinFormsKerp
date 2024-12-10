using KnkForms.Classes;
using KnkForms.FormsCon;
using Mysqlx.Notice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KnkForms.FormsCad
{
    public partial class FormCadRamoAtivCliente : KnkForms.FormCadPai
    {
        RamoAtividadesClientes oRamoAtivClientes;
        FormConClientes oFrmConClientes;
        FormConRamoAtividades oFrmConRamoAtiv;
        char SalvarAlterar = '\0';

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

        public void CarregaTxt(string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            txtCod.Text = campo1;
            txtNomeRamo.Text = campo2;
            txtNomeCliForn.Text = campo3;
            txtCodCliForn.Text = campo4;
            txtPrioridade.Text = campo5;
            txtCodUser.Text = campo6;

            SalvarAlterar = 'A';
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
            oRamoAtivClientes.CodEmpresa = 1;
            oRamoAtivClientes.DataModificacao = DateTime.Now;

            if (SalvarAlterar == 'A')
            {
                //oRamoAtivClientes.DataCadastro = Convert.ToDateTime(txtDataCad.Text);
                oRamoAtivClientes.AlterarBD(oRamoAtivClientes.Cod);
            }
            else
            {
                oRamoAtivClientes.DataCadastro = DateTime.Today;
                oRamoAtivClientes.SalvarBD();
            }

            SalvarAlterar = '\0';
            Close();
        }
        public void SetConsultas(int id, string nome, string tipo)
        {
            if(tipo == "Cliente")
            {
                txtCodCliForn.Text = Convert.ToString(id);
                txtNomeCliForn.Text = nome;
            }
            if(tipo == "RamoAtiv")
            {
                txtCod.Text = Convert.ToString(id);
                txtNomeRamo.Text = nome;
            }
            
        }
        public void setFrmConClientes(Object obj)
        {
            oFrmConClientes = (FormConClientes)obj;
        }
        public void setFrmConRamoAtiv(Object obj)
        {
            oFrmConRamoAtiv = (FormConRamoAtividades)obj;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            oFrmConClientes.ConhecaObj(oRamoAtivClientes.Clientes);
            oFrmConClientes.Owner = this;
            oFrmConClientes.ShowDialog();
        }

        private void btnRamoAtiv_Click(object sender, EventArgs e)
        {
            oFrmConRamoAtiv.ConhecaObj(oRamoAtivClientes.RamoAtiv);
            oFrmConRamoAtiv.Owner = this;
            oFrmConRamoAtiv.ShowDialog();
        }
    }
}

