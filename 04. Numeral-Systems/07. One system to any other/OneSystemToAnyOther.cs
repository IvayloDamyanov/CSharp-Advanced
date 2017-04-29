using System;
using System.Collections.Generic;
using System.Numerics;

namespace OneSystemToAnyOther
{
    class OneSystemToAnyOther
    {
        static BigInteger ConvertToDecimal(string N, int numBase)
        {
            BigInteger result = 0;
            foreach (char digit in N)
            {
                result = result * numBase + (digit < 58 ? digit - 48 : digit - 55);
            }
            return result;
        }
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
            int s = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine(ConvertFromDecimal(ConvertToDecimal(input, s), d));
        }
    }
}
