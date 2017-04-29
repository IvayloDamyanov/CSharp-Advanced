using System;
using System.Text;

namespace UnicodeCharacters
{
    class UnicodeCharacters
    {
        static string StringToUnicodeChars(string text)
        {
            StringBuilder sb = new StringBuilder();
            char[] charArray = text.ToCharArray();
            foreach (char c in charArray)
            {
                string unicode = string.Format("\\u{0:X4}", (int)c);
                sb.Append(unicode);
            }
            string output = sb.ToString();
            return output;
        }
        static void Main()
        {
            string text = Console.ReadLine();
            string output = StringToUnicodeChars(text);
            Console.WriteLine(output);
        }
    }
}
