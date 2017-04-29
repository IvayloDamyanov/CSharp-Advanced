using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(input[i]);
            }
            int K = int.Parse(Console.ReadLine());
            Array.Sort(array);
            int place = Array.BinarySearch(array, K);
            Console.WriteLine(place < 0 ? array[~place - 1] : array[place]);
        }
    }
}
