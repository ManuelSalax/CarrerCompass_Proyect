using CarrerCompass_Proyect.Domain.Entities;
using CarrerCompass_Proyect.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerCompass_Proyect.Application.Services
{
    public class CarreraService
    {
        private readonly ICarreraRepositorio _carreraRepo;
        private readonly ICarreraSugeridaRepositorio _sugeridaRepo;

        public CarreraService(
            ICarreraRepositorio carreraRepo,
            ICarreraSugeridaRepositorio sugeridaRepo)
        {
            _carreraRepo = carreraRepo;
            _sugeridaRepo = sugeridaRepo;
        }

        public IEnumerable<Carrera> ObtenerTodas()
        {
            return _carreraRepo.ObtenerTodas();
        }

        public IEnumerable<CarreraSugerida> SugerirCarreras(int estudianteId, string codigoResultado)
        {
            var carreras = _carreraRepo.ObtenerTodas();
            var sugeridas = new List<CarreraSugerida>();

            foreach (var carrera in carreras)
            {
                if (carrera.Area.Contains(codigoResultado, StringComparison.OrdinalIgnoreCase))
                {
                    var sugerencia = new CarreraSugerida(estudianteId, carrera, puntaje: 85);
                    _sugeridaRepo.Guardar(sugerencia);
                    sugeridas.Add(sugerencia);
                }
            }

            return sugeridas;
        }

        public IEnumerable<CarreraSugerida> ObtenerSugeridasPorEstudiante(int estudianteId)
        {
            return _sugeridaRepo.ObtenerPorEstudianteId(estudianteId);
        }
    }
}
