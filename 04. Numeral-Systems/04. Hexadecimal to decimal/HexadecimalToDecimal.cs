using System;
using System.Numerics;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static BigInteger ConvertToDecimal(string N, int numBase)
        {
            BigInteger result = 0;
            foreach (char digit in N)
            {
                result = result * numBase + (digit < 58 ? digit - '0' : digit < 91 ? digit - ('A' - 10) : digit - ('a' - 10));
            }
            return result;
        }
        static void Main()
        {
            string N = Console.ReadLine();
            Console.WriteLine(ConvertToDecimal(N, 16));
        }
    }
}