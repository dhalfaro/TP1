using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej11
{
    class Circulo
    {
        private double _Radio;
        public Circulo(double radio)
        {
            definirRadio(radio);
        }
        public double definirRadio(double radio)
        {
            return (_Radio = radio);
        }
        public double obtenerRadio()
        {
            return _Radio;
        }
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * obtenerRadio();
        }
        public double CalcularArea()
        {
            return Math.PI*Math.Pow(obtenerRadio(),2);
        }
    }
    class Program
    {
        static Circulo cCirculo;
        static void Main(string[] args)
        {
            double radio;
            Console.WriteLine("Ingresar radio: ");
            while (double.TryParse(Console.ReadLine(), out radio))
            {
                cCirculo= new Circulo(radio);
                Console.WriteLine("El área del círculo es "+cCirculo.CalcularArea()+" y el perimetro "+cCirculo.CalcularPerimetro()+".");
                Console.WriteLine("Ingresar otro radio:");
            }
            // El programa espera a que se toque cualquier tecla para cerrarse.
            Console.WriteLine("Tocar una tecla para salir...");
            Console.ReadKey();
        }
    }
}
