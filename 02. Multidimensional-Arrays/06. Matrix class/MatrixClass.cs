using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixClass
{
    class MatrixClass
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[2, 5];
            FillMatrix(matrix);
            PrintMatrix(matrix);
        }
        public static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
        }
        public static int AddMatrix(int[,] matrix)
        {
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                }
            }
            return sum;
        }
        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                //for (int col = 0; col < matrix.GetLength(1); col++)
                //{
                //    Console.Write(matrix[row, col]);
                //    if (col < matrix.GetLength(1) - 1)
                //    {
                //        Console.Write(" ");
                //    }
                //}
                Console.WriteLine(matrix[row,].Join(" "));
            }
        }
    }
}
