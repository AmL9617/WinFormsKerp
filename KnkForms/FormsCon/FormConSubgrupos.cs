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
    public partial class FormConSubgrupos : KnkForms.FormsCon.FormConPai
    {
        Subgrupos oSubgrupo;
        FormCadSubgrupo oFormCadSubgrupo;
        public FormConSubgrupos()
        {
            InitializeComponent();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadSubgrupo = (FormCadSubgrupo)form;
        }

        public override void ConhecaObj(Object obj)
        {
            oSubgrupo = (Subgrupos)obj;
        }

        protected override void Incluir()
        {
            oFormCadSubgrupo.ConhecaObj(oSubgrupo);
            oFormCadSubgrupo.LimpaTxt();
            oFormCadSubgrupo.ShowDialog();
        }

        protected override void Alterar()
        {
            oFormCadSubgrupo.LimpaTxt();
            oFormCadSubgrupo.CarregaTxt();
            oFormCadSubgrupo.ShowDialog();
        }

        protected override void Excluir()
        {
            oFormCadSubgrupo.LimpaTxt();
            oFormCadSubgrupo.ConhecaObj(oSubgrupo);
            oFormCadSubgrupo.CarregaTxt();
            oFormCadSubgrupo.BloqueiaTxt();
            oFormCadSubgrupo.ShowDialog();
            oFormCadSubgrupo.DesbloqueiaTxt();
        }
    }
}
