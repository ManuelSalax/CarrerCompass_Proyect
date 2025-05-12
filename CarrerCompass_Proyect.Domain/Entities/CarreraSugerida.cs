using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerCompass_Proyect.Domain.Entities
{
    public class CarreraSugerida
    {
        public int Id { get; private set; }
        public int EstudianteId { get; private set; }
        public int CarreraId { get; private set; }
        public int Puntaje { get; private set; }

        public Carrera Carrera { get; private set; }

        public CarreraSugerida(int estudianteId, Carrera carrera, int puntaje)
        {
            EstudianteId = estudianteId;
            CarreraId = carrera.Id;
            Carrera = carrera;
            Puntaje = puntaje;
        }
    }
}

