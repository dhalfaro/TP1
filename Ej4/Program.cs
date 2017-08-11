using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class Program
    {
        static private int cSumatoria;
        private const int LIMITE_INFERIOR = 78;
        private const int LIMITE_SUPERIOR = 878;
        static void Main(string[] args)
        {
            // Se realiza una sumatoria de los valores integrados entre
            // las constantes LIMITE_INFERIOR y LIMITE_SUPERIOR.
            int i = LIMITE_INFERIOR;
            while (i <= LIMITE_SUPERIOR)
            {
                cSumatoria += i;
                i++;
            }
            // Una vez calculado el valor en cSumatoria,
            // se muestra en pantalla.
            Console.WriteLine("La sumatoria dio: " + cSumatoria);
            // Con los valores de la sumatoria y las constantes,
            // se calcula el promedio y se muestra en pantalla.
            double promedio = cSumatoria / (LIMITE_SUPERIOR - LIMITE_INFERIOR);
            Console.WriteLine("Y el promedio: " + );
            // Cuando se ingresa un valor no numérico en consola,
            // El programa espera a que se toque cualquier tecla para cerrarse.
            Console.WriteLine("Tocar cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
