using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class Program
    {
        static private int cNumero;
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar un numero:");
            // Mientras al valor ingresado en consola sea numérico,
            // la consola mostrará un resultado que dependa de se valor.
            while (int.TryParse(Console.ReadLine(), out cNumero))
            {
                // El valor mostrado en consola depende del número
                // ingresado anteriormente.
                switch (cNumero)
                {
                    case 1:
                        Console.WriteLine("UNO");
                        break;
                    case 2:
                        Console.WriteLine("DOS");
                        break;
                    case 3:
                        Console.WriteLine("TRES");
                        break;
                    case 4:
                        Console.WriteLine("CUATRO");
                        break;
                    case 5:
                        Console.WriteLine("CINCO");
                        break;
                    case 6:
                        Console.WriteLine("SEIS");
                        break;
                    case 7:
                        Console.WriteLine("SIETE");
                        break;
                    case 8:
                        Console.WriteLine("OCHO");
                        break;
                    case 9:
                        Console.WriteLine("NUEVE");
                        break;
                    default:
                        Console.WriteLine("OTROS");
                        break;
                }
                Console.WriteLine("Ingresar otro numero:");
            }
            // Cuando se ingresa un valor no numérico en consola,
            // El programa espera a que se toque cualquier tecla para cerrarse.
            Console.WriteLine("Tocar cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
