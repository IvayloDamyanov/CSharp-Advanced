using System;

namespace EnterNumbers
{
    class EnterNumbers
    {
        static void ReadNumber(int start = 1, int end = 100)
        {
            int[] array = new int[12];
            array[0] = start;
            array[11] = end;
            try
            {
                for (int i = 1; i < array.Length - 1; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                    if ((array[i] <= array[i - 1]) || array[i] >= array[array.Length - 1])
                    {
                        throw new FormatException();
                    }
                }
                string output = string.Join(" < ", array);
                Console.WriteLine(output);
            }
            catch(FormatException)
            {
                Console.WriteLine("Exception");
            }  
        }
        static void Main()
        {
            ReadNumber();
        }
    }
}
