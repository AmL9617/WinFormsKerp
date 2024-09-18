using KnkForms.Forms;
using KnkForms.FormsCon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms
{
    internal class Interfaces
    {
        //Consultas
        FormConPais oFormConPais;

        //Cadastros
        FormCadPais oFormCadPais;

        public Interfaces()
        {
            //Consulta
            oFormConPais = new FormConPais();

            //Cadastro
            oFormCadPais = new FormCadPais();

            oFormConPais.SetFrmCadastro(oFormCadPais);
        }

        public void PecaPaises(Object obj)
        {
            oFormConPais.ConhecaObj(obj);
            oFormConPais.ShowDialog();
        }
    }
}
