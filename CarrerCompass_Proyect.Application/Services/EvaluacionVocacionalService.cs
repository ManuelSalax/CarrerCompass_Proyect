using CarrerCompass_Proyect.Application.Models;
using CarrerCompass_Proyect.Domain.Entities;
using CarrerCompass_Proyect.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerCompass_Proyect.Application.Services
{
    public class EvaluacionVocacionalService
    {
        private readonly ICarreraRepositorio _carreraRepo;
        private readonly ICarreraSugeridaRepositorio _sugeridaRepo;

        public EvaluacionVocacionalService(
            ICarreraRepositorio carreraRepo,
            ICarreraSugeridaRepositorio sugeridaRepo)
        {
            _carreraRepo = carreraRepo;
            _sugeridaRepo = sugeridaRepo;
        }

        public List<Carrera> EvaluarFormulario(int estudianteId, FormularioCareerCompass formulario)
        {
            var carreras = _carreraRepo.ObtenerTodas();
            var sugeridas = new List<Carrera>();

            foreach (var carrera in carreras)
            {
                // Lógica básica: si el área de la carrera coincide con algún área seleccionada por el estudiante
                if (formulario.AreasInteresSeleccionadas.Any(area =>
                    carrera.Area.Contains(area, StringComparison.OrdinalIgnoreCase)))
                {
                    int puntaje = 80; // Valor fijo, puedes ajustarlo con lógica más avanzada
                    var sugerencia = new CarreraSugerida(estudianteId, carrera.Id, puntaje);
                    _sugeridaRepo.Guardar(sugerencia);
                    sugeridas.Add(carrera);
                }
            }

            return sugeridas;
        }
    }
}
