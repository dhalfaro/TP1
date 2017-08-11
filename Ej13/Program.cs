using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej13
{
    class Funciones
    {
        // Devuelve un string con la cadena invertida a la que se pasa como parámetro.
        static public string InvertirCadena(string cadena)
        {
            string retorno = "";
            foreach (var x in cadena)
            {
                retorno = x + retorno;
            }
            return retorno;
        }
        // Se ordenan alfabéticamente un arreglo de cadenas.
        static public void OrdenarCadenas(string[] cadenas)
        {
            string cadenaAux;
            for (int i = 0; i < cadenas.Length - 1; i++)
            {
                if (cadenas[i].CompareTo(cadenas[i + 1]) > 0)
                {
                    cadenaAux = cadenas[i];
                    cadenas[i] = cadenas[i + 1];
                    cadenas[i + 1] = cadenaAux;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Se invierten las cadenas de argumentos de
            // entrada del programa y se almacenan en el arreglo.
            for (int i=0; i<args.Length; i++)
            {
                args[i] = Funciones.InvertirCadena(args[i]);
            }
            // Se ordenan alfabéticamente las cadenas invertidas.
            Funciones.OrdenarCadenas(args);
            // Se muestran en pantalla las cadenas.
            foreach (var arg in args) Console.WriteLine(arg);
            // El programa espera a que se toque cualquier tecla para cerrarse.
            Console.WriteLine("Tocar una tecla para salir...");
            Console.ReadKey();
        }
    }
}
