using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingPolynomials
{
    class AddingPolynomials
    {
        static int[] ParseArrStrToArrInt(string[] input, int length)
        {
            int[] output = new int[length];
            for (int i = 0; i < length; i++)
            {
                output[i] = int.Parse(input[i]);
            }
            return output;
        }
        static int[] AddArrays(int[] array1, int[] array2, int length)
        {
            int[] output = new int[length];
            for (int i = 0; i < length; i++)
            {
                output[i] = array1[i] + array2[i];
            }
            return output;
        }
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] array1 = ParseArrStrToArrInt(Console.ReadLine().Split(' '), N);
            int[] array2 = ParseArrStrToArrInt(Console.ReadLine().Split(' '), N);
            Console.WriteLine(string.Join(" ", AddArrays(array1, array2, N)));
        }
    }
}
