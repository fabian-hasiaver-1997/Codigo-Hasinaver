using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alexis
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] palabra = new string[5];
            int pos = 0;
            for (int i = 0; i < palabra.Length; i++)
            {
                Console.WriteLine("ingrese la palabra número :" + i );
                palabra[i] = Console.ReadLine();
                Console.WriteLine();
            }

            pos = Program.PalabraLarga(palabra);
            Console.WriteLine("La palabra mas larga esta en la pos:" + pos);
            Console.ReadKey();
        }
        static int PalabraLarga(string[] palabra)
        {
            int pos = 0; int i; int mayor = -100;
            int largo;
            for (i = 0; i < palabra.Length; i++)
            {

                largo = palabra[i].Length;
                if (largo > mayor)
                {
                    mayor = largo;
                    pos = i;
                }
            }

            return (pos);
        }
    }
}
