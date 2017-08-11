using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej14
{
    class Funciones
    {
        // Devuelve el mínimo de un arreglo con números double.
        static public double Minimo(double[] arreglo)
        {
            double min=arreglo[0];
            foreach (var item in arreglo) if (item < min) min = item;
            return min;
        }
        // Devuelve el máximo de un arreglo con números double.
        static public double Maximo(double[] arreglo)
        {
            double max = arreglo[0];
            foreach (var item in arreglo) if (item > max) max = item;
            return max;
        }
        // Devuelve la sumatoria de un arreglo con números double.
        static public double Sumatoria(double[] arreglo)
        {
            double sumatoria = 0;
            foreach (var item in arreglo) sumatoria += item;
            return sumatoria;
        }
        // Devuelve el promedio de un arreglo con números double.
        static public double Promedio(double[] arreglo)
        {
            return Sumatoria(arreglo)/arreglo.Length;
        }
    }
    class Program
    {
        static Random cRandom;
        static double[] cArreglo;
        const int VALOR_MINIMO = 0;
        const int VALOR_MAXIMO = 30;
        static void Main(string[] args)
        {
            // Se inicia un arreglo de 30 doubles con valores aleatorios.
            cRandom = new Random();
            cArreglo = new double[30];
            Console.WriteLine("Lista de numeros aleatorios:");
            for (int i=0;i<cArreglo.Length;i++)
            {
                cArreglo[i]=cRandom.NextDouble()*cRandom.Next(VALOR_MINIMO,VALOR_MAXIMO);
                Console.WriteLine("-> "+cArreglo[i]);
            }
            // Se calculan y se muestran en pantalla el mínimo,
            // el máximo, la sumatoria y el promedio del arreglo.
            double minimo = Funciones.Minimo(cArreglo);
            double maximo = Funciones.Maximo(cArreglo);
            double sumatoria = Funciones.Sumatoria(cArreglo);
            double promedio = Funciones.Promedio(cArreglo);
            Console.WriteLine("El minimo es: " + minimo);
            Console.WriteLine("El maximo es: " + maximo);
            Console.WriteLine("La suma es: " + sumatoria);
            Console.WriteLine("El promedio es: " + promedio);
            // Se espera a que se toque cualquier tecla para salir.
            Console.WriteLine("Tocar una tecla para salir...");
            Console.ReadKey();
        }
    }
}
