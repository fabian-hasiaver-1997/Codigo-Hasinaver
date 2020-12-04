using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] precioU = new float[3];
            int[] cantidad = new int[3];
            Console.WriteLine("Ingrese el precio por unidad del producto:");
            for (int i = 0; i < 3; i++)
            {
                precioU [i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingrese la cantidad de productos que desea:");
            for (int i = 0; i < 3; i++)
            {
                cantidad[i] = int.Parse(Console.ReadLine());
            }
            Program.Importe(precioU, cantidad);
            Console.ReadKey();
        }
        static void Importe(float[] precioU, int [] cantidad)
        {
            float[] importes = new float[3];

            for (int i = 0; i < 3; i++)
            {
                importes[i] = precioU[i] * cantidad[i];
                
            }
            foreach (float lista in importes)
            {
                Console.WriteLine("Los importes de cada producto es:"+ " " + lista);
            }
        }
    }
}
