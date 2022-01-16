using System;

namespace URI_beecrowd__1176_Fibonacci_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            long n, first = 0, second = 1, next = 0, c;
            int i, j;

            j = int.Parse(Console.ReadLine());

            for (i = 1; i <= j; i++, first = 0, second = 1)
            {
                
                n = long.Parse(Console.ReadLine());
                n = n + 1;
                for (c = 0; c < n; c++)
                {
                    if (c <= 1) next = c;
                    else
                    {
                        next = first + second;
                        first = second;
                        second = next;
                    }
                }
                Console.WriteLine("Fib({0}) = {1}", n - 1, next);
            }
        }
    }
 }

