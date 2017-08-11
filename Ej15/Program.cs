using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej15
{
    class ArregloAleatorio
    {
        // Devuelve un arreglo iniciado con enteros aleatorios.
        // El primer parámetro debe ser la longitud del arreglo, el segundo y el tercero
        // los valores mínimos y máximos de los números aleatorios respectivamente.
        static public int[] crearArreglo(int len,int rndMin, int rndMax)
        {
            int[] arreglo;
            arreglo = new int[50];
            Random rnd = new Random();
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = rnd.Next(rndMin, rndMax);
            }
            return arreglo;
        }
    }
    class Program
    {
        static int[] cArreglo;
        const int RANGO_INFERIOR = -100;
        const int RANGO_SUPERIOR = 100;
        const int RANGO_INFERIOR_RND = -200;
        const int RANGO_SUPERIOR_RND = 200;
        static void Main(string[] args)
        {
            // Se crea un arreglo iniciado con valores aleatorios.
            cArreglo = ArregloAleatorio.crearArreglo(50,RANGO_INFERIOR_RND,RANGO_SUPERIOR_RND);
            // Se muestran en pantalla los valores que estén integrados en el rango comprendido
            // entre las constantes RANGO_INFERIOR y RANGO_SUPERIOR.
            for (int i=0; i<cArreglo.Length; i++)
            {
                if ((cArreglo[i] >= RANGO_INFERIOR) && (cArreglo[i] <= RANGO_SUPERIOR)) Console.WriteLine(cArreglo[i]);
            }
            // El programa espera a que se toque cualquier tecla para cerrarse.
            Console.WriteLine("Tocar cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
