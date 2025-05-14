using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerCompass_Proyect.Application.Models
{
    public class FormularioOpciones
    {
        public List<string> Intereses { get; set; } = new();
        public List<string> Habilidades { get; set; } = new();
        public List<string> AreasDeInteres { get; set; } = new();
        public List<string> EstilosDeAprendizaje { get; set; } = new();
        public List<string> PreferenciasLaborales { get; set; } = new();
    }
}
