using System;
using System.Collections.Generic;

namespace CorrectBrackets
{
    class CorrectBrackets
    {
        static int[] BracketsIndex(string input, char bracket)
        {
            List<int> list = new List<int>();
            int index = 0;
            while (index >= 0)
            {
                index = input.IndexOf(bracket, index);
                if (index != -1)
                {
                    list.Add(index);
                    index++;
                }
            }
            int[] array = list.ToArray();
            return array;
        }
        static bool LengthCheck(int int1, int int2)
        {
            bool areEqual = int1 == int2 ? true : false;
            return areEqual;
        }
        static string BracketsCheck(int[] opBr, int[] clBr, bool areEqual)
        {
            string result = "Correct";
            if (areEqual == false)
            {
                result = "Incorrect";
                return result;
            }
            int opCount = 0;
            int clCount = 0;
            for (int i = 0; i < opBr.Length * 2 - 1; i++)
            {
                if (clCount > opCount)
                {
                    result = "Incorrect";
                    return result;
                }
                if (opBr[opCount] < clBr[clCount] && opCount < opBr.Length - 1)
                {
                    opCount++;
                }
                else if (clBr[clCount] < opBr[opCount] && clCount < clBr.Length - 1)
                {
                    clCount++;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] openingBrackets = BracketsIndex(input, '(');
            int[] closingBrackets = BracketsIndex(input, ')');
            bool areEqual = LengthCheck(openingBrackets.Length, closingBrackets.Length);
            string result = BracketsCheck(openingBrackets, closingBrackets, areEqual);
            Console.WriteLine(result);
        }
    }
}
