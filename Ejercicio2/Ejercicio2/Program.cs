using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Construir un programa que permita ingresar un numero, si el numero es mayor a 500, se debe calcular y mostrar en pantalla el 18% de este.
            float num = 0;
            float porciento = 0;
            Console.WriteLine("Ingrese un numero: ");
            num = float.Parse(Console.ReadLine());
            porciento = num % 18;
            if (num > 500)
            {
                Console.WriteLine("El numero es mayor a 500: " + porciento);
            }
            else
            {
                Console.WriteLine("El numero es menor a 500");
            }
            Console.ReadKey();
        }
    }
}
