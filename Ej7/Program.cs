using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej7
{
    class Program
    {
        private const int CANTIDAD_TERMINOS = 1000;
        private static double cSumatoria=0;
        static void Main(string[] args)
        {
            for (int i = 0; i < CANTIDAD_TERMINOS; i++) cSumatoria += TerminoLeibniz(i);
            Console.WriteLine("La sumatoria de los "+CANTIDAD_TERMINOS+" términos da como resultado: "+cSumatoria*4);
            Console.WriteLine("El error relativo porcentual con respecto a la constante PI es igual a: "+ErrorPorcentual(Math.PI,cSumatoria*4)+"%");
            // Cuando se ingresa un valor no numérico en consola,
            // El programa espera a que se toque cualquier tecla para cerrarse.
            Console.WriteLine("Apretar cualquier tecla para salir...");
            Console.ReadKey();
        }
        static int Potencia(int numero, int n)
        {
            if (n == 0) return 1;
            else return numero * Potencia(numero,n-1);
        }
        static double TerminoLeibniz(int n)
        {
            return Potencia(-1,n)/((double)(2*n+1));
        }
        static double ErrorPorcentual(double n1,double n2)
        {
            return Math.Abs(n1-n2)/n1*100;
        }
    }
}
