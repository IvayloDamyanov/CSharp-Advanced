using System;
using System.Text;

namespace SeriesOfLetters
{
    class SeriesOfLetters
    {
        static string RemoveConsecutiveIdenticalLetters(string text)
        {
            StringBuilder sb = new StringBuilder();
            if (text.Length > 0)
            {
                for (int i = 0; i < text.Length - 1; i++)
                {
                    if (text[i] != text[i + 1])
                    {
                        sb.Append(text[i]);
                    }
                }
                sb.Append(text[text.Length - 1]);
            }
            string output = sb.ToString();
            return output;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = RemoveConsecutiveIdenticalLetters(input);
            Console.WriteLine(output);
        }
    }
}
