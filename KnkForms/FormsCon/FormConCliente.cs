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
    public partial class FormConCliente : KnkForms.FormsCon.FormConPai
    {
        FormCadCliente oFormCadCliente;
        Clientes oCliente;
        public FormConCliente()
        {
            InitializeComponent();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadCliente = (FormCadCliente)form;
        }

        public override void ConhecaObj(Object obj)
        {
            oCliente = (Clientes)obj;
        }

        protected override void Incluir()
        {
            oFormCadCliente.ConhecaObj(oCliente);
            oFormCadCliente.LimpaTxt();
            oFormCadCliente.ShowDialog();
        }

        protected override void Alterar()
        {
            oFormCadCliente.LimpaTxt();
            oFormCadCliente.CarregaTxt();
            oFormCadCliente.ShowDialog();
        }

        protected override void Excluir()
        {
            oFormCadCliente.LimpaTxt();
            oFormCadCliente.ConhecaObj(oCliente);
            oFormCadCliente.CarregaTxt();
            oFormCadCliente.BloqueiaTxt();
            oFormCadCliente.ShowDialog();
            oFormCadCliente.DesbloqueiaTxt();
        }

    }
}
