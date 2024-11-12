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
    public partial class FormConMarcas : KnkForms.FormsCon.FormConPai
    {
        FormCadMarca oFormCadMarca;
        Marcas aMarca;
        public FormConMarcas()
        {
            InitializeComponent();
        }
        public override void SetFrmCadastro(Object form)
        {
            oFormCadMarca = (FormCadMarca)form;
        }

        public override void ConhecaObj(Object obj)
        {
            aMarca = (Marcas)obj;
        }

        protected override void Incluir()
        {
            oFormCadMarca.ConhecaObj(aMarca);
            oFormCadMarca.LimpaTxt();
            oFormCadMarca.ShowDialog();
        }

        protected override void Alterar()
        {
            oFormCadMarca.LimpaTxt();
            oFormCadMarca.CarregaTxt();
            oFormCadMarca.ShowDialog();
        }

        protected override void Excluir()
        {
            oFormCadMarca.LimpaTxt();
            oFormCadMarca.ConhecaObj(aMarca);
            oFormCadMarca.CarregaTxt();
            oFormCadMarca.BloqueiaTxt();
            oFormCadMarca.ShowDialog();
            oFormCadMarca.DesbloqueiaTxt();
        }
        private void listV_DoubleClick(object sender, EventArgs e)
        {
            if (listVConsulta.SelectedItems.Count > 0)
            {
                var selectedItem = listVConsulta.SelectedItems[0];

                int idMarca = Convert.ToInt32(selectedItem.SubItems[0].Text);
                string nomeMarca = (selectedItem.SubItems[2].Text);
                string tipo = "Marca";

                var cadListaPreco = this.Owner as FormCadListaPreco;
                if (cadListaPreco != null)
                {
                    cadListaPreco.SetConsulta(idMarca, nomeMarca, tipo);
                }

                this.Close();
            }
        }
    }
}
