using System;

namespace TP02Exerc04
{
    public class Exerc04
    {
        public static void Main()
        {
            Console.Write("Digite o valor de N: ");
            int N = int.Parse(Console.ReadLine());

            if (N <= 0)
            {
                Console.WriteLine("N deve ser um número inteiro positivo.");
            }
            else
            {
                Console.WriteLine("Os primeiros {0} números da sequência de Fibonacci são:", N);
                for (int i = 0; i < N; i++)
                {
                    Console.Write("{0} ", Fibonacci(i));
                }
                Console.WriteLine();
            }
        }

        static int Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
