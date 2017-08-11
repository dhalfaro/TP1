using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej10
{
    class Anios{
        // Devuelve verdadero si el año pasado como parámetro es secular.
        // En caso contrario devuelve falso.
        static public bool EsSecular(int anio)
        {
            return (anio%100==0);
        }
        // Devuelve verdadero si el año pasado como parámetro es bisiesto.
        // En caso contrario devuelve falso.
        static public bool EsBisiesto(int anio)
        {
            return (EsSecular(anio) ? anio % 400 == 0 : anio % 4 == 0);
        }
    }
    class Program
    {
        const int LIMITE_INFERIOR = 1900;
        const int LIMITE_SUPERIOR = 2015;
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de los años bisiestos comprendidos entre "+LIMITE_INFERIOR+" y "+LIMITE_SUPERIOR+":");
            for (int i=LIMITE_INFERIOR;i<=LIMITE_SUPERIOR;i++)
            {
                if (Anios.EsBisiesto(i)) Console.WriteLine("* "+i);
            }
            // El programa espera a que se toque cualquier tecla para cerrarse.
            Console.WriteLine("Tocar cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
