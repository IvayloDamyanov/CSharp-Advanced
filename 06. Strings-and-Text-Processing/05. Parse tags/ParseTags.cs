using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ParseTags
{
    class ParseTags
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
        static string UpperCase(string text, string openingTag, string closingTag)
        {
            int[] openersTemp = PatternIndex(text, openingTag);
            int[] openers = PatternIndex(text, openingTag);
            int[] closers = PatternIndex(text, closingTag);
            List<int> openersList = new List<int>();
            for (int j = 0; j < openersTemp.Length; j++)
            {
                openersList.Add(openersTemp[j]);
            }
            if (openersTemp.Length > 0)
            {
                int lastOpIndex = openersList.Count - 1;
                int openersLastValue = openersTemp[lastOpIndex];
                int closersLastValue = closers[closers.Length - 1];
                while (openersLastValue > closersLastValue)
                {
                    openersList.RemoveAt(lastOpIndex);
                    lastOpIndex--;
                    openersLastValue = openersTemp[lastOpIndex];
                }
                openers = openersList.ToArray();
            }
            string output = string.Empty;
            StringBuilder sb = new StringBuilder();
            if (openers.Length > 0 && openers[0] >= 0)
            {
                string temp = text.Substring(0, openers[0]);
                sb.Append(temp);
            }
            else
            {
                sb.Append(text);
            }
            int i = 0;
            int closerIndex = 0;
            while (i < openers.Length)
            {

                closerIndex = CloserIndex(closers, openers[i]);
                if (closerIndex != -1)
                {
                    int closerValue = closers[closerIndex];
                    int startIndex = openers[i] + openingTag.Length;
                    int tempLength = closerValue - (openers[i] + openingTag.Length);
                    string temp = text.Substring(startIndex, tempLength);
                    sb.Append(temp.ToUpper());
                    if (i == openers.Length - 1)
                    {
                        startIndex = closerValue + closingTag.Length;
                        temp = text.Substring(startIndex, text.Length - startIndex);
                        sb.Append(temp);
                        output = sb.ToString();
                        return output;
                    }
                    while (openers[i+1] < closers[closerIndex] && closerIndex != -1 && i < openers.Length)
                    {
                        i++;
                    }
                    startIndex = closerValue + closingTag.Length;
                    tempLength = openers[i + 1] - startIndex;
                    temp = text.Substring(startIndex, tempLength);
                    sb.Append(temp);
                }
                while (openers[i] < closers[closerIndex] && closerIndex != -1 && i < openers.Length)
                {
                    i++;
                    if (i == openers.Length)
                    {
                        output = sb.ToString();
                        return output;
                    }
                }
            }
            output = sb.ToString();
            return output;
        }
        static int CloserIndex(int[] closers, int openerValue)
        {
            int closerIndex = -1;
            for (int i = 0; i < closers.Length; i++)
            {
                if (closers[i] > openerValue)
                {
                    return i;
                }
            }
            return closerIndex;
        }
        static void Main()
        {
            //string text = "a</upcase>blank<upcase></upcase>full<upcase>up</upcase>doubleopen<upcase><upcase>a</upcase>doubleclose<upcase>b</upcase></upcase>a<upcase>a";
            //Console.WriteLine(Regex.Replace(text, "<upcase>(.*?)</upcase>", word => word.Groups[1].Value.ToUpper())); // Само този ред е решение за 100 точки
            string text = Console.ReadLine();
            string openingTag = "<upcase>";
            string closingTag = "</upcase>";
            text = UpperCase(text, openingTag, closingTag);
            Console.WriteLine(text);

        }
    }
}
