using System;
using System.Collections.Generic;

namespace NumberAsArray
{
    class NumberAsArray
    {
        static int[] ParseArrStrToArrInt(string[] input)
        {
            int[] output = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                output[i] = int.Parse(input[i]);
            }
            return output;
        }
        static List<int> SumArrays(int[] array1, int[] array2, int Len1, int Len2)
        {
            int longer = Len1 > Len2 ? Len1 : Len2;
            int shorter = Len1 < Len2 ? Len1 : Len2;
            List<int> list = new List<int>();
            int inMind = 0;
            int sum = 0;
            for (int i = 0; i < shorter; i++)
            {
                sum = array1[i] + array2[i] + inMind;
                list.Add(sum % 10);
                inMind = (sum > 9 ? 1 : 0);
            }
            if (Len1 == Len2 && inMind == 1)
            {
                list.Add(1);
            }
            if (Len1 > Len2)
            {
                for (int i = shorter; i < longer; i++)
                {
                    sum = array1[i] + inMind;
                    list.Add(sum % 10);
                    inMind = (sum > 9 ? 1 : 0);
                }
            }
            if (Len1 < Len2)
            {
                for (int i = shorter; i < longer; i++)
                {
                    sum = array2[i] + inMind;
                    list.Add(sum % 10);
                    inMind = (sum > 9 ? 1 : 0);
                }
            }
            return list;
        }
        static void Main()
        {
            int[] lenghts = ParseArrStrToArrInt(Console.ReadLine().Split(' '));
            int Len1 = lenghts[0];
            int Len2 = lenghts[1];
            int[] array1 = ParseArrStrToArrInt(Console.ReadLine().Split(' '));
            int[] array2 = ParseArrStrToArrInt(Console.ReadLine().Split(' '));
            Console.WriteLine(string.Join(" ", SumArrays(array1, array2, Len1, Len2)));
        }
    }
}