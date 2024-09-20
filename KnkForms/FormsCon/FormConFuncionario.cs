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
    public partial class FormConFuncionario : KnkForms.FormsCon.FormConPai
    {
        FormCadFuncionario oFormCadFuncionario;
        Funcionarios oFuncionario;
        public FormConFuncionario()
        {
            InitializeComponent();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadFuncionario = (FormCadFuncionario)form;
        }

        public override void ConhecaObj(Object obj)
        {
            oFuncionario = (Funcionarios)obj;
        }

        protected override void Incluir()
        {
            oFormCadFuncionario.ConhecaObj(oFuncionario);
            oFormCadFuncionario.LimpaTxt();
            oFormCadFuncionario.ShowDialog();
        }

        protected override void Alterar()
        {
            oFormCadFuncionario.LimpaTxt();
            oFormCadFuncionario.CarregaTxt();
            oFormCadFuncionario.ShowDialog();
        }

        protected override void Excluir()
        {
            oFormCadFuncionario.LimpaTxt();
            oFormCadFuncionario.ConhecaObj(oFuncionario);
            oFormCadFuncionario.CarregaTxt();
            oFormCadFuncionario.BloqueiaTxt();
            oFormCadFuncionario.ShowDialog();
            oFormCadFuncionario.DesbloqueiaTxt();
        }

    }
}
