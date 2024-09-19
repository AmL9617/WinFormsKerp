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
    public partial class FormConRamoAtividade : KnkForms.FormsCon.FormConPai
    {
        FormCadRamoAtividade oFormCadRamoAtividade;
        RamoAtividades oRamoAtividade;
        public FormConRamoAtividade()
        {
            InitializeComponent();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadRamoAtividade = (FormCadRamoAtividade)form;
        }

        public override void ConhecaObj(Object obj)
        {
            oRamoAtividade = (RamoAtividades)obj;
        }

        protected override void Incluir()
        {
            oFormCadRamoAtividade.ConhecaObj(oRamoAtividade);
            oFormCadRamoAtividade.LimpaTxt();
            oFormCadRamoAtividade.ShowDialog();
        }

        protected override void Alterar()
        {
            oFormCadRamoAtividade.LimpaTxt();
            oFormCadRamoAtividade.CarregaTxt();
            oFormCadRamoAtividade.ShowDialog();
        }

        protected override void Excluir()
        {
            oFormCadRamoAtividade.LimpaTxt();
            oFormCadRamoAtividade.ConhecaObj(oRamoAtividade);
            oFormCadRamoAtividade.CarregaTxt();
            oFormCadRamoAtividade.BloqueiaTxt();
            oFormCadRamoAtividade.ShowDialog();
            oFormCadRamoAtividade.DesbloqueiaTxt();
        }
    }
}
