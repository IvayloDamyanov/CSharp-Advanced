using System;
using System.Numerics;

namespace IntegerCalculations
{
    class IntegerCalculations
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
        static int Minimum(int[] input)
        {
            int output = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] < output)
                {
                    output = input[i];
                }
            }
            return output;
        }
        static int Maximum(int[] input)
        {
            int output = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] > output)
                {
                    output = input[i];
                }
            }
            return output;
        }
        static double Average(int[] input)
        {
            double output = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                    output += input[i];
            }
            output /= input.Length;
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
        static BigInteger Product(int[] input)
        {
            BigInteger output = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                output *= input[i];
            }
            return output;
        }
        static void Main()
        {
            int[] array = ParseArrStrToArrInt(Console.ReadLine().Split(' '));
            Console.WriteLine(Minimum(array));
            Console.WriteLine(Maximum(array));
            Console.WriteLine("{0:0.00}", Average(array));
            Console.WriteLine(Sum(array));
            Console.WriteLine(Product(array));
        }
    }
}
