using System;
using System.Collections.Generic;
using System.Linq;

namespace GetLargestNumber
{
    class GetLargestNumber
    {
        static int GetMax(int a, int b)
        {
            int c = a > b ? a : b;
            return c;
        }
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int max = int.Parse(input[0]);
            for (int i = 1; i < input.Length; i++)
            {
                max = GetMax(int.Parse(input[i]), max);
            }
            Console.WriteLine(max);
        }
    }
}
