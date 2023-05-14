using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //La politica de cobro de la empresa telefonica CELphone es: Cuando se realiza una llamada, el cobro es por el tiempo que esta dura, de tal forma el costo por minuto es uniforme y es de 30 pesos, ademas, se carga un impuesto del 3% cuando es domingo, y si es otro dia, en turno de mañana 15% y en turno de tarde 10%. Realiza un programa para determinar cuanto debe pagar una persona que realiza una llamada, el usuario debe ingresar los minutos que duro la llamada, el dia, y el turno.
            int minllamada;
            string dia;
            string turno;
            double costomin;
            double impudomingo;
            double impuestotal;
            double impuesto;
            Console.WriteLine("Ingrese los minutos que duro en la llamada: ");
            minllamada = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el dia en que hizo la llamada: ");
            dia = Console.ReadLine();
            Console.WriteLine("Ingrese el turno en que hizo la llamada(mañana o tarde): ");
            turno = Console.ReadLine();
            costomin = minllamada * 30;
            impudomingo = (costomin * 3) / 100;
            impuestotal = (costomin * 10) / 100;
            impuesto = (costomin * 15) / 100;
            switch (dia)
            {
                case "lunes":
                    if (turno == "tarde")
                    {
                        costomin = costomin + impuestotal;
                    }
                    else
                    {
                        costomin = costomin + impuesto;
                    }
                    Console.WriteLine("El precio de su llamada es: " + costomin);
                    break;
                case "martes":
                    if (turno == "tarde")
                    {
                        costomin = costomin + impuestotal;
                    }
                    else
                    {
                        costomin = costomin + impuestotal;
                    }
                    Console.WriteLine("El precio de su llamada es: " + costomin);
                    break;
                case "miercoles":
                    if (turno == "tarde")
                    {
                        costomin = costomin + impuestotal;
                    }
                    else
                    {
                        costomin = costomin + impuestotal;
                    }
                    Console.WriteLine("El precio de su llamada es: " + costomin);
                    break;
                case "jueves":
                    if (turno == "tarde")
                    {
                        costomin = costomin + impuestotal;
                    }
                    else
                    {
                        costomin = costomin + impuestotal;
                    }
                    Console.WriteLine("El precio de su llamada es: " + costomin);
                    break;
                case "viernes":
                    if (turno == "tarde")
                    {
                        costomin = costomin + impuestotal;
                    }
                    else
                    {
                        costomin = costomin + impuestotal;
                    }
                    Console.WriteLine("El precio de su llamada es: " + costomin);
                    break;
                case "sabado":
                    if (turno == "tarde")
                    {
                        costomin = costomin + impuestotal;
                    }
                    else
                    {
                        costomin = costomin + impuestotal;
                    }
                    Console.WriteLine("El precio de su llamada es: " + costomin);
                    break;
                case "domingo":
                    costomin = costomin + impuesto;
                    Console.WriteLine("El precio de su llamada es: " + costomin);
                    break;

                default:
                    Console.WriteLine("Ingrese bien");
                    break;
            }
            Console.ReadKey();
        }
    }
}
