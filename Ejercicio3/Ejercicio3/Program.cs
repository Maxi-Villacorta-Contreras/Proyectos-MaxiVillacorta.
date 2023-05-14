using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se pide ingresar una letra del alfabeto y mostrar si dicha letra es vocal o consonante//
            char letra;
            Console.WriteLine("Ingrese una letra del alfabeto: ");
            letra = char.Parse(Console.ReadLine());
            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            {
                Console.WriteLine("La letra es vocal");
            }
            else
            {
                Console.WriteLine("La letra es consonante");
            }
            Console.ReadKey();
        }
    }
}
