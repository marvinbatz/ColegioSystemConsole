using static System.Console;

public static class Printer// Una clase estática es básicamente lo mismo que una clase no estática, pero hay una diferencia: una clase estática no puede ser instanciada. En otras palabras, no puede usar el operador new para crear una variable del tipo de clase. Como no hay una variable de instancia, puede acceder a los miembros de una clase estática utilizando el nombre de la clase en sí.
{
    public static void DrawLine(int size = 10) // Metodo para dibujar lineas
    {
        WriteLine(new string('=', size));
    }
    public static void WriteTittle(string tittle) // Metodo para escribir titulo
    {
        var lineTittle = tittle.Length + 4;
        DrawLine(lineTittle);
        WriteLine($"| {tittle.ToUpper()} |");
        DrawLine(lineTittle);
    }
}