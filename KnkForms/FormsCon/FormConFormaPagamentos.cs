using KnkForms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KnkForms.Classes
{
    public partial class FormConFormaPagamentos : KnkForms.FormsCon.FormConPai
    {
        FormCadFormaPagamento oFormCadFormaPagamento;
        FormaPagamentos aFormaPagamento;
        public FormConFormaPagamentos()
        {
            InitializeComponent();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadFormaPagamento = (FormCadFormaPagamento)form;
        }

        public override void ConhecaObj(Object obj)
        {
            aFormaPagamento = (FormaPagamentos)obj;
        }

        protected override void Incluir()
        {
            oFormCadFormaPagamento.ConhecaObj(aFormaPagamento);
            oFormCadFormaPagamento.LimpaTxt();
            oFormCadFormaPagamento.ShowDialog();
        }

        protected override void Alterar()
        {
            oFormCadFormaPagamento.LimpaTxt();
            oFormCadFormaPagamento.CarregaTxt();
            oFormCadFormaPagamento.ShowDialog();
        }

        protected override void Excluir()
        {
            oFormCadFormaPagamento.LimpaTxt();
            oFormCadFormaPagamento.ConhecaObj(aFormaPagamento);
            oFormCadFormaPagamento.CarregaTxt();
            oFormCadFormaPagamento.BloqueiaTxt();
            oFormCadFormaPagamento.ShowDialog();
            oFormCadFormaPagamento.DesbloqueiaTxt();
        }

    }
}
