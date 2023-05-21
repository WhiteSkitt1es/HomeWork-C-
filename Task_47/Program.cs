// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Создаем функцию двумерного массива.

double [,] matrix = new double [3,4];

void PrintArray (double [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
}

// Заполняем нашу функцию случайными вещественными числами.

void FillArray (double [,] matrix, double min = -10, double max = 10)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().NextDouble() * (max - min) + min;
        }
    }
}

FillArray(matrix);
PrintArray(matrix);