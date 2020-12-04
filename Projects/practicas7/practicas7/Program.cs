using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicas7
{
    class Program
    {
        static void Main(string[] args)
        {
            int mayor, i;
            int [] numero = new int [5];

            for(i=0;i<5;i++)
            {
                Console.WriteLine("Ingrese un numero:");
                numero [i] = int.Parse (Console.ReadLine());
            }
            mayor = Program.Mayor(numero);
            Console.WriteLine("el numero mayor ingresado en el arreglo es:" + mayor);
            Console.ReadKey();
        }
        static int Mayor(int[] numero)
        {
            int mayor= -500,i;
            for (i = 0; i < 5; i++)
            {
                if (numero [i] > mayor)
                {
                    mayor = numero[i];
                }
            }
            return mayor;
        }
    }
}