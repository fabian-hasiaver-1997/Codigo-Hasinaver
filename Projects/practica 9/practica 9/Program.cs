using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication57
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int palabraLarga = 0;
            string[] cadena = new string[5];
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Por favor ingrese una palabra");
                cadena[i] = Console.ReadLine();
            }

            palabraLarga = Program.PalabraLarga(cadena);
            Console.WriteLine("La palabra mas larga esta en la posicion:" + palabraLarga);
            Console.ReadKey();

        }
        static int PalabraLarga(string[] cadena)
        {
            int i, posicion = 0, mayor = -500, longitud;

            for (i = 0; i < cadena.Length; i++)
            {

                longitud = cadena[i].Length;

                if (longitud > mayor)
                {
                    mayor = longitud;
                    posicion = i;
                }
            }
            return posicion;
        }
    }
}
