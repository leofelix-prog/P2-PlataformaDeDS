using System;
using System.Collections.Generic;
using System.Text;

namespace SalaDeReunioes.Models
{
    internal class Sala
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Andar { get; set; }
        public int QtddAssentos { get; set; }
    }
}
