using CarrerCompass_Proyect.Domain.Entities;

public class CarreraSugerida
{
    public int Id { get; private set; }
    public int EstudianteId { get; private set; } // ok, nombre común

    public int CarreraId { get; private set; }
    public int Puntaje { get; private set; }

    public Carrera Carrera { get; private set; }

    public Estudiante Estudiante { get; private set; } // <-- agrega esto si no está

    private CarreraSugerida() { }

    public CarreraSugerida(int estudianteId, int carreraId, int puntaje)
    {
        EstudianteId = estudianteId;
        CarreraId = carreraId;
        Puntaje = puntaje;
    }
}
