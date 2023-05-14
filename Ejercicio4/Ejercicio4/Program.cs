using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diseñe un programa que lea un numero de tres cifras y determine si es o no capicua.//
            int num;
            int a;
            int b;
            Console.WriteLine("Ingrese un numero de tres cifras: ");
            num = int.Parse(Console.ReadLine());
            a = (num / 100);
            b = num % 10;
            if (a == b)
            {
                Console.WriteLine("El numero es un capicua");
            }
            else
            {
                Console.WriteLine("El numero no es capicua");
            }
            Console.ReadKey();
        }
    }
}
