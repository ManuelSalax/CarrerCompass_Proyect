using CarrerCompass_Proyect.Application.Services;
using CarrerCompass_Proyect.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CarrerCompass_Proyect.Controllers
{
    public class EstudianteController : Controller
    {
        private readonly EstudianteService _estudianteService;

        public EstudianteController(EstudianteService estudianteService)
        {
            _estudianteService = estudianteService;
        }

        [HttpGet]
        public IActionResult Registrar()
        {
            return View(); // Views/Estudiante/Registrar.cshtml
        }

        [HttpPost]
        public IActionResult Registrar(string nombreCompleto, string correoElectronico, DateTime fechaNacimiento)
        {
            var estudiante = _estudianteService.RegistrarEstudiante(nombreCompleto, correoElectronico, fechaNacimiento);
            return RedirectToAction("Realizar", "Cuestionario", new { estudianteId = estudiante.Id });
        }
    }
}
