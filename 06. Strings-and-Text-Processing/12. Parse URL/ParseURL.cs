using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseURL
{
    class ParseURL
    {
        static string URLParser(string input)
        {
            input = input.Trim(' ');
            StringBuilder sb = new StringBuilder();
            string output = string.Empty;
            string[] temp = input.Split(':');
            sb.Append(string.Format("[protocol] = {0}\n", temp[0]));
            temp[1] = temp[1].Remove(0, 2);
            int indexFirstSlash = temp[1].IndexOf('/');
            sb.Append(string.Format("[server] = {0}\n", temp[1].Substring(0, indexFirstSlash)));
            sb.Append(string.Format("[resource] = {0}", temp[1].Substring(indexFirstSlash, temp[1].Length - indexFirstSlash)));
            output = sb.ToString();
            return output;
        }
        static void Main()
        {
            string input = Console.ReadLine();
            string output = URLParser(input);
            Console.WriteLine(output);
        }
    }
}
