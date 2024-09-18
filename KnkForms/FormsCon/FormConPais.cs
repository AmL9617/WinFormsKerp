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
    public partial class FormConPais : KnkForms.FormsCon.FormConPai
    {
        FormCadPais oFormCadPais;
        Paises oPais;
        public FormConPais()
        {
            InitializeComponent();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadPais = (FormCadPais)form;
        }

        public override void ConhecaObj(Object obj)
        {
            oPais = (Paises)obj;
        }

        protected override void Incluir()
        {
            oFormCadPais.ConhecaObj(oPais);
            oFormCadPais.LimpaTxt();
            oFormCadPais.ShowDialog();
        }

        protected override void Alterar()
        {
            oFormCadPais.LimpaTxt();
            oFormCadPais.CarregaTxt();
            oFormCadPais.ShowDialog();
        }

        protected override void Excluir()
        {
            oFormCadPais.LimpaTxt();
            oFormCadPais.ConhecaObj(oPais);
            oFormCadPais.CarregaTxt();
            oFormCadPais.BloqueiaTxt();
            oFormCadPais.ShowDialog();
            oFormCadPais.DesbloqueiaTxt();
        }

    }
}
