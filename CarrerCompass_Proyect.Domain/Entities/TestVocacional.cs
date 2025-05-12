using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerCompass_Proyect.Domain.Entities
{
    public class TestVocacional
    {
        public int Id { get; private set; }
        public int EstudianteId { get; private set; }
        public DateTime FechaRealizacion { get; private set; }
        public int Puntaje { get; private set; }
        public string CodigoResultado { get; private set; }

        public TestVocacional(int estudianteId, int puntaje, string codigoResultado)
        {
            EstudianteId = estudianteId;
            FechaRealizacion = DateTime.Now;
            Puntaje = puntaje;
            CodigoResultado = codigoResultado;
        }
    }
}

