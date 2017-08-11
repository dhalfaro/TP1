using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6
{
    class Program
    {
        static private int cSumatoria;
        private const int LIMITE_INFERIOR = 1;
        private const int LIMITE_SUPERIOR = 100;
        static void Main(string[] args)
        {
            // Se realiza una sumatoria desde LIMITE_INFERIOR a LIMITE_SUPERIOR
            // de los numeros impares.
            for (int i = LIMITE_INFERIOR; i <= LIMITE_SUPERIOR; i++)
            {
                // Si el resto de la división de la división por 2 es 1,
                // el valor de i es un número impar.
                // Entonces se incrementa a la sumatoria.
                if(i % 2 == 1) cSumatoria += i;
            }
            // Se calcula el promedio de los números anteriores y se muestra
            // en pantalla despues de mostrar la sumatoria.
            Console.WriteLine("La sumatoria dio: " + cSumatoria);
            double promedio = cSumatoria / (LIMITE_SUPERIOR - LIMITE_INFERIOR);
            Console.WriteLine("Y el promedio: " + cSumatoria / (LIMITE_SUPERIOR - LIMITE_INFERIOR));
            // El programa espera a que se toque cualquier tecla para cerrarse.
            Console.WriteLine("Tocar cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
