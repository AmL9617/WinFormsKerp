using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KnkForms.Classes;
using KnkForms.Forms;
using KnkForms.FormsCon;

namespace KnkForms
{
    public partial class FormPrincipal : FormPai
    {
        Interfaces aInter;
        Paises oPais;
        public FormPrincipal()
        {
            InitializeComponent();
            aInter = new Interfaces();
            oPais = new Paises();
        }

        private void cadPaisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaPaises(oPais);
        }
    }
}
