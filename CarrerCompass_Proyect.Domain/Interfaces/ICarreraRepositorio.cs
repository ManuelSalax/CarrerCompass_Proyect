using CarrerCompass_Proyect.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerCompass_Proyect.Domain.Interfaces
{
    public interface ICarreraRepositorio
    {
        Carrera ObtenerPorId(int id);
        IEnumerable<Carrera> ObtenerTodas();
        void Guardar(Carrera carrera);
    }
}

