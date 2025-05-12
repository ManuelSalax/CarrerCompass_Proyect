using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerCompass_Proyect.Domain.Entities
{
    public class Carrera
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }
        public string Area { get; private set; }
        public decimal? SalarioPromedio { get; private set; }

        public Carrera(string nombre, string descripcion, string area, decimal? salarioPromedio)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Area = area;
            SalarioPromedio = salarioPromedio;
        }
    }
}

