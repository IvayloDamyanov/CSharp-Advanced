using System;
using System.Collections.Generic;

namespace BinaryShort
{
    class BinaryShort
    {
        static string ConvertFromDecimal(short number, short numBase)
        {
            List<char> list = new List<char>();
            if (number >= 0)
            {
                while (number > 0)
                {
                    short rem = (short)(number % numBase);
                    list.Add(rem < 10 ? (char)(rem + 48) : (char)(rem + 55));
                    number /= numBase;
                }
            }
            else
            {
                number = (short)~number;
                while (number < 1)
                {
                    short rem = (short)(number % numBase);
                    list.Add(rem < 10 ? (char)(rem + 48) : (char)(rem + 55));
                    number /= numBase;
                }
            }
            list.Reverse();
            string output = string.Join("", list);
            return output;
        }
        static void Main()
        {
            short N = short.Parse(Console.ReadLine());
            Console.WriteLine((Convert.ToString(N, 2)).PadLeft(16, '0'));
        }
    }
}
