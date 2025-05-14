using CarrerCompass_Proyect.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerCompass_Proyect.Application.Services
{
    public class FormularioVocacionalService
    {
        public FormularioOpciones ObtenerOpciones()
        {
            return new FormularioOpciones
            {
                Intereses = new List<string>
                {
                    "Resolver problemas matemáticos o lógicos",
                    "Leer libros o escribir textos",
                    "Armar o reparar objetos electrónicos",
                    "Trabajar con animales o plantas",
                    "Organizar eventos o actividades",
                    "Debatir sobre temas sociales o políticos",
                    "Crear diseños, dibujos o contenido audiovisual",
                    "Cuidar o ayudar a otras personas",
                    "Realizar experimentos o investigaciones"
                },

                Habilidades = new List<string>
                {
                    "Comunicación verbal",
                    "Pensamiento lógico",
                    "Empatía y escucha",
                    "Creatividad",
                    "Liderazgo",
                    "Trabajo en equipo",
                    "Análisis de datos",
                    "Capacidad para resolver conflictos",
                    "Organización y planeación"
                },

                AreasDeInteres = new List<string>
                {
                    "Ciencias naturales (biología, química, física)",
                    "Matemáticas y estadística",
                    "Humanidades y ciencias sociales",
                    "Tecnología e informática",
                    "Arte, diseño y comunicación",
                    "Administración y economía",
                    "Salud y medicina",
                    "Educación y pedagogía",
                    "Derecho y ciencias políticas"
                },

                EstilosDeAprendizaje = new List<string>
                {
                    "Escuchando explicaciones",
                    "Leyendo y escribiendo",
                    "Observando (videos, demostraciones)",
                    "Haciendo (experiencias prácticas)"
                },

                PreferenciasLaborales = new List<string>
                {
                    "Estabilidad económica",
                    "Innovación y cambio constante",
                    "Ayudar a los demás",
                    "Creatividad y expresión",
                    "Contacto con la naturaleza",
                    "Viajes y movilidad",
                    "Liderar equipos o proyectos",
                    "Trabajo independiente"
                }
            };
        }
    }
}
