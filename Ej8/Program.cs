using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ej8
{
    class Program
    {
        static Int64 cA = 0;
        static Int64 cB = 1;
        static Int64 cAux;
        static void Main(string[] args)
        {
            Console.WriteLine("Primeros 50 elementos de la serie de Fibonacci:");
            for(int i=0;i<50;i++)
            {
                Console.WriteLine(cA);
                cAux = cA + cB;
                cA = cB;
                cB = cAux;
            }
            // El programa espera a que se toque cualquier tecla para cerrarse.
            Console.WriteLine("Tocar cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}