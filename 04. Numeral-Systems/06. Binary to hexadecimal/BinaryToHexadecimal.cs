using System;
using System.Collections.Generic;
using System.Numerics;

namespace BinaryToHexadecimal
{
    class BinaryToHexadecimal
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
            string input = Console.ReadLine();
            Console.WriteLine(ConvertFromDecimal(ConvertToDecimal(input, 2), 16));
        }
    }
}
