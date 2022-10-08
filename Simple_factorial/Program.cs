using System;
using System.Numerics;

namespace Simple_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int x = int.Parse(Console.ReadLine());
                static BigInteger SimpleFactorial(int x)
                {
                    var factorial = new BigInteger(1);
                    for (int i = 1; i <= x; i++)
                    {
                        factorial *= i;
                    }
                    return factorial;
                }

                static BigInteger FactorialByRec(int x)
                {
                    if (x == 1) return 1;
                    return x * FactorialByRec(x - 1);
                }
                BigInteger factorial = FactorialByRec(x);
                Console.WriteLine($"Факториал {x} = {factorial}");
            }
           
        }

        

    }
}
