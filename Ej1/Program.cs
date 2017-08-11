using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Program
    {
        static private int cNumero;
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar un numero:");
            // Mientras se ingrese un valor numérico,
            // se sigue mostrando un resultado en pantalla.
            while (int.TryParse(Console.ReadLine(), out cNumero))
            {
                // El valor mostrado en pantalla depende del
                // numero ingresado anteriormente.
                if (cNumero == 1) Console.WriteLine("UNO");
                else if (cNumero == 2) Console.WriteLine("DOS");
                else if (cNumero == 3) Console.WriteLine("TRES");
                else if (cNumero == 4) Console.WriteLine("CUATRO");
                else if (cNumero == 5) Console.WriteLine("CINCO");
                else if (cNumero == 6) Console.WriteLine("SEIS");
                else if (cNumero == 7) Console.WriteLine("SIETE");
                else if (cNumero == 8) Console.WriteLine("OCHO");
                else if (cNumero == 9) Console.WriteLine("NUEVE");
                else Console.WriteLine("OTROS");
                Console.WriteLine("Ingresar otro numero:");
            }
            // Cuando se ingresa un valor no numérico en consola,
            // El programa espera a que se toque cualquier tecla para cerrarse.
            Console.WriteLine("Tocar cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
