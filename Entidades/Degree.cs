namespace MiColegio
{
    public class Degree
    {
        public string UniqueId { get; private set; } // Solo podra ser asignado dentro de la clase, por eso queda en privado el set
        public string Name { get; set; }

        public ShiftTypes ShiftType { get; set; }
        public List<Course> Courses { get; set; } // Definimos una lista de los cursos que pertenecen a este grado
        public List<Student> Students { get; set; } // Definimos una lista de los alumnos que pertenecen a este grado

        public Degree() =>  UniqueId = Guid.NewGuid().ToString(); // Guid asigna un numero aleatorio y ToString lo convertira a texto
    }
}