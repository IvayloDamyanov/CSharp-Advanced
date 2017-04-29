using System;
using System.Text;

namespace StringLength
{
    class Program
    {
        static string TrimString(string text, int desiredLength, int start = 0)
        {
            text = text.Substring(start, desiredLength);
            return text;
        }
        static string FillString(string text, int desiredLength, char filler)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(text);
            sb.Append(new string(filler, desiredLength - text.Length));
            text = sb.ToString();
            return text;
        }
        static string LengthCorrect(string text, int desiredLength, char filler, int start = 0)
        {
            if (text.Length > desiredLength)
            {
                text = TrimString(text, desiredLength);
            }
            if (text.Length < desiredLength)
            {
                text = FillString(text, desiredLength, filler);
            }
            return text;
        }
        static void Main()
        {
            string text = Console.ReadLine();
            string output = LengthCorrect(text, 20, '*');
            Console.WriteLine(output);
        }
    }
}
