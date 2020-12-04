using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] apellidos = new string[10];
            int[] edad = new int[10];
            float[] estatura = new float[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese la edad" + (i+1) + ":");
                edad[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el apellido" + (i+1) + ":");
                apellidos[i] = Console.ReadLine();
                apellidos[i] = apellidos[i].ToUpper();
                 Console.WriteLine("Ingrese la estatura" + (i+1) + ":");
                estatura[i] = float.Parse(Console.ReadLine());
            }
            Program.Lista(edad, apellidos, estatura);
        }
        static void Lista(int[] edad, string[]apellidos, float[] estatura)
        {
            string aux;
            int auxEdad;
            float auxEstatura;
            for (int x = 10 - 1; x >= 0; x--)
            {
                for (int i = 0; i < x; i++)
                {
                    if (edad[i].CompareTo(edad[i + 1]) > 0)
                    {
                        auxEdad = edad[i];
                        edad[i] = edad[i + 1];
                        edad[i + 1] = auxEdad;
                 
                        aux = apellidos[i];
                        apellidos[i] = apellidos[i + 1];
                        apellidos[i + 1] = aux;
                
                        auxEstatura = estatura[i];
                        estatura[i] = estatura[i + 1];
                        estatura[i + 1] = auxEstatura;
                    }
                } 
            }
             Console.WriteLine("La lista ordenada es:");
             for(int i=0;i<10;i++)
                {
                Console.WriteLine(apellidos[i] + edad[i] + estatura[i]);
                }
                 Console.ReadKey();
     }   

  }
}

