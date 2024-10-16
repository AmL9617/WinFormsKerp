using KnkForms.Classes;
using KnkForms.Forms;
using KnkForms.FormsCad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KnkForms.FormsCon
{
    public partial class FormConListaCodST : KnkForms.FormsCon.FormConPai
    {   
        FormCadListaCodST oFormCadListaCodST;
        ListaCodST aListaCodST;
        public FormConListaCodST()
        {
            InitializeComponent();
        }
        
        public override void SetFrmCadastro(Object form)
        {
            oFormCadListaCodST = (FormCadListaCodST)form;
        }

        public override void ConhecaObj(Object obj)
        {
            aListaCodST = (ListaCodST)obj;
        }

        protected override void Incluir()
        {
            oFormCadListaCodST.ConhecaObj(aListaCodST);
            oFormCadListaCodST.LimpaTxt();
            oFormCadListaCodST.ShowDialog();
        }

        protected override void Alterar()
        {
            oFormCadListaCodST.LimpaTxt();
            oFormCadListaCodST.CarregaTxt();
            oFormCadListaCodST.ShowDialog();
        }

        protected override void Excluir()
        {
            oFormCadListaCodST.LimpaTxt();
            oFormCadListaCodST.ConhecaObj(aListaCodST);
            oFormCadListaCodST.CarregaTxt();
            oFormCadListaCodST.BloqueiaTxt();
            oFormCadListaCodST.ShowDialog();
            oFormCadListaCodST.DesbloqueiaTxt();
        }

    }
}
