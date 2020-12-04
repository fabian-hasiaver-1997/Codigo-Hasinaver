using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicas_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vec = new int [3];
            int [] vec_2 = new int [3];
            int [] vec_3 = new int [3];
            int i, sum1 = 0, sum2 = 0,sum3=0 ;
            int devolucion = 0;
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese numeros enteros al primer vector");
                vec[i] = int.Parse(Console.ReadLine());
                sum1 += vec[i];
            }
            for(i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese numeros enteros al segundo vector ");
                vec_2[i] = int.Parse(Console.ReadLine());
                sum2 += vec_2[i];
            }
            for(i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese numeros enteros al tercer vector");
                vec_3[i] = int.Parse(Console.ReadLine());
                sum3 += vec_3[i];
            }
            devolucion = Program.Suma(sum1,sum2,sum3);
            Console.WriteLine("La suma de los enteros en el vector mas pequeño es:" + " " + devolucion);
            Console.ReadKey();
        }
        static int Suma(int sum1,int sum2,int sum3)
        {
            int resultado = 0;
            if (sum1 < sum2)
            {
                Console.WriteLine("El vector 1 es el mas chico");
                resultado = sum1;
            }
            else
            {
                if (sum2 < sum3)
                {
                    Console.WriteLine("El vector 2 es el mas chico");
                    resultado = sum2;
                }
                else 
                {
                    Console.WriteLine("El vector 3 es el mas chico");
                    resultado = sum3;
                }
            }
            return resultado;
        }
        
    }
}
