using System;

namespace SayHello
{
    class SayHello
    {
        static void Main()
        {
            string name = Console.ReadLine();
            Hello(name);
        }
        public static void Hello(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
