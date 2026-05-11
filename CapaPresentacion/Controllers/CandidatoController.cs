using Microsoft.AspNetCore.Mvc;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion.Controllers
{
    public class CandidatoController : Controller
    {
        CandidatoNegocio objNegocio = new CandidatoNegocio();
        VotoNegocio votoNegocio = new VotoNegocio();

        public IActionResult Index()
        {
            var lista = objNegocio.Listar();

            return View(lista);
        }

        public IActionResult Votar(int id)
        {
            Voto v = new Voto();

            v.IdEstudiante = 1;
            v.IdCandidato = id;

            bool respuesta = votoNegocio.Registrar(v);

            if (respuesta == true)
            {
                ViewBag.Mensaje = "Voto registrado correctamente";
            }
            else
            {
                ViewBag.Mensaje = "Usted ya votó";
            }

            return View();
        }
    }
}