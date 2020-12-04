using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buscarnombre
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[2];
            string buscador = "a";
            string devolucion;
            for (int i=0; i < 2; i++)
            {
                    Console.Write("ingrese nombre:");
                    nombres[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("ingrese un nombre a buscar: ");
            buscador = Console.ReadLine();
            devolucion = Program.BusquedaNom(nombres, buscador);
            if (devolucion == buscador)
            {
                Console.WriteLine("El nombre" + " " + devolucion + " " + "esta en la lista");
            }
            else
            {
                Console.WriteLine("El nombre no esta en la lista");
            }
            Console.ReadKey();
        }
        static string BusquedaNom(string[] nombres, string buscador)
        {
            string auxNom = "";
          
             for(int i=0; i< nombres.Length; i++)
             {
                 if (buscador == nombres[i])
                     auxNom = buscador;
             }               
            return auxNom;

        }
      }
    }
