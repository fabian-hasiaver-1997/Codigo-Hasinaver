using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicas8
{
    class Program
    {
        static void Main(string[] args)
        {
            float [,] matriz = new float [3,4];
            float auxMatriz=0;
            int fila,columna;
            for (fila = 0; fila < 3; fila++)
            {
                for (columna = 0; columna < 4; columna++)
                {
                    Console.WriteLine("Ingrese un numero");

                    matriz[fila, columna] = float.Parse(Console.ReadLine());
                }
            }
          
                   auxMatriz = Program.PromedioMatriz(matriz);
                    
                    Console.WriteLine("El promedio de los numeros ingresados en la matriz es:" + auxMatriz);
                

           
            Console.ReadKey();
        }
        static float PromedioMatriz(float[,] matriz)
        {
            float suma = 0;
            int fila, columna;
            for (fila = 0; fila < 3; fila++)
            {
                for (columna = 0; columna < 4; columna++)
                {


                    suma += matriz[fila, columna];

                }
            }
            return suma / 12;
        }

    }
}
