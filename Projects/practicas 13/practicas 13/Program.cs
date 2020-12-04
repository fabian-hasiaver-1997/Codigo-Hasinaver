using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicas_13
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int longitud=0;
            Console.WriteLine("Ingrese la longitud de la lista");
            longitud = int.Parse(Console.ReadLine());
            string[] lista = new string[longitud];
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine("Ingrese los apellidos de la lista:");
                lista[i] = Console.ReadLine();
                lista[i] = lista[i].ToUpper();
            }
            Program.Lista(lista, longitud);
        }
        static void Lista(string[] lista, int longitud)
        {
            string aux = "";
            for (int x = longitud - 1; x >= 0; x--)
            {
                for (int i = 0; i < x; i++)
                {
                    if (lista[i].CompareTo(lista[i + 1]) > 0)
                    {
                        aux = lista[i];
                        lista[i] = lista[i + 1];
                        lista[i + 1] = aux;
                    }
                }
            }
            Console.WriteLine("La lista de apellidos es:");
            foreach (string listOrden in lista)
            {
                Console.WriteLine(listOrden);
            }
            Console.ReadKey();
        }
    }
}
