using System;
using System.Collections.Generic;
using System.Threading;

namespace EstructurasPilasYColas_G2_2024_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(5));
            Apilamiento();
            Console.ReadLine();
        }
        static void Apilamiento()
        {
            Stack<String> Nombres = new Stack<String>();
            Nombres.Push("Armando");
            Nombres.Push("Jorge");
            Nombres.Push("Luis");
            int total = Nombres.Count;
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("  {0}   ", Nombres.Pop());
            }
        }
        static void cola()
        {
            Queue<String> Fila = new Queue<String>();
            Fila.Enqueue("Juan");
            Fila.Enqueue("Carlos");
            Fila.Enqueue("Maria");
            int total = Fila.Count;
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("Turno de {0} ", Fila.Dequeue() );
                Thread.Sleep(2000);
            }

        }

        static int factorial (int N)
        {
            if (N == 0)
            {
                return 1;
            }
            
            return N * factorial (N - 1);
        }
    }
}
