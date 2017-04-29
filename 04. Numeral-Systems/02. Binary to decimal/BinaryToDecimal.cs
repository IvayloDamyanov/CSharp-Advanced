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
                result = result * numBase + (digit < 58 ? digit - 48 : digit < 91 ? digit - 55 : digit - 87);
            }
            return result;
        }
        static void Main()
        {
            string N = Console.ReadLine();
            Console.WriteLine(ConvertToDecimal(N, 2));
        }
    }
}
