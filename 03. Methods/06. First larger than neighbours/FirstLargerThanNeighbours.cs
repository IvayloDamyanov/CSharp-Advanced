using System;

namespace FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
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
        static int FirstLargerIndex(int[] array)
        {
            int index = -1;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    index = i;
                    return index;
                }
            }
            return index;
        }
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = ParseArrayStrToInt(Console.ReadLine().Split(' '));
            Console.WriteLine(FirstLargerIndex(array));
        }
    }
}
