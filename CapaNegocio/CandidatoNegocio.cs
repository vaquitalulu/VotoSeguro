using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CandidatoNegocio
    {
        CandidatoDatos objDatos = new CandidatoDatos();

        public List<Candidato> Listar()
        {
            return objDatos.Listar();
        }
    }
}