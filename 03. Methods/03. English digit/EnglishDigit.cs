using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishDigit
{
    class EnglishDigit
    {
        static string GetLastDigitWord(int i)
        {
            i %= 10;
            string output = string.Empty;
            switch (i)
            {
                case 1: output = "one"; break;
                case 2: output = "two"; break;
                case 3: output = "three"; break;
                case 4: output = "four"; break;
                case 5: output = "five"; break;
                case 6: output = "six"; break;
                case 7: output = "seven"; break;
                case 8: output = "eight"; break;
                case 9: output = "nine"; break;
                case 0: output = "zero"; break;
                default: output = "not a number"; break;
            }
            return output;
        }
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(GetLastDigitWord(input));
        }
    }
}
