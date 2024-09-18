using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KnkForms.Classes;
using Newtonsoft.Json;
using KnkForms.Forms;

namespace KnkForms
{
    public partial class FormCadPai : FormPai
    {
        public FormCadPai()
        {
            InitializeComponent();
        }

        public virtual void ConhecaObj(Object obj)
        {

        }
        public virtual void LimpaTxt()
        {

        }
        public virtual void CarregaTxt()
        {

        }
        public virtual void BloqueiaTxt()
        {

        }
        public virtual void DesbloqueiaTxt()
        {

        }

        public virtual void Salvar()
        {

        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
