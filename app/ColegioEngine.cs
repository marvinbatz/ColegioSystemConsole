namespace MiColegio
{
    public class ColegioEngine
    {
        public Colegio Colegio { get; set; }
    
        public ColegioEngine()
        {

        }
        public void init() // El voi no devuelve nada (!return) Basicamente las entradas se ecapsularan para que el constructor sea sobrecargado.
        {
            Colegio = new Colegio("Colegio Ciencia y Cultura", 1980, TypesColegio.Diversificado, ciudad: "Totonicapan");// ypesColegio.Diversificado solo me deja colocar las opciones de TypeColegio

            UploadDegrees();
            
            foreach (var degree in Colegio.Degrees) // Por cada grado añadiremos los alumnos.
            {
                degree.Students.AddRange(UploadStudents());
            }

            UploadStudents();
            UploadCourses();
            UploadEvaluations();
        }

        private void UploadEvaluations()
        {
            throw new NotImplementedException();
        }

        private void UploadCourses()
        {
            foreach (var course in Colegio.Degrees) // Crear cursos para cada grado.
            {
                List<Course> listCourses = new List<Course>()
                {
                    new Course{ Name = "Programación" },
                    new Course{ Name = "Matemáticas" },
                    new Course{ Name = "Ciencias Naturales" },
                    new Course{ Name = "Idioma" }
                };
                course.Courses.AddRange(listCourses); // Seria como Colegio.Degrees.Courses = A cada grado del colegio le agregamos una lista de cursos.
            }
        }

        private IEnumerable<Student> UploadStudents() // Pedimos que nos retorne la lista
        {
            string[] name1 = { "Marvin", "Josue", "Lucrecia", "Juana", "Esther", "Mardoqueo", "Marvincito"};
            string[] name2 = { "Estudardo", "Byron", "Maria", "Alejandra", "Silvana", "Diomedes", "Nicomedes"};
            string[] lastName = { "Batz", "Cos", "Baquiax", "Barreno", "Lopez", "Asturias", "Herrera"};
            
            var listStudents = // Creamos como una consulta en SQL, en versiones pasados de .NET tenemos que usar el Linq (using System.Linq )
                from n1 in name1
                from n2 in name2
                from ln in lastName
                select new Student{ Name = $"{n1} {n2} {ln}" };

            return listStudents;
        }

        private void UploadDegrees() // Creamos metodos para cada carga.
        {
            Colegio.Degrees = new List<Degree>() // Creando una lista generica para los grados.
            {
                new Degree() { Name = "Cuarto Perito", ShiftType = ShiftTypes.FinDeSemana },
                new Degree() { Name = "Quinto Perito", ShiftType = ShiftTypes.FinDeSemana },
                new Degree() { Name = "Sexto Perito", ShiftType = ShiftTypes.FinDeSemana }
            };

            Colegio.Degrees.Add(new Degree { Name = "Cuarto Bachillerato", ShiftType = ShiftTypes.FinDeSemana }); // Agregando nuevos grados.
            Colegio.Degrees.Add(new Degree { Name = "Quinto Bachillerato", ShiftType = ShiftTypes.FinDeSemana });

            var collectionBasico = new List<Degree>() // Creando coleccion nueva coleccion de grados y guardando en una variable para pasarlo en un addRange..
            {
                new Degree() { Name = "Primero Básico", ShiftType = ShiftTypes.Vespertina },
                new Degree() { Name = "Segundo Básico", ShiftType = ShiftTypes.Vespertina },
                new Degree() { Name = "Tercer Básico", ShiftType = ShiftTypes.Vespertina }
            };

            var collectionBasicoWeekend = new List<Degree>() // Creando coleccion nueva coleccion de grados y guardando en una variable para pasarlo en un addRange..
            {
                new Degree() { Name = "Primero Básico", ShiftType = ShiftTypes.FinDeSemana },
                new Degree() { Name = "Segundo Básico", ShiftType = ShiftTypes.FinDeSemana },
                new Degree() { Name = "Tercer Básico", ShiftType = ShiftTypes.FinDeSemana }
            };

            // Degree vacationalDegree = new Degree{ Name = "TestDegree", ShiftType = ShiftTypes.Matutina};

            // collectionBasico.Clear(); // Para eliminar la coleccion completa.
            Colegio.Degrees.AddRange(collectionBasicoWeekend);
            Colegio.Degrees.AddRange(collectionBasico);
            // colegio.Degrees.Add(vacationalDegree);
            // printDegreesColegio();
            // colegio.Degrees.Remove(vacationalDegree); // Eliminamos la variable de tipo Degree.
            // printDegreesColegio();


            // ELIMINANDO ELEMENTO CON PREDICATE

            // Predicate<Degree> sextoPerito = DegreeWeekend; // El predicado me dice que debo de cumplir con pasar como parametro un booleano y a la vez que sea un objeto, por tal razon no usamos solo el RemoveAll de abajo, ya que ese aceptaria cualquier funcion por lo tanto seria mas complicado encontrar el error si lo turviera.

            // colegio.Degrees.RemoveAll(sextoPerito); // Borraremos un grado por nombre, este sera el que se encuenra en su metodo DegreeWeekend.

            // bool DegreeWeekend(Degree graobj) // Los elementos que se encuntran en esta lista seran eliminados del objeto Degree.
            // {
            //     return graobj.Name == "Sexto Perito";
            // }

            // USANDO DELEGATE LAMBDA
            Colegio.Degrees.RemoveAll(delegate (Degree gra)
            {
                return gra.Name == "Sexto Perito";
            });
            Colegio.Degrees.RemoveAll((gra) => gra.Name == "Primero Básico" && gra.ShiftType == ShiftTypes.FinDeSemana); // Usando lambda
                                                                                                                         // FIN DELEGATE LAMBDA

            // FIN ELIMINANDO ELEMENTO CON PREDICATE


            // colegio.Degree = new Degree[]
            // // var arrayDegrees = new Degree[] // Tambien puedo iniciar un arreglo de grados de esta forma
            // {
            //     new Degree() { Name = "101" },
            //     new Degree() { Name = "102" },
            //     new Degree() { Name = "103" },
            //     new Degree() { Name = "104" }
            // };
        }
    }
}