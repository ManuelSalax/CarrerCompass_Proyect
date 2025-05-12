using CarrerCompass_Proyect.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerCompass_Proyect.Domain.Interfaces
{
    public interface ITestVocacionalRepositorio
    {
        TestVocacional ObtenerPorId(int id);
        IEnumerable<TestVocacional> ObtenerPorEstudianteId(int estudianteId);
        void Guardar(TestVocacional test);
    }
}

