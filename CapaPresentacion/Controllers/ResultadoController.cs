using Microsoft.AspNetCore.Mvc;
using CapaNegocio;

namespace CapaPresentacion.Controllers
{
    public class ResultadoController : Controller
    {
        ResultadoNegocio objNegocio = new ResultadoNegocio();

        public IActionResult Index()
        {

            int idColegio = TempData["IdColegio"] != null
                ? Convert.ToInt32(TempData["IdColegio"])
                : 0;

            TempData.Keep("IdColegio");
            TempData.Keep("Nombre"); 

            var lista = objNegocio.ListarResultados();

            return View(lista);
        }
    }
}