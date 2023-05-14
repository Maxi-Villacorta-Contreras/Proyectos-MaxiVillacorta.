using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crea una aplicacion que nos pida un dia de la semana y que nos diga si es un dia laboral o no.//
            string semana;
            Console.WriteLine("Ingrese un dia de la semana: ");
            semana = Console.ReadLine();
            if (semana == "lunes" || semana == "martes" || semana == "miercoles" || semana == "jueves" || semana == "viernes")
            {
                Console.WriteLine("Es un dia laboral");
            }
            else
            {
                Console.WriteLine("No se trabaja, se descansa");
            }
            Console.ReadKey();
        }
    }
}
