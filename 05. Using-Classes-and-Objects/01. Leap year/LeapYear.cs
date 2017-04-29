using System;

namespace LeapYear
{
    class LeapYear
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            bool isLeap = DateTime.IsLeapYear(input);
            Console.WriteLine(isLeap == true ? "Leap" : "Common");
        }
    }
}
