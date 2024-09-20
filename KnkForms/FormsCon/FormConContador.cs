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
    public partial class FormConContador : KnkForms.FormsCon.FormConPai
    {
        FormCadContador oFormCadContador;
        Contadores oContador;
        public FormConContador()
        {
            InitializeComponent();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadContador = (FormCadContador)form;
        }

        public override void ConhecaObj(Object obj)
        {
            oContador = (Contadores)obj;
        }

        protected override void Incluir()
        {
            oFormCadContador.ConhecaObj(oContador);
            oFormCadContador.LimpaTxt();
            oFormCadContador.ShowDialog();
        }

        protected override void Alterar()
        {
            oFormCadContador.LimpaTxt();
            oFormCadContador.CarregaTxt();
            oFormCadContador.ShowDialog();
        }

        protected override void Excluir()
        {
            oFormCadContador.LimpaTxt();
            oFormCadContador.ConhecaObj(oContador);
            oFormCadContador.CarregaTxt();
            oFormCadContador.BloqueiaTxt();
            oFormCadContador.ShowDialog();
            oFormCadContador.DesbloqueiaTxt();
        }

    }
}
