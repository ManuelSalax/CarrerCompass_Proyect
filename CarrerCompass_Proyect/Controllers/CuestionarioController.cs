using CarrerCompass_Proyect.Application.Models;
using CarrerCompass_Proyect.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarrerCompass_Proyect.Controllers
{
    public class CuestionarioController : Controller
    {
        private readonly FormularioVocacionalService _formularioService;
        private readonly EvaluacionVocacionalService _evaluacionService;
        private readonly EstudianteService _estudianteService;

        public CuestionarioController(
            FormularioVocacionalService formularioService,
            EvaluacionVocacionalService evaluacionService,
            EstudianteService estudianteService)
        {
            _formularioService = formularioService;
            _evaluacionService = evaluacionService;
            _estudianteService = estudianteService;
        }

        // GET: /Cuestionario/Realizar?estudianteId=1
        [HttpGet]
        public IActionResult Realizar(int estudianteId)
        {
            var estudiante = _estudianteService.ObtenerPorId(estudianteId);
            if (estudiante == null)
            {
                TempData["Error"] = "Debes registrarte antes de completar el cuestionario.";
                return RedirectToAction("Registrar", "Estudiante");
            }

            var opciones = _formularioService.ObtenerOpciones();
            ViewBag.EstudianteId = estudianteId;
            ViewBag.EstudianteNombre = estudiante.NombreCompleto;
            return View(opciones); // Muestra la vista Realizar.cshtml
        }

        // POST: /Cuestionario/Procesar
        [HttpPost]
        public IActionResult Procesar(FormularioCareerCompass formulario)
        {
            var estudiante = _estudianteService.ObtenerPorId(formulario.EstudianteId);
            if (estudiante == null)
            {
                TempData["Error"] = "No se encontró el estudiante. Debes registrarte primero.";
                return RedirectToAction("Registrar", "Estudiante");
            }

            var sugerencias = _evaluacionService.EvaluarFormulario(formulario.EstudianteId, formulario);

            ViewBag.EstudianteNombre = estudiante.NombreCompleto;
            return View("Resultado", sugerencias); // Muestra Resultado.cshtml
        }
    }
}
