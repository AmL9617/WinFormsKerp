using KnkForms.Classes;
using KnkForms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KnkForms.FormsCad;

namespace KnkForms.FormsCon
{
    public partial class FormConContatos : KnkForms.FormsCon.FormConPai
    {
        FormCadContato oFormCadContato;
        Contatos oContato;
        
        public FormConContatos()
        {
            InitializeComponent();
        }
        
        public override void SetFrmCadastro(Object form)
        {
            oFormCadContato = (FormCadContato)form;
        }

        public override void ConhecaObj(Object obj)
        {
            oContato = (Contatos)obj;
        }

        protected override void Incluir()
        {
            oFormCadContato.ConhecaObj(oContato);
            oFormCadContato.LimpaTxt();
            oFormCadContato.ShowDialog();
        }

        protected override void Alterar()
        {
            oFormCadContato.LimpaTxt();
            oFormCadContato.CarregaTxt();
            oFormCadContato.ShowDialog();
        }

        protected override void Excluir()
        {
            oFormCadContato.LimpaTxt();
            oFormCadContato.ConhecaObj(oContato);
            oFormCadContato.CarregaTxt();
            oFormCadContato.BloqueiaTxt();
            oFormCadContato.ShowDialog();
            oFormCadContato.DesbloqueiaTxt();
        }
    }
}
