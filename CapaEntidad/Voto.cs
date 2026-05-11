using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidad
{
    public class Voto
    {
        public int IdVoto { get; set; }
        public DateTime Fecha { get; set; }
        public int IdEstudiante { get; set; }
        public int IdCandidato { get; set; }
    }
}
