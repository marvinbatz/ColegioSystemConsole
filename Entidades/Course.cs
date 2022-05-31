namespace MiColegio;
public class Course
{
    public string UniqueId { get; private set; } // Solo podra ser asignado dentro de la clase, por eso queda en privado el set
    public string Name { get; set; }
    public Course() =>  UniqueId = Guid.NewGuid().ToString();
}