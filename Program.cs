using MiColegio;
using static System.Console; // Nos permite escribir solamente WriteLine y ya no Console.WriteLine

var engine = new ColegioEngine();
engine.init(); // Inizializmaos los datos de init del archivo ColegioEngine

Printer.WriteTittle("Bienvenidos al Sistema Mi Colegio");
System.Console.WriteLine(engine.Colegio); // Lo mismo que un Console.WriteLine
printDegreesColegio();

void printDegreesColegio()
{
    Printer.WriteTittle("Grados disponibles");
    if (engine.Colegio?.Degrees != null) // ? No verfica la clase, salvo sea diferente de null
    {
        foreach (var Degree in engine.Colegio.Degrees)
        {
            WriteLine($"{Degree.Name}, {Degree.ShiftType}, {Degree.UniqueId}");
        }
    }
    else
    {
        return;
    }

    // Podemos utilizar la operacion ternario: condition ? consequent : alternative
}