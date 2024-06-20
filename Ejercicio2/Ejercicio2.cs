using static System.Console;
namespace Ejercicio2
{
    internal class Ejercicio2
    {
        static void Main(string[] args)
        {
            // serie 2: aplicacion que RECIBE 2 strings de números separados por comas en orden ascendente.
            // objetivo: devolver una cadena separada por comas de la intersección de ambas listas. si no hay, debe
            // imprimir que no hay intersección y mostrar las cadenas de números.
            ForegroundColor = ConsoleColor.Green;
            WriteLine("*** PROGRAMA DE INTERSECCIÓN DE DOS CADENAS ***");
            ResetColor();

            // obtener las dos cadenas de números.
            WriteLine("Escriba la primera cadena de números separados por comas en orden ascendente.");
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine("Ejemplo: 1,3,4,7,13: ");
            ResetColor();
            string Cadena1 = Console.ReadLine();
            WriteLine("Escriba la segunda cadena de números separados por comas en orden ascendente.");
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine("Ejemplo: 1,2,4,13,15: ");
            ResetColor();
            string Cadena2 = Console.ReadLine();

            // imprimir la cadena separada por comas o indicar si no hay desde 'static void Interseccion'.
            Interseccion(Cadena1, Cadena2);
        }

        static void Interseccion(string Cadena1, string Cadena2)
        {
            // convertir las cadenas en listas de enteros.
            var lista1 = Cadena1.Split(',').Select(int.Parse).ToList();
            var lista2 = Cadena2.Split(',').Select(int.Parse).ToList();

            // obtener la intersección de ambas listas.
            var InterseccionEncontrada = lista1.Intersect(lista2).ToList();

            // evaluar si hay intersección entre ambas cadenas.
            if (InterseccionEncontrada.Any())
            {
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine($"La intersección de ambas cadenas es: " + string.Join(",", InterseccionEncontrada)); // imprimir la intersección separada por comas.
                ResetColor();
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("No hay ninguna intersección de números en ambas cadenas.");
                ResetColor();
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine($"Cadena 1: {Cadena1}");
                WriteLine($"Cadena 2: {Cadena2}");
                ResetColor();
            }
        }
    }
}