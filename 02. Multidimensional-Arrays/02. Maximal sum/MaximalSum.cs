using System;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            string[] inputNM = (Console.ReadLine()).Split(' ');
            int N = int.Parse(inputNM[0]);
            int M = int.Parse(inputNM[1]);
            int[,] matrix = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                string[] inputArr = input.Split(' ');
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = int.Parse(inputArr[j]);
                }
            }
            int x = 0;
            int maxSum = int.MinValue;
            while (x < N - 2)
            {
                int y = 0;
                while (y < M - 2)
                {
                    int sum = 0;
                    for (int i = x; i < x + 3; i++)
                    {
                        for (int j = y; j < y + 3; j++)
                        {
                            sum += matrix[i,j];
                        }
                    }
                    maxSum = (sum > maxSum ? sum : maxSum);
                    y++;
                }
            x++;
            }
            Console.WriteLine(maxSum);
        }
    }
}
