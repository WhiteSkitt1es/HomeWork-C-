// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int [,] massive = new int[3,4];

void PrintMassive (int [,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FillMassive (int [,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            massive[i,j] = new Random().Next(1, 10);
        }
    }
}

void SortingMassive (int [,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            for (int k = 0; k < massive.GetLength(1) - 1; k++)
            {
                if (massive[i,k] < (massive[i,k + 1]) )
            {
                int max = massive[i,k];
                massive[i,k] = massive[i, k + 1];
                massive[i, k + 1] = max;
            }
            }
        }
    }
}

FillMassive(massive);
PrintMassive(massive);
Console.WriteLine();
SortingMassive(massive);
PrintMassive(massive);