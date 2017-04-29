using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppearanceCount
{
    class AppearanceCount
    {
        static int Count(int[] array, int x)
        {
            int count = 0;
            foreach (int i in array)
            {
                if (i == x)
                {
                    count++;
                }
            }
            return count;
        }
        static int[] ConvStrToIntArray(string str, int N)
        {
            string[] strArray = str.Split(' ');
            int[] array = new int[N];
            for (int i = 0; i < strArray.Length; i++)
            {
                array[i] = int.Parse(strArray[i]);
            }
            return array;
        }
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] array = ConvStrToIntArray(input, N);
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine(Count(array, X));
        }
    }
}
