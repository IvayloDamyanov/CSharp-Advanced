using System;
using System.Numerics;

namespace NFactorial
{
    class NFactorial
    {
        static BigInteger Factorial(int num)
        {
            BigInteger sum = 1;
            for (int i = 2; i <= num; i++)
            {
                sum = sum * i;
            }
            return sum;
        }
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(N));
        }
    }
}
