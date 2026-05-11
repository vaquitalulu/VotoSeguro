using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class EstudianteNegocio
    {
        EstudianteDatos objDatos = new EstudianteDatos();

        public Estudiante Login(string Dni, string clave)
        {
            return objDatos.Login(Dni, clave);
        }
    }
}