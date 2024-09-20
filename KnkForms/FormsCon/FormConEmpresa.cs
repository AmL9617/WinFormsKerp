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
    public partial class FormConEmpresa : KnkForms.FormsCon.FormConPai
    {
        FormCadEmpresa oFormCadEmpresa;
        Empresas aEmpresa;
        public FormConEmpresa()
        {
            InitializeComponent();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadEmpresa = (FormCadEmpresa)form;
        }

        public override void ConhecaObj(Object obj)
        {
            aEmpresa = (Empresas)obj;
        }

        protected override void Incluir()
        {
            oFormCadEmpresa.ConhecaObj(aEmpresa);
            oFormCadEmpresa.LimpaTxt();
            oFormCadEmpresa.ShowDialog();
        }

        protected override void Alterar()
        {
            oFormCadEmpresa.LimpaTxt();
            oFormCadEmpresa.CarregaTxt();
            oFormCadEmpresa.ShowDialog();
        }

        protected override void Excluir()
        {
            oFormCadEmpresa.LimpaTxt();
            oFormCadEmpresa.ConhecaObj(aEmpresa);
            oFormCadEmpresa.CarregaTxt();
            oFormCadEmpresa.BloqueiaTxt();
            oFormCadEmpresa.ShowDialog();
            oFormCadEmpresa.DesbloqueiaTxt();
        }

    }
}
