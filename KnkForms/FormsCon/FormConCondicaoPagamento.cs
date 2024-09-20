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
    public partial class FormConCondicaoPagamento : KnkForms.FormsCon.FormConPai
    {
        FormCadCondicaoPagamento oFormCadCondicaoPagamento;
        CondicaoPagamentos aCondicaoPagamento;
        public FormConCondicaoPagamento()
        {
            InitializeComponent();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadCondicaoPagamento = (FormCadCondicaoPagamento)form;
        }

        public override void ConhecaObj(Object obj)
        {
            aCondicaoPagamento = (CondicaoPagamentos)obj;
        }

        protected override void Incluir()
        {
            oFormCadCondicaoPagamento.ConhecaObj(aCondicaoPagamento);
            oFormCadCondicaoPagamento.LimpaTxt();
            oFormCadCondicaoPagamento.ShowDialog();
        }

        protected override void Alterar()
        {
            oFormCadCondicaoPagamento.LimpaTxt();
            oFormCadCondicaoPagamento.CarregaTxt();
            oFormCadCondicaoPagamento.ShowDialog();
        }

        protected override void Excluir()
        {
            oFormCadCondicaoPagamento.LimpaTxt();
            oFormCadCondicaoPagamento.ConhecaObj(aCondicaoPagamento);
            oFormCadCondicaoPagamento.CarregaTxt();
            oFormCadCondicaoPagamento.BloqueiaTxt();
            oFormCadCondicaoPagamento.ShowDialog();
            oFormCadCondicaoPagamento.DesbloqueiaTxt();
        }

    }
}
