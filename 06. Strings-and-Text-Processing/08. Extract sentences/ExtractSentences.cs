using System;
using System.Collections.Generic;
using System.Text;

namespace ExtractSentences
{
    class ExtractSentences
    {
        static int[] PatternIndex(string text, string pattern)
        {
            List<int> list = new List<int>();
            int pLen = pattern.Length;
            int index = 0;
            while (index >= 0)
            {
                index = text.IndexOf(pattern, index);
                if (index != -1)
                {
                    list.Add(index);
                    index += pLen;
                }
            }
            int[] array = list.ToArray();
            return array;
        }
        static string SentenceExtractor(string text, string word, char separator)
        {
            StringBuilder sb = new StringBuilder();
            string[] sentences = text.Split(separator);
            for (int i = 0; i < sentences.Length; i++)
            {
                string temp = sentences[i].Trim(); //Trim е сложено заради грешка в условието/тестовете.
                int[] wordIndexes = PatternIndex(temp, word);
                foreach (int index in wordIndexes)
                {
                    char charBeforeWord = '*';
                    char charAfterWord = '*';
                    if (index > 0)
                    {
                        charBeforeWord = temp[index - 1];
                    }
                    if (index < temp.Length - word.Length)
                    {
                        charAfterWord = temp[index + word.Length];
                    }
                    if (char.IsLetter(charBeforeWord) == false && char.IsLetter(charAfterWord) == false)
                    {
                        sb.Append(temp);
                        if (i < sentences.Length)
                        {
                            sb.Append(separator + " "); //интервала е заради грешка в условието/тестовете.
                        }
                        break;
                    }
                }
            }
            string output = sb.ToString();
            return output;
        }
        static void Main()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            char separator = '.';
            string output = SentenceExtractor(text, word, separator);
            Console.WriteLine(output);
        }
    }
}
