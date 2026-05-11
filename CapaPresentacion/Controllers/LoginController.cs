using Microsoft.AspNetCore.Mvc;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion.Controllers
{
    public class LoginController : Controller
    {
        EstudianteNegocio objNegocio = new EstudianteNegocio();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string Dni, string clave)
        {
            Estudiante est = objNegocio.Login(Dni, clave);

            if (est.IdEstudiante > 0)
            {
                TempData["Nombre"] = est.Nombre;

                return RedirectToAction("Index", "Candidato");
            }
            else
            {
                ViewBag.Mensaje = "Dni o clave incorrecta";
            }

            return View();
        }
    }
}