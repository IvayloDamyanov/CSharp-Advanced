using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static string ReverseOrder(string input)
        {
            char[] array = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                array[i] = (char)input[i];
            }
            Array.Reverse(array);
            string output = String.Join("", array);
            return output;
        }
        static void Main()
        {
            Console.WriteLine(ReverseOrder(Console.ReadLine()));
        }
    }
}
