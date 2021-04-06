using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int año;
            while (true)
            {
                if(Int32.TryParse(Console.ReadLine(), out año))
                {
                    break;
                }
                Console.Write("Número inválido. Ingréselo nuevamente: ");
            }

            if (DateTime.IsLeapYear(año))
            {
                Console.Write("El número ingresado coincide con un año bisiesto.");
            }
            else
            {
                Console.Write("El número ingresado no coincide con un año bisiesto.");
            }

            Console.ReadKey();
        }
    }
}
