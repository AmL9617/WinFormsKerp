using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    public class Estados:Pai
    {
        public string NomeEstado { get; set; }
        public char Sigla { get; set; }
        public bool Ativo { get; set; }

        public int pais { get; set; } //Por enquanto int para depois 
        //implementar get que retorna todos os dados
        //public Paises pais { get; set; }
    }
}
