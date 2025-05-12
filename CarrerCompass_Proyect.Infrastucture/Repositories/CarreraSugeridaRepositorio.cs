using CarrerCompass_Proyect.Domain.Entities;
using CarrerCompass_Proyect.Domain.Interfaces;
using CarrerCompass_Proyect.Infrastucture.DbData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerCompass_Proyect.Infrastucture.Repositories
{
    public class CarreraSugeridaRepositorio : ICarreraSugeridaRepositorio
    {
        private readonly AppDbContext _context;

        public CarreraSugeridaRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<CarreraSugerida> ObtenerPorEstudianteId(int estudianteId)
        {
            return _context.CarrerasSugeridas
                .Include(cs => cs.Carrera)
                .Where(cs => cs.EstudianteId == estudianteId)
                .ToList();
        }

        public void Guardar(CarreraSugerida sugerencia)
        {
            _context.CarrerasSugeridas.Add(sugerencia);
            _context.SaveChanges();
        }

        public void EliminarPorEstudianteId(int estudianteId)
        {
            var sugerencias = _context.CarrerasSugeridas
                .Where(cs => cs.EstudianteId == estudianteId)
                .ToList();

            _context.CarrerasSugeridas.RemoveRange(sugerencias);
            _context.SaveChanges();
        }
    }
}
