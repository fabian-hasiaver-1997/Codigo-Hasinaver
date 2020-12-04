using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int [3,3];
            int devolucion = 0;
            int f,c;
           
            for (f = 0; f < 3; f++)
            {
                for (c = 0; c < 3; c++)
                {  
                     Console.WriteLine("Ingresar un numero a la matriz");
                     mat[f,c] = int.Parse (Console.ReadLine());
                }
            }
            devolucion = Program.Fac(mat);
            Console.WriteLine("El factorial del menor numero de la matriz es:" + devolucion);
            Console.ReadKey();
        }
        static int Fac(int[,] mat)
        {
            int numero = 0, fact = 1, menor = 100000;
            int f, c,i;
            int auxMenor;
            for (f = 0; f < 3; f++)
            {
                for (c = 0; c < 3; c++)
                {
                    numero = mat[f, c];
                    if (numero < menor)
                    {
                        menor = numero;
                    }
                }
            }

            for (i = 1; i <= menor; i++)
            {
                fact = fact * i;
            }
            auxMenor = fact;
            return auxMenor;
        }
    }
}
