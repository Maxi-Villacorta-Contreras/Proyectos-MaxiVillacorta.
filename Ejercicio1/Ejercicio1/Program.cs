using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Un hombre desea saber si su sueldo es mayor al sueldo minimo, el programa le pedira al usuario su sueldo actual y el sueldo minimo. Si el sueldo es mayor al minimo se debe mostrar un mensaje por pantalla indicandolo//
            int sueldoactual = 0;
            int sueldominimo = 0;
            Console.WriteLine("Ingrese su sueldo actual: ");
            sueldoactual = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su sueldo minimo: ");
            sueldominimo = int.Parse(Console.ReadLine());
            if (sueldoactual > sueldominimo)
            {
                Console.WriteLine("El sueldo actual es mayor al sueldo minimo");
            }
            else
            {
                Console.WriteLine("El sueldo actual es menor al sueldo minimo");
            }
            Console.ReadKey();
        }
    }
}
