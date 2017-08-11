using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej12
{
    class Funciones
    {
        static public Int64 Factorial(int n)
        {
            if (n == 0) return 1;
            else return n * Factorial(n-1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Ingresar el numero para calcular el factorial:");
            if(int.TryParse(Console.ReadLine(),out numero))
            {
                Console.WriteLine("El factorial de "+numero+" es: "+Funciones.Factorial(numero));
            }
            // El programa espera a que se toque cualquier tecla para cerrarse.
            Console.WriteLine("Tocar una tecla para salir...");
            Console.ReadKey();
        }
    }
}
