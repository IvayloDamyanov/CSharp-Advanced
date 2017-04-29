using System;
using System.Collections.Generic;
using System.Text;

namespace ReplaceTags
{
    class ReplaceTags
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
        static string[] StringSplitter(string text, string splitter)
        {
            string[] output;
            string[] splitArray = { splitter };
            output = text.Split(splitArray, StringSplitOptions.None);
            return output;
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
                    string[] temp1 = StringSplitter(temp, "\">");
                    sb.Append(String.Format("[{0}]({1})", temp1[1], temp1[0]));
                    if (i == openers.Length - 1)
                    {
                        startIndex = closerValue + closingTag.Length;
                        temp = text.Substring(startIndex, text.Length - startIndex);
                        sb.Append(temp);
                        output = sb.ToString();
                        return output;
                    }
                    while (openers[i + 1] < closers[closerIndex] && closerIndex != -1 && i < openers.Length)
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
            string text = Console.ReadLine();
            string openingTag = "<a href=\"";
            string closingTag = "</a>";
            text = UpperCase(text, openingTag, closingTag);
            Console.WriteLine(text);
        }
    }
}