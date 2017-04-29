using System;

namespace LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static int[] ParseArrayStrToInt(string[] input)
        {
            int[] output = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                output[i] = int.Parse(input[i]);
            }
            return output;
        }
        static int LargerCount(int[] array)
        {
            int count = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    count++;
                }
            }
            return count;
        }
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = ParseArrayStrToInt(Console.ReadLine().Split(' '));
            Console.WriteLine(LargerCount(array));
        }
    }
}
