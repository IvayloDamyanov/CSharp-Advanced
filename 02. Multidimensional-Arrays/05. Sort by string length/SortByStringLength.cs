using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortByStringLength
{
    class SortByStringLength
    {
        public static string[] Sorting(string[] array)
        {
            string temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j].Length < array[i].Length)
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
            return array;
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Sorting(input);
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
