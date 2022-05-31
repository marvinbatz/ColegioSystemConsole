namespace MiColegio;
public class Student
{
    public string UniqueId { get; private set; } // Solo podra ser asignado dentro de la clase, por eso queda en privado el set
    public string Name { get; set; }
    public Student() =>  UniqueId = Guid.NewGuid().ToString();
}