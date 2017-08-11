
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej16
{
    class Anagramas
    {
        // Se comparan dos cadenas y devuelve verdadero si son anagramas y falso si no lo son.
        static public bool Comparar(string a, string b){
            if (a.Length != b.Length) return false;
            int len = a.Length;
            for (int i=0;i<len;i++) {
                if (a[i] != b[len - i - 1]) return false;
            }
            return true;
        }
    }
    class Program
    {
        static private string cCadenaA;
        static private string cCadenaB;
        static void Main(string[] args)
        {
            // Se ingresa la primer cadena a comparar.
            Console.WriteLine("Insertar primer cadena:");
            cCadenaA = Console.ReadLine();
            // Se ingresa la segunda cadena a comparar.
            Console.WriteLine("Insertar segunda cadena:");
            cCadenaB = Console.ReadLine();
            // Imprime en pantalla el resultado de la comparación (se compara si las cadenas son anagramas).
            Console.WriteLine("Las cadenas"+(Anagramas.Comparar(cCadenaA,cCadenaB)?"":" no")+" son anagramas.");
            // El programa espera a que se toque cualquier tecla para cerrarse.
            Console.WriteLine("Tocar cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
