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
    public partial class FormConCidades : KnkForms.FormsCon.FormConPai
    {
        FormCadCidade oFormCadCidade;
        Cidades aCidade;
        public FormConCidades()
        {
            InitializeComponent();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadCidade = (FormCadCidade)form;
        }

        public override void ConhecaObj(Object obj)
        {
            aCidade = (Cidades)obj;
        }

        protected override void Incluir()
        {
            oFormCadCidade.ConhecaObj(aCidade);
            oFormCadCidade.LimpaTxt();
            oFormCadCidade.ShowDialog();
        }

        protected override void Alterar()
        {
            oFormCadCidade.LimpaTxt();
            oFormCadCidade.CarregaTxt();
            oFormCadCidade.ShowDialog();
        }

        protected override void Excluir()
        {
            oFormCadCidade.LimpaTxt();
            oFormCadCidade.ConhecaObj(aCidade);
            oFormCadCidade.CarregaTxt();
            oFormCadCidade.BloqueiaTxt();
            oFormCadCidade.ShowDialog();
            oFormCadCidade.DesbloqueiaTxt();
        }

    }
}
