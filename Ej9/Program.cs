
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej9
{
    class Program
    {
        const int LIMITE_INFERIOR = 35;
        const int LIMITE_SUPERIOR = 1977;
        static int cSumatoria = 0;
        static bool EsPrimo(int n)
        {
            for (int i=2;i<n;i++) if (n % i == 0) return false;
            return true;
        }
        static void Main(string[] args)
        {
            for (int i=LIMITE_INFERIOR; i<=LIMITE_SUPERIOR; i++)
            {
                if (EsPrimo(i)) cSumatoria += i;
            }
            Console.WriteLine("La sumatoria de los numeros primos comprendidos entre el numero 35 y 1977 es: "+cSumatoria);
            // El programa espera a que se toque cualquier tecla para cerrarse.
            Console.WriteLine("Tocar cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
