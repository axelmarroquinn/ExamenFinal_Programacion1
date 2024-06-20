using static System.Console;
using System;
using System.Linq;

namespace Ejercicio3
{
    internal class Ejercicio3
    {
        public static void Main(string[] args)
        {
            // serie 3: array de n posiciones con valores numéricos, que representan dimensiones en Y de un mapa de elevación en donde el ancho de cada barra es 1 en X.
            // recibir como parámetro el array que representará las diferentes alturas y debe permitir retornar la cantidad de unidades de agua que se pueden
            // almacenar en la estructura, es decir las áreas vacías. solo se podrá almacenar si hay altura en cada lado que permita almacenar agua.
            ForegroundColor = ConsoleColor.Green;
            WriteLine("*** PROGRAMA DE ARREGLOS Y UNIDADES DE AGUA ***");
            ResetColor();

            // solicitar al usuario que ingrese el array de alturas.
            WriteLine("Ingresar el arreglo de alturas separado por comas:");
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine("Ejemplo: 1,0,1,0,1");
            WriteLine("Resultado esperado en el ejemplo: 2");
            ResetColor();
            string Ingreso = ReadLine();
            int[] ArregloAlturas = Ingreso.Split(',').Select(int.Parse).ToArray(); // split como en el ejercicio 2 para separar los números ingresados.

            // calcular y mostrar la cantidad de unidades de agua almacenadas.
            int UnidadesDeAgua = CalcularUnidadesDeAgua(ArregloAlturas);
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine($"El total de unidades de agua que se pueden almacenar es: {UnidadesDeAgua}");
            ResetColor();
        }

        public static int CalcularUnidadesDeAgua(int[] alturas)
        {
            int n = alturas.Length;
            if (n == 0) return 0;

            int[] izquierdaMaximo = new int[n];
            int[] derechaMaximo = new int[n];
            int aguaAlmacenada = 0;

            // calcular el máximo a la izquierda de cada posición
            izquierdaMaximo[0] = alturas[0];
            for (int i = 1; i < n; i++)
            {
            izquierdaMaximo[i] = Math.Max(izquierdaMaximo[i - 1], alturas[i]);
            }

            // calcular el máximo a la derecha de cada posición
            derechaMaximo[n - 1] = alturas[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
            derechaMaximo[i] = Math.Max(derechaMaximo[i + 1], alturas[i]);
            }

            // calcular la cantidad de agua almacenada en cada posición
            for (int i = 0; i < n; i++)
            {
            // encontrar la menor altura entre los máximos a izquierda i derecha
            int alturaMinima = Math.Min(izquierdaMaximo[i], derechaMaximo[i]);

            // si la altura mínima es mayor que la altura actual, sí puede almacenar agua
            if (alturaMinima > alturas[i])
            {
                aguaAlmacenada += alturaMinima - alturas[i];
            }
            }
         return aguaAlmacenada;
        }
    }
}