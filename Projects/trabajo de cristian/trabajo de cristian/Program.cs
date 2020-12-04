using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace trabajo_de_cristian
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 0, Y = 10, Aux = 0, A = 0;
            for (int I = 0; I <= 100; I++)
            {
                while (Aux < 55)
                {
                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(X, Y);
                    Console.Write("Nave");
                    Console.WriteLine("\n");
                    Thread.Sleep(150);
                    Aux++;
                    X++;
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo tecla = Console.ReadKey(true);
                        if (tecla.Key == ConsoleKey.B)
                        {
                            A = X;
                            for (int B = 11; B <= 23; B++)
                            {
                                Console.Clear();
                                Console.SetCursorPosition(X, Y);
                                Console.Write("Nave");
                                Console.SetCursorPosition(A, B);
                                Console.WriteLine("I");
                                Thread.Sleep(150);
                                Aux++;
                                X++;
                            }
                        }
                    }
                }
                while (Aux > 0)
                {
                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(X, Y);
                    Console.Write("Nave");
                    Console.WriteLine("\n");
                    Thread.Sleep(150);
                    Aux--;
                    X--;
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo tecla = Console.ReadKey(true);
                        if (tecla.Key == ConsoleKey.B)
                        {
                            A = X;
                            for (int B = 11; B <= 23; B++)
                            {
                                Console.Clear();
                                Console.SetCursorPosition(X, Y);
                                Console.Write("Nave");
                                Console.SetCursorPosition(A, B);
                                Console.WriteLine("I");
                                Thread.Sleep(150);
                                Aux--;
                                X--;
                            }
                        }
                    }
                }
                I = 0;
            }
        }
    }
}
