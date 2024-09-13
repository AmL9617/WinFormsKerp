using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Classes
{
    public class Cidades:Pai
    {
        public string NomeCidade { get; set; }
        public int DDD { get; set; }
        public bool Ativo { get; set; }

        public int estado { get; set; } //Por enquanto int para depois 
        //implementar get que retorna todos os dados
        //public Paises pais { get; set; }
    }
}
