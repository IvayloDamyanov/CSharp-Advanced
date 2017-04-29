using System;

namespace SumIntegers
{
    class SumIntegers
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
        static int Sum(int[] input)
        {
            int output = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                output += input[i];
            }
            return output;
        }
        static void Main()
        {
            int[] array = ParseArrStrToArrInt(Console.ReadLine().Split(' '));
            Console.WriteLine(Sum(array));
        }
    }
}
