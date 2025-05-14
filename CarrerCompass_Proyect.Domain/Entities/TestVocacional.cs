using CarrerCompass_Proyect.Domain.Entities;

public class TestVocacional
{
    public int Id { get; private set; }
    public int EstudianteId { get; private set; }

    public string CodigoResultado { get; private set; }
    public DateTime FechaRealizacion { get; private set; }
    public int Puntaje { get; private set; }

    // ✅ Esta propiedad es obligatoria para que EF la relacione
    public Estudiante Estudiante { get; private set; }

    private TestVocacional() { }

    public TestVocacional(int estudianteId, string codigoResultado, DateTime fechaRealizacion, int puntaje)
    {
        EstudianteId = estudianteId;
        CodigoResultado = codigoResultado;
        FechaRealizacion = fechaRealizacion;
        Puntaje = puntaje;
    }
}
