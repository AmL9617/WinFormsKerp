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
    public partial class FormConEstado : KnkForms.FormsCon.FormConPai
    {
        FormCadEstado oFormCadEstado;
        Estados oEstado;
        public FormConEstado()
        {
            InitializeComponent();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadEstado = (FormCadEstado)form;
        }

        public override void ConhecaObj(Object obj)
        {
            oEstado = (Estados)obj;
        }

        protected override void Incluir()
        {
            oFormCadEstado.ConhecaObj(oEstado);
            oFormCadEstado.LimpaTxt();
            oFormCadEstado.ShowDialog();
        }

        protected override void Alterar()
        {
            oFormCadEstado.LimpaTxt();
            oFormCadEstado.CarregaTxt();
            oFormCadEstado.ShowDialog();
        }

        protected override void Excluir()
        {
            oFormCadEstado.LimpaTxt();
            oFormCadEstado.ConhecaObj(oEstado);
            oFormCadEstado.CarregaTxt();
            oFormCadEstado.BloqueiaTxt();
            oFormCadEstado.ShowDialog();
            oFormCadEstado.DesbloqueiaTxt();
        }

    }
}
