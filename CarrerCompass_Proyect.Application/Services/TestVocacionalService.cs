using CarrerCompass_Proyect.Domain.Entities;
using CarrerCompass_Proyect.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerCompass_Proyect.Application.Services
{
    public class TestVocacionalService
    {
        private readonly ITestVocacionalRepositorio _testRepo;
        private readonly IEstudianteRepositorio _estudianteRepo;

        public TestVocacionalService(
            ITestVocacionalRepositorio testRepo,
            IEstudianteRepositorio estudianteRepo)
        {
            _testRepo = testRepo;
            _estudianteRepo = estudianteRepo;
        }

        public void RealizarTest(int estudianteId, int puntaje, string codigoResultado)
        {
            var estudiante = _estudianteRepo.ObtenerPorId(estudianteId);
            if (estudiante == null)
                throw new Exception("Estudiante no encontrado.");

            var test = new TestVocacional(estudianteId, puntaje, codigoResultado);
            _testRepo.Guardar(test);

            estudiante.AsignarResultadoTest(test);
            _estudianteRepo.Actualizar(estudiante);
        }

        public IEnumerable<TestVocacional> ObtenerHistorial(int estudianteId)
        {
            return _testRepo.ObtenerPorEstudianteId(estudianteId);
        }
    }
}
