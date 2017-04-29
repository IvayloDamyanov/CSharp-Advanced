using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                double N = double.Parse(Console.ReadLine());
                if (N < 0)
                {
                    throw new Exception();
                }
                double sq = Math.Sqrt(N);
                Console.WriteLine("{0:0.000}", sq);
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
