using System;

namespace SortingArray
{
    class SortingArray
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
        static int FindMaxElementInArray(int[] array, int start, int end)
        {
            int index = start;
            int max = array[start];
            for (int i = start; i <= end; i++)
            {
                if (array[i] > array[index])
                {
                    index = i;
                } 
            }
            return index;
        }
        static int[] SortArray(int[] array, bool ascending = true)
        {
            if (ascending == true)
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    int temp = array[i];
                    int max = FindMaxElementInArray(array, 0, i);
                    array[i] = array[max];
                    array[max] = temp;
                }
            }
            if (ascending == false)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int temp = array[i];
                    int max = FindMaxElementInArray(array, i, array.Length - 1);
                    array[i] = array[max];
                    array[max] = temp;
                }
            }
            return array;
        }
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = ParseArrStrToArrInt(Console.ReadLine().Split(' '));
            Console.WriteLine(string.Join(" ", SortArray(array)));
        }
    }
}
