using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Lista = new string[5];
            string nombre;
            int nombrePos;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el nombre numero" + " " + (i+1) + " " + ":");
                Lista[i] = Console.ReadLine();

            }
            Console.WriteLine("Ingrese el nombre a buscar:");
            nombre = Console.ReadLine();
            nombre = nombre.ToUpper();
            nombrePos =  Program.Nombre(Lista,nombre);
            Console.WriteLine("La posicion es:" + nombrePos);
            Console.ReadKey();
        }
        static int Nombre(string[] nombres, string nombre)
        {
            int i;
            for (i = 0; i < 5; i++)
            {
                if (nombres[i] == nombre)
                {
                    return i + 1;
                }
               
            }
            return -1;
            
        
        }
    }
}
