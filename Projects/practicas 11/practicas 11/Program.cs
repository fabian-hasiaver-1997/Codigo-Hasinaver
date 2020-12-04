using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicas_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            bool  auxP;
            Console.WriteLine("Ingrese una palabra que sea palindromo");
            palabra = Console.ReadLine();
            auxP = Program.Palindromo(palabra);
            Console.WriteLine("La palabra" + " "+ palabra + " "+ "es:" + auxP);
            Console.ReadKey();
        }
        static bool Palindromo(string palabra)
        {
            bool devolucion = true;
            int x = 1;
            int i;
            for (i = 0; i < palabra.Length/2; i++)
            {
                if (palabra[i] != palabra[palabra.Length - x])
                {
                    devolucion = false;
                    break;
                }
                x++;
            }
            return devolucion;
        }
    }
}
