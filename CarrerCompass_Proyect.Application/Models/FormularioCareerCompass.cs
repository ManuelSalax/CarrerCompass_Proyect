using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerCompass_Proyect.Application.Models
{
    public class FormularioCareerCompass
    {
        public int EstudianteId { get; set; }

        // Información general (puede ser útil para validaciones o informes)
        public string NombreCompleto { get; set; }
        public int Edad { get; set; }
        public string Grado { get; set; }
        public string InstitucionEducativa { get; set; }
        public string Ciudad { get; set; }

        // Preguntas cerradas con opción múltiple
        public List<string> InteresesSeleccionados { get; set; } = new();
        public List<string> HabilidadesSeleccionadas { get; set; } = new();
        public List<string> AreasInteresSeleccionadas { get; set; } = new();
        public List<string> PreferenciasLaboralesSeleccionadas { get; set; } = new();

        // Pregunta cerrada con única selección
        public string EstiloAprendizaje { get; set; }

        // Preguntas abiertas
        public string ExpectativaCarrera { get; set; }
        public string CarreraEnMente { get; set; }
    }
}
