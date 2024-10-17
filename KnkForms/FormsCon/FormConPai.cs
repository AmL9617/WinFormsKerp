using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KnkForms.FormsCon
{
    public partial class FormConPai : FormPai
    {
        public FormConPai()
        {
            InitializeComponent();
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
