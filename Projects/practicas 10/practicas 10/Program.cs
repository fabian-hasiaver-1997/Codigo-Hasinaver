using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication58
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] matriz = new float[3, 3];
            int fila = 0, columna = 0;
            float devolucion = 0; 
            
            for (fila = 0; fila < 3; fila++)
            {
                for (columna = 0; columna < 3; columna++)
                {
                   Console.WriteLine("Ingrese numeros a la matriz");
                   matriz[fila, columna] = float.Parse(Console.ReadLine());
                }
            }
            Console.Write("Indique la fila: ");
            fila = int.Parse(Console.ReadLine());
            Console.Write("Indique la columna: ");
            columna = int.Parse(Console.ReadLine());
            devolucion = Program.DevolucionMatriz(matriz,fila,columna);
            Console.WriteLine("Las posiciónes son:" + " " + devolucion);
            Console.ReadKey();
        }
        static float DevolucionMatriz(float[,] matriz, int fila, int columna)
        {
              return matriz[fila,columna];
        }
    }

}
    