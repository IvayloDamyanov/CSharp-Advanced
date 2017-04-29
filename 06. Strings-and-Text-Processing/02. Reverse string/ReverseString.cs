using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] array = input.ToArray();
            Array.Reverse(array);
            Console.WriteLine(string.Join("", array));
        }
    }
}
