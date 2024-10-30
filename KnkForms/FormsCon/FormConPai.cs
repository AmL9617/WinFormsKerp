using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static KnkForms.Interfaces;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KnkForms.FormsCon
{
    public partial class FormConPai : FormPai
    {
        //TESTE
        private readonly IConsultas _consultas;
        private readonly string _tipo;

        public FormConPai(/*IConsultas consultas, string tipo*/)
        {
            InitializeComponent();
            //_consultas = consultas;
            //_tipo = tipo;
        }
        //TESTE
        protected void listView_DoubleClick(object sender, EventArgs e)
        {
            if (listVConsulta.SelectedItems.Count > 0)
            {
                string selectedID = listVConsulta.SelectedItems[0].SubItems[0].Text;
                _consultas.SetConsultaId(selectedID, _tipo);
                this.Close();
            }
        }
        protected virtual void CarregaLV()
        {

        }

        protected virtual void Incluir()
        {

        }

        protected virtual void Alterar()
        {

        }

        protected virtual void Excluir()
        {

        }

        protected virtual void Pesquisar()
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        public virtual void SetFrmCadastro(Object form)
        {

        }

        public virtual void ConhecaObj(Object obj)
        {

        }
    }
}
