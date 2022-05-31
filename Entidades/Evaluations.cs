namespace MiColegio;
public class Evaluations
{
    public string UniqueId { get; private set; } // Solo podra ser asignado dentro de la clase, por eso queda en privado el set
    public string Name { get; set; }
    public Student Student { get; set; } // Las evaluaciones tendran un alumno que lo realice
    public Course Course { get; set; } // Las evaluaciones pertenecen a un curso
    public float Note { get; set; } // Nota del tipo flotante para que tenga opcion a decimales
    public Evaluations() =>  UniqueId = Guid.NewGuid().ToString();
}