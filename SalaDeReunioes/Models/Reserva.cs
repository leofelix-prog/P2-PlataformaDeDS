using System;
using System.Collections.Generic;
using System.Text;

namespace SalaDeReunioes.Models
{
    internal class Reserva
    {
        public int Id { get; set; }
        public int SalaId { get; set; }
        public string NomeSala { get; set; }
        public int AndarSala { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public DateTime? DataCadastro { get; set; }
    }
}
