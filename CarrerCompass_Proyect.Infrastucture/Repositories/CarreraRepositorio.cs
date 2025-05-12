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
    public class CarreraRepositorio : ICarreraRepositorio
    {
        private readonly AppDbContext _context;

        public CarreraRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Carrera> ObtenerTodas()
        {
            return _context.Carreras.ToList();
        }

        public Carrera ObtenerPorId(int id)
        {
            return _context.Carreras.Find(id);
        }

        public void Guardar(Carrera carrera)
        {
            _context.Carreras.Add(carrera);
            _context.SaveChanges();
        }
    }
}
