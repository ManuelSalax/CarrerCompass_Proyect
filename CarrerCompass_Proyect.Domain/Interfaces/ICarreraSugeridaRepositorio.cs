using CarrerCompass_Proyect.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerCompass_Proyect.Domain.Interfaces
{
    public interface ICarreraSugeridaRepositorio
    {
        IEnumerable<CarreraSugerida> ObtenerPorEstudianteId(int estudianteId);
        void Guardar(CarreraSugerida sugerencia);
        void EliminarPorEstudianteId(int estudianteId);
    }
}

