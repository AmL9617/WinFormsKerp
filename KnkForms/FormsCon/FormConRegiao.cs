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
    public partial class FormConRegiao : KnkForms.FormsCon.FormConPai
    {
        FormCadRegiao oFormCadRegiao;
        Regioes aRegiao;
        public FormConRegiao()
        {
            InitializeComponent();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadRegiao = (FormCadRegiao)form;
        }

        public override void ConhecaObj(Object obj)
        {
            aRegiao = (Regioes)obj;
        }

        protected override void Incluir()
        {
            oFormCadRegiao.ConhecaObj(aRegiao);
            oFormCadRegiao.LimpaTxt();
            oFormCadRegiao.ShowDialog();
        }

        protected override void Alterar()
        {
            oFormCadRegiao.LimpaTxt();
            oFormCadRegiao.CarregaTxt();
            oFormCadRegiao.ShowDialog();
        }

        protected override void Excluir()
        {
            oFormCadRegiao.LimpaTxt();
            oFormCadRegiao.ConhecaObj(aRegiao);
            oFormCadRegiao.CarregaTxt();
            oFormCadRegiao.BloqueiaTxt();
            oFormCadRegiao.ShowDialog();
            oFormCadRegiao.DesbloqueiaTxt();
        }
    }
}
