using static System.Console;

namespace Ejercicio1
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {
            // serie 1: crear un programa de consola para obtener los factores dados por el usuario.
            ForegroundColor = ConsoleColor.Green;
            WriteLine("*** OBTENER LOS FACTORES DADOS POR EL USUARIO ***");
            ResetColor();

            // ingreso del número
            Write("Ingrese un número: ");
            int Numero = int.Parse(ReadLine());


            // obtener e imprimir los factores del número desde 'static void Factores'.
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine($"Los factores de {Numero} son:");
            ResetColor();
            Factores(Numero);
        }

        // encontrar los factores del número.
        static void Factores(int Numero)
        {
            for (int i = 1; i <= Numero; i++)
            {
                if (Numero % i == 0)
                {
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine(i);
                    ResetColor();
                }
            }
        }
    }
}
