using System;
using System.Collections.Generic;

namespace CarrerCompass_Proyect.Domain.Entities
{
    public class Estudiante
    {
        public int Id { get; private set; }
        public string NombreCompleto { get; private set; }
        public string CorreoElectronico { get; private set; }
        public DateTime FechaNacimiento { get; private set; }

        // Relación con sugerencias de carrera
        public List<CarreraSugerida> CarrerasSugeridas { get; private set; } = new();

        public Estudiante(string nombreCompleto, string correoElectronico, DateTime fechaNacimiento)
        {
            NombreCompleto = nombreCompleto;
            CorreoElectronico = correoElectronico;
            FechaNacimiento = fechaNacimiento;
        }

        public void AgregarCarreraSugerida(CarreraSugerida sugerencia)
        {
            CarrerasSugeridas.Add(sugerencia);
        }
    }
}
