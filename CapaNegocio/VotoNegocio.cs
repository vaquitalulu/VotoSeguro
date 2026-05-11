using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class VotoNegocio
    {
        VotoDatos objDatos = new VotoDatos();

        public bool Registrar(Voto v)
        {
            return objDatos.Registrar(v);
        }
    }
}