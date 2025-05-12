using CarrerCompass_Proyect.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarrerCompass_Proyect.Controllers
{
    public class TestController : Controller
    {
        private readonly EstudianteService _estudianteService;
        private readonly TestVocacionalService _testService;
        private readonly CarreraService _carreraService;

        public TestController(
            EstudianteService estudianteService,
            TestVocacionalService testService,
            CarreraService carreraService)
        {
            _estudianteService = estudianteService;
            _testService = testService;
            _carreraService = carreraService;
        }

        // Mostrar formulario del test
        public IActionResult RealizarTest(int estudianteId)
        {
            ViewBag.EstudianteId = estudianteId;
            return View(); // Views/Test/RealizarTest.cshtml
        }

        // Procesar resultado del test
        [HttpPost]
        public IActionResult RealizarTest(int estudianteId, int puntaje, string codigoResultado)
        {
            _testService.RealizarTest(estudianteId, puntaje, codigoResultado);
            _carreraService.SugerirCarreras(estudianteId, codigoResultado);
            return RedirectToAction("Resultados", new { estudianteId });
        }

        // Ver resultados de carreras sugeridas
        public IActionResult Resultados(int estudianteId)
        {
            var carreras = _carreraService.ObtenerSugeridasPorEstudiante(estudianteId);
            ViewBag.Estudiante = _estudianteService.ObtenerPorId(estudianteId);
            return View(carreras); // Views/Test/Resultados.cshtml
        }
    }
}
