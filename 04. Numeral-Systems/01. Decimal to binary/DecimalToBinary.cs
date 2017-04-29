using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static string ConvertFromDecimal(BigInteger number, BigInteger numBase)
        {
            List<char> list = new List<char>();
            while (number > 0)
            {
                BigInteger rem = number % numBase;
                list.Add(rem < 10 ? (char)(rem + 48) : (char)(rem + 55));
                number /= numBase;
            }
            list.Reverse();
            string output = string.Join("", list);
            return output;
        }
        static void Main()
        {
            BigInteger N = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(ConvertFromDecimal(N, 2));
        }
    }
}
