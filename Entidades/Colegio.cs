namespace MiColegio
{
    public class Colegio // En C# no importa que la clase coincida con el nombre del archivo.
    {
        public string UniqueId { get; private set; } = Guid.NewGuid().ToString();
        string name;
        public string Name // Con este codigo podemos devolver otro nombre (una copia), y no directamente de la variable oficial, básicamente es un encapsulamiento.
        {
            get { return "Copia: " + name; }
            set { name = value.ToUpper(); } // convertimos el valor en mayuscula
        }

        public int YearCreation { get; set; }

        public string Country { get; set; }
        public string City { get; set; }
        
        public TypesColegio TypeColegio { get; set; } // Llamamos a las opciones descritas en TypesColegio.cs
        public List<Degree> Degrees { get; set; }
        // public Course[] course { get; set; } // Llamando a un arrreglo de Cursos

        // public Colegio(string name, int year) => (Name, YearCreation) = (name, year); // Primer constructor, requiere nombre y anio y esta realizada con igualacion por tuplas.

        public Colegio(string name, int year, TypesColegio type, string pais="", string ciudad="") // Segundo constructor, requiere obligatoriamente nombre, anio y tipo; opcionalmente pais y ciudad.
        {
            (Name, YearCreation) = (name, year);
            TypeColegio = type;
            Country = pais;
            City = ciudad;
        }

        // public Colegio(string nombre, int anio) // Otra forma de constructor
        // {
        //     this.nombre = nombre; // Se coloca el this, ya que el nombre del constructor es igual a la instancia que asignamos en la clase.
        //     AnioCreacion = anio;
        // }

        public override string ToString() // Overrride es sobreescribir la clase colegio
        {
            return $"Nombre: \"{Name}\", Tipo: {TypeColegio} \nPais: {Country}, Ciudad: {City}";
        }

        // public override string ToString() // Otra forma de ToString
        // {
        //     StringBuilder sb = new StringBuilder();
        //     sb.AppendLine("Nombre: "+this.Name+"\n");
        //     sb.AppendLine("Pais: "+this.Country+"\n");
        //     sb.AppendLine("Ciudad: "+this.City+"\n");
        //     sb.AppendLine("Año: "+this.YearCreation+"\n");
        //     sb.AppendLine("Tipo de Escuela: "+this.TypeColegio+"\n");
        //     return sb.ToString();
        // }
    }
}
                       