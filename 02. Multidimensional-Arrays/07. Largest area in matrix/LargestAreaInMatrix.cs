using System;

namespace LargestAreaInMatrix
{
    class LargestAreaInMatrix
    {
        public static void Main()
        {
            string[] inputNM = (Console.ReadLine()).Split(' ');
            int N = int.Parse(inputNM[0]);
            int M = int.Parse(inputNM[1]);
            int[,] matrix = new int[N, M];
            int countMax = 1;
            for (int row = 0; row < N; row++)
            {
                string[] inputArr = (Console.ReadLine()).Split(' ');
                for (int col = 0; col < M; col++)
                {
                    matrix[row, col] = int.Parse(inputArr[col]);
                }
            }
            bool[,] visited = new bool[N,M];
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < M; col++)
                {
                    if (visited[row,col] != true)
                    {
                        int count = DepthSearch(matrix, row, col, visited);
                        {
                            if (count > countMax)
                            {
                                countMax = count;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(countMax);
        }
        static int DepthSearch(int[,] matrix, int row, int col, bool[,] visited)
        {
            int result = 1;
            visited[row,col] = true;
            if ((row - 1 >= 0) && (matrix[row - 1, col] == matrix[row, col]) && (visited[row - 1, col] != true))
            {
                result += DepthSearch(matrix, row - 1, col, visited);
            }
            if ((col - 1 >= 0) && (matrix[row, col - 1] == matrix[row, col]) && (visited[row, col - 1] != true))
            {
                result += DepthSearch(matrix, row, col - 1, visited);
            }
            if ((row + 1 < matrix.GetLength(0)) && (matrix[row + 1, col] == matrix[row, col]) && (visited[row + 1, col] != true))
            {
                result += DepthSearch(matrix, row + 1, col, visited);
            }
            if ((col + 1 < matrix.GetLength(1)) && (matrix[row, col + 1] == matrix[row, col]) && (visited[row, col + 1] != true))
            {
                result += DepthSearch(matrix, row, col + 1, visited);
            }
            return result;
        }
    }
}
