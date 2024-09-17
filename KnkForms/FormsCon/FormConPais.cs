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
    public partial class FormConPais : KnkForms.FormsCon.FormConPai
    {
        FormCadPais oFormCadPais;
        public FormConPais()
        {
            InitializeComponent();
        }
        public override void SetFrmCad(Object form)
        {
            oFormCadPais = (FormCadPais)form;
        }
        protected override void Incluir()
        {
            
        }

        protected override void Alterar()
        {

        }

        protected override void Excluir()
        {

        }
    }
}
