using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    public class ColegioNegocio
    {
        ColegioDatos cd = new ColegioDatos();

        public List<Colegio> Listar()
        {
            return cd.Listar();
        }
    }
}
