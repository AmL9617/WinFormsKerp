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
    public partial class FormConGrupos : KnkForms.FormsCon.FormConPai
    {
        FormCadGrupo oFormCadGrupo;
        Grupos oGrupo;
        public FormConGrupos()
        {
            InitializeComponent();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadGrupo = (FormCadGrupo)form;
        }

        public override void ConhecaObj(Object obj)
        {
            oGrupo = (Grupos)obj;
        }

        protected override void Incluir()
        {
            oFormCadGrupo.ConhecaObj(oGrupo);
            oFormCadGrupo.LimpaTxt();
            oFormCadGrupo.ShowDialog();
        }

        protected override void Alterar()
        {
            oFormCadGrupo.LimpaTxt();
            oFormCadGrupo.CarregaTxt();
            oFormCadGrupo.ShowDialog();
        }

        protected override void Excluir()
        {
            oFormCadGrupo.LimpaTxt();
            oFormCadGrupo.ConhecaObj(oGrupo);
            oFormCadGrupo.CarregaTxt();
            oFormCadGrupo.BloqueiaTxt();
            oFormCadGrupo.ShowDialog();
            oFormCadGrupo.DesbloqueiaTxt();
        }

    }
}
