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
    public partial class FormConMarca : KnkForms.FormsCon.FormConPai
    {
        FormCadMarca oFormCadMarca;
        Marcas aMarca;
        public FormConMarca()
        {
            InitializeComponent();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadMarca = (FormCadMarca)form;
        }

        public override void ConhecaObj(Object obj)
        {
            aMarca = (Marcas)obj;
        }

        protected override void Incluir()
        {
            oFormCadMarca.ConhecaObj(aMarca);
            oFormCadMarca.LimpaTxt();
            oFormCadMarca.ShowDialog();
        }

        protected override void Alterar()
        {
            oFormCadMarca.LimpaTxt();
            oFormCadMarca.CarregaTxt();
            oFormCadMarca.ShowDialog();
        }

        protected override void Excluir()
        {
            oFormCadMarca.LimpaTxt();
            oFormCadMarca.ConhecaObj(aMarca);
            oFormCadMarca.CarregaTxt();
            oFormCadMarca.BloqueiaTxt();
            oFormCadMarca.ShowDialog();
            oFormCadMarca.DesbloqueiaTxt();
        }

    }
}
