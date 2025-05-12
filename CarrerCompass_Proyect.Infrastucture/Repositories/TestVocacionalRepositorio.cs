using CarrerCompass_Proyect.Domain.Entities;
using CarrerCompass_Proyect.Domain.Interfaces;
using CarrerCompass_Proyect.Infrastucture.DbData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerCompass_Proyect.Infrastucture.Repositories
{
    public class TestVocacionalRepositorio : ITestVocacionalRepositorio
    {
        private readonly AppDbContext _context;

        public TestVocacionalRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public TestVocacional ObtenerPorId(int id)
        {
            return _context.TestsVocacionales.Find(id);
        }

        public IEnumerable<TestVocacional> ObtenerPorEstudianteId(int estudianteId)
        {
            return _context.TestsVocacionales
                .Where(t => t.EstudianteId == estudianteId)
                .OrderByDescending(t => t.FechaRealizacion)
                .ToList();
        }

        public void Guardar(TestVocacional test)
        {
            _context.TestsVocacionales.Add(test);
            _context.SaveChanges();
        }
    }
}
