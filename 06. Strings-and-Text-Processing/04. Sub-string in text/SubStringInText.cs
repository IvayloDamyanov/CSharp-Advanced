using System;

namespace SubStringInText
{
    class SubStringInText
    {
        static int Count(string text, string pattern)
        {
            int count = 0;
            int pLen = pattern.Length;
            int index = 0;
            while (index >= 0)
            {
                index = text.IndexOf(pattern, index, StringComparison.InvariantCultureIgnoreCase);
                if (index != -1)
                {
                    count++;
                    index += pLen;
                }
            }
            return count;
        }
        static void Main()
        {
            string pattern = Console.ReadLine();
            string text = Console.ReadLine();
            int count = Count(text, pattern);
            Console.WriteLine(count);
        }
    }
}
