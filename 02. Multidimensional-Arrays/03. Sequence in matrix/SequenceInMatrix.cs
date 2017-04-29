using System;

namespace SequenceInMatrix
{
    class SequenceInMatrix
    {
        static void Main()
        {
            string[] inputArr = (Console.ReadLine()).Split(' ');
            int N = int.Parse(inputArr[0]);
            int M = int.Parse(inputArr[1]);
            int[,] matrix = new int[N, M];
            int countMax = 1;
            for (int i = 0; i < N; i++)
            {
                string[] input2Arr = (Console.ReadLine()).Split(' ');
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = int.Parse(input2Arr[j]);
                }
            }
            int? num = null;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    int count = 1;
                    num = matrix[i, j];
                    int j1 = j;
                    int i1 = i;
                    while (j1 < M - 1)
                    {
                        if (num == matrix[i, j1 + 1])
                        {
                            count++;
                            countMax = (count > countMax ? count : countMax);
                            j1++;
                        }
                        else
                        {
                            count = 1;
                            break;
                        }
                    }
                    j1 = j;
                    i1 = i;
                    while (i1 < N - 1)
                    {
                        if (num == matrix[i1 + 1, j])
                        {
                            count++;
                            countMax = (count > countMax ? count : countMax);
                            i1++;
                        }
                        else
                        {
                            count = 1;
                            break;
                        }
                    }
                    j1 = j;
                    i1 = i;
                    while (i1 < N - 1 && j1 < M - 1)
                    {
                        if (num == matrix[i1 + 1, j1 + 1])
                        {
                            count++;
                            countMax = (count > countMax ? count : countMax);
                            i1++;
                            j1++;
                        }
                        else
                        {
                            count = 1;
                            break;
                        }
                    }
                    j1 = j;
                    i1 = i;
                    while ((i1 >= 0 && i1 < N-1) && (j1 >= 1 && j1 < M))
                    {
                        if (num == matrix[i1 + 1, j1 - 1])
                        {
                            count++;
                            countMax = (count > countMax ? count : countMax);
                            i1++;
                            j1--;
                        }
                        else
                        {
                            count = 1;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(countMax);
        }
    }
}
