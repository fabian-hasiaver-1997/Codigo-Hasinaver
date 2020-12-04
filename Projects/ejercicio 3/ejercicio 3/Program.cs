using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroPersonas=0, i, peso = 0;
            char confimracion;
            string sexo;
            for(i=1; i<=numeroPersonas; i++)
            {
            Console.WriteLine("Ingrese el numero de personas de personas deseadas:");
            numeroPersonas = int.Parse(Console.ReadLine());
            
                if(numeroPersonas == 1)
                {
                    Console.WriteLine("Ingrese sexo y peso de la persona Nº" + i);
                    if (sexo == "MASCULINO")
                    {
                    Console.WriteLine("Es masculino");
                    peso = int.Parse(Console.ReadLine());
                    }
                    
                }
                Console.WriteLine("¿Desea ingresar a otra persona?");
                Console.WriteLine("==============================");
                Console.WriteLine("SI/NO");
                switch (confimracion)
                { 
                    case 'A':
                        confimracion = char.Parse(Console.ReadLine());
                        if (confimracion == 'S')
                        { 
                        break;
                        }
                            
                    case 'B': 
                        confimracion = char.Parse(Console.ReadLine());
                        if (confimracion == 'N')
                        { 
                        
                        }
                        
                }
            }
            
            
        }
    }
}
