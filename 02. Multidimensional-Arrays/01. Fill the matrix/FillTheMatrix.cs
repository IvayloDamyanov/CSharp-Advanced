using System;

namespace FillTheMatrix
{
    class FillTheMatrix
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            char C = char.Parse(Console.ReadLine());
            int[,] matrix = new int[N,N];
            int number = 1;
            if (C == 'a')
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        matrix[j, i] = number;
                        number++;
                    }
                }
            }
            if (C == 'b')
            {
                bool way = true;
                for (int i = 0; i < N; i++)
                {
                    if (way == true)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            matrix[j, i] = number;
                            number++;
                        }
                        way = !way;
                    }
                    else
                    {
                        for (int j = N - 1; j >= 0; j--)
                        {
                            matrix[j, i] = number;
                            number++;
                        }
                        way = !way;
                    }
                }
            }
            if (C == 'c')
            {
                int posX = 0;
                int posY = N - 1;
                for (int i = 0; i < N; i++)
                {
                    posX = 0;
                    posY = N - 1 - i;
                    for (int j = 0; j <= i; j++)
                    {
                        matrix[posY,posX] = number;
                        posX++;
                        posY++;
                        number++;
                    }
                }
                for (int i = N - 1; i > 0; i--)
                {
                    posX = N - i;
                    posY = 0;
                    for (int j = 0; j < i; j++)
                    {
                        matrix[posY, posX] = number;
                        posX++;
                        posY++;
                        number++;
                    }
                }
            }
            if (C == 'd')
            {
                int posX = 0;
                int posY = 0;
                int steps = N - 1;
                while (steps > 0)
                {
                    for (int i = 0; i < steps; i++)
                    {
                        matrix[posX, posY] = number;
                        posX++;
                        number++;
                    }
                    for (int i = 0; i < steps; i++)
                    {
                        matrix[posX, posY] = number;
                        posY++;
                        number++;
                    }
                    for (int i = 0; i < steps; i++)
                    {
                        matrix[posX, posY] = number;
                        posX--;
                        number++;
                    }
                    for (int i = 0; i < steps; i++)
                    {
                        matrix[posX, posY] = number;
                        posY--;
                        number++;
                    }
                    posX++;
                    posY++;
                    steps -= 2;
                }
                if ((N * N) % 2 == 1)
                {
                    matrix[posX, posY] = number;
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0}", matrix[i,j]);
                    if (j != N - 1)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
