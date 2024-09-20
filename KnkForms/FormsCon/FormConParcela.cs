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
    public partial class FormConParcela : KnkForms.FormsCon.FormConPai
    {
        FormCadParcela oFormCadParcela;
        Parcelas aParcela;
        public FormConParcela()
        {
            InitializeComponent();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadParcela = (FormCadParcela)form;
        }

        public override void ConhecaObj(Object obj)
        {
            aParcela = (Parcelas)obj;
        }

        protected override void Incluir()
        {
            oFormCadParcela.ConhecaObj(aParcela);
            oFormCadParcela.LimpaTxt();
            oFormCadParcela.ShowDialog();
        }

        protected override void Alterar()
        {
            oFormCadParcela.LimpaTxt();
            oFormCadParcela.CarregaTxt();
            oFormCadParcela.ShowDialog();
        }

        protected override void Excluir()
        {
            oFormCadParcela.LimpaTxt();
            oFormCadParcela.ConhecaObj(aParcela);
            oFormCadParcela.CarregaTxt();
            oFormCadParcela.BloqueiaTxt();
            oFormCadParcela.ShowDialog();
            oFormCadParcela.DesbloqueiaTxt();
        }

    }
}
