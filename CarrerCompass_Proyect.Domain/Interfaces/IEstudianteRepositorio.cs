using CarrerCompass_Proyect.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerCompass_Proyect.Domain.Interfaces
{
    public interface IEstudianteRepositorio
    {
        Estudiante ObtenerPorId(int id);
        Estudiante ObtenerPorCorreo(string correo);
        IEnumerable<Estudiante> ObtenerTodos();
        void Guardar(Estudiante estudiante);
        void Actualizar(Estudiante estudiante);
        void Eliminar(int id);
    }
}

