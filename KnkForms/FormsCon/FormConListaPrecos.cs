using KnkForms.Classes;
using KnkForms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KnkForms.FormsCon
{
    public partial class FormConListaPrecos : KnkForms.FormsCon.FormConPai
    {
        FormCadListaPreco oFormCadListaPreco;
        ListaPrecos aListaPreco;
        public FormConListaPrecos()
        {
            InitializeComponent();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadListaPreco = (FormCadListaPreco)form;
        }

        public override void ConhecaObj(Object obj)
        {
            aListaPreco = (ListaPrecos)obj;
        }

        protected override void Incluir()
        {
            oFormCadListaPreco.ConhecaObj(aListaPreco);
            oFormCadListaPreco.LimpaTxt();
            oFormCadListaPreco.ShowDialog();
        }

        protected override void Alterar()
        {
            oFormCadListaPreco.LimpaTxt();
            oFormCadListaPreco.CarregaTxt();
            oFormCadListaPreco.ShowDialog();
        }

        protected override void Excluir()
        {
            oFormCadListaPreco.LimpaTxt();
            oFormCadListaPreco.ConhecaObj(aListaPreco);
            oFormCadListaPreco.CarregaTxt();
            oFormCadListaPreco.BloqueiaTxt();
            oFormCadListaPreco.ShowDialog();
            oFormCadListaPreco.DesbloqueiaTxt();
        }

    }
}
