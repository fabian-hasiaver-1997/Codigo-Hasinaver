using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float valorHora_A = 1000, valorHora_B = 850, valorHora_C = 700, horasTrabajadas = 0 , contador_A = 0, contador_B = 0, contador_C = 0, sueldoMensual_A=0, sueldoMensual_B=0, sueldoMensual_C=0, porcentaje_Calificado = 0, auxiliarSueldo = 0, auxiliarHora = 0, mayor=-500000000;
            char categoria, auxCategoria;
            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.Write("Ingrese las horas trabajadas del operario" + " " + i + ":");
                horasTrabajadas = float.Parse(Console.ReadLine());
                while ((horasTrabajadas < 1) || (horasTrabajadas > 240))
                {
                    Console.WriteLine("Cantidad de horas no validas");
                    Console.Write("Ingrese las horas trabajadas del operario" + " " + ":" + i);
                    horasTrabajadas = float.Parse(Console.ReadLine());
                }

            }
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("Ingresar categoria del operario" + " " + i + ":");
                categoria = char.Parse(Console.ReadLine());

                switch (categoria)
                {
                    case 'A':
                        categoria = 'A';
                        sueldoMensual_A  = horasTrabajadas * valorHora_A;
                        auxiliarSueldo = sueldoMensual_A;
                        auxiliarHora = horasTrabajadas;
                        contador_A++;
                        break;

                    case 'B':
                        categoria = 'B';
                        sueldoMensual_B = horasTrabajadas * valorHora_B;
                        auxiliarSueldo = sueldoMensual_B;
                        auxiliarHora = horasTrabajadas;
                        contador_B++;
                        break;

                    case 'C':
                        categoria = 'C';
                        auxiliarSueldo = sueldoMensual_C;
                        auxiliarHora = horasTrabajadas;
                        sueldoMensual_C = horasTrabajadas * valorHora_C;
                        contador_C++;
                        break;
                }
                
            }
            if (auxiliarSueldo > mayor)
            {
                mayor = auxiliarSueldo;
            }
            porcentaje_Calificado = contador_A *100 / 10;

            Console.WriteLine("El sueldo de un operario calificado es:" + sueldoMensual_A  );
            Console.WriteLine("El sueldo de un operario maquinista es:" + sueldoMensual_B );
            Console.WriteLine("El sueldo de un operario comun es:" + sueldoMensual_C );
            Console.WriteLine("El empleado que mas gana es el" + " "+ " " + "con:" + mayor + "$");
            Console.WriteLine("Los operarios calificados son:" + " " + contador_A);
            Console.WriteLine("Los operarios maquinistas son:" + " " + contador_B);
            Console.WriteLine("los operarios comunes son" + " " + contador_C);
            Console.WriteLine("El porcentaje de operarios calificados son:" + porcentaje_Calificado + "%");
            Console.ReadKey();
        }
    }
}


