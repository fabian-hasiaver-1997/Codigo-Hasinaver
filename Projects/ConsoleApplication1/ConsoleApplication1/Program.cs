using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, cont_edad=0, cont_F=0, cont_M=0,i;
            float porcentaje_M=0, porcentaje_F=0;
            char sexo;
        for(i=1;i<=15;i++)
            {
                Console.Write("Ingrese edad y sexo de la persona" + " " + i);
                edad = int.Parse(Console.ReadLine());
                    sexo = char.Parse(Console.ReadLine());
                if(sexo == 'M')
                {
                    cont_M ++;
                }
                if(sexo == 'F')
                {
                    cont_F++;
                        if((edad>=20) && (edad<=30))
                    {
                        cont_edad ++;
                    }
                cont_edad = cont_F;
                }
            }
            porcentaje_M = cont_M * 100 / 15;
            porcentaje_F = cont_F * 100 /  15;

            Console.WriteLine ("El porcentaje de las personas de sexo masculino es:" + porcentaje_M );
            Console.WriteLine ("El porcentaje de las personas de sexo femenino es:" + porcentaje_F );
            Console.WriteLine ("Las personas de sexo femenino entre 20 y 30 años son:" + cont_edad);

           Console.ReadKey();
        }
    
    } 
}
