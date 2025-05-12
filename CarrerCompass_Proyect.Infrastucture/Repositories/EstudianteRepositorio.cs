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
    public class EstudianteRepositorio : IEstudianteRepositorio
    {
        private readonly AppDbContext _context;

        public EstudianteRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public Estudiante ObtenerPorId(int id)
        {
            return _context.Estudiantes
                .Include(e => e.ResultadoTest)
                .Include(e => e.CarrerasSugeridas)
                .ThenInclude(cs => cs.Carrera)
                .FirstOrDefault(e => e.Id == id);
        }

        public Estudiante ObtenerPorCorreo(string correo)
        {
            return _context.Estudiantes
                .Include(e => e.ResultadoTest)
                .Include(e => e.CarrerasSugeridas)
                .ThenInclude(cs => cs.Carrera)
                .FirstOrDefault(e => e.CorreoElectronico == correo);
        }

        public IEnumerable<Estudiante> ObtenerTodos()
        {
            return _context.Estudiantes
                .Include(e => e.ResultadoTest)
                .Include(e => e.CarrerasSugeridas)
                .ThenInclude(cs => cs.Carrera)
                .ToList();
        }

        public void Guardar(Estudiante estudiante)
        {
            _context.Estudiantes.Add(estudiante);
            _context.SaveChanges();
        }

        public void Actualizar(Estudiante estudiante)
        {
            _context.Estudiantes.Update(estudiante);
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var estudiante = ObtenerPorId(id);
            if (estudiante != null)
            {
                _context.Estudiantes.Remove(estudiante);
                _context.SaveChanges();
            }
        }
    }

}
