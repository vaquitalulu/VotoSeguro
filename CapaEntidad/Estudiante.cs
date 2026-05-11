using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidad
{
    public class Estudiante
    {
        public int IdEstudiante { get; set; }
        public string Nombre { get; set; }
        public string Dni { get; set; }
        public string Clave { get; set; }
        public bool YaVoto { get; set; }
        public int IdColegio { get; set; }
    }
}
