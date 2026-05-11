using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class ResultadoNegocio
    {
        ResultadoDatos objDatos = new ResultadoDatos();

        public List<Resultado> ListarResultados()
        {
            return objDatos.ListarResultados();
        }
    }
}