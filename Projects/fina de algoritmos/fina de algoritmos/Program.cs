using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fina_de_algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] apellidos = new string [3];
            int[] edad = new int[3];
            string[] sexo = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese el apellido de la persona" + " "+ (i + 1) + ":");
                apellidos[i] = Console.ReadLine();
                apellidos[i] = apellidos[i].ToUpper();
                Console.WriteLine("Ingrese la edad de la persona" + " " + (i+1) + ":");
                edad[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el sexo de la persona" +" " + (i + 1) + ":");
                sexo[i] = Console.ReadLine();
                sexo[i] = sexo[i].ToUpper();
                
            }
            Program.Lista(apellidos, edad, sexo);

        }
        static void Lista(string[] apellidos, int[] edad, string[] sexo)
        {
            string aux;
            int auxEdad;
            for (int x = 3 - 1; x >= 0; x--)
            {
                for (int i = 0; i < x; i++)
                {
                    if (apellidos[i].CompareTo(apellidos[i + 1]) > 0)
                    {
                        aux = apellidos[i];
                        apellidos[i] = apellidos[i + 1];
                        apellidos[i + 1] = aux;
                        auxEdad = edad[i];
                        edad[i] = edad[i + 1];
                        edad[i + 1] = auxEdad;
                        aux = sexo[i];
                        sexo[i] = sexo[i + 1];
                        sexo[i + 1] = aux;

                    }
                }
            }
            Console.WriteLine("La lista Ordenada es:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(apellidos[i] + " "+ edad[i] + " " + sexo[i]);
            }
            Console.ReadKey();
        }
    }
}
