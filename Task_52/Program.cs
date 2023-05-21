// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Создаем функцию двумерного массива.

int [,] matrix = new int [3, 4];

void PrintArray (int [,] matrix)
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

void FillArray (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

// Переворачиваем перебор массива и суммируем каждое значение в столбике.

void SumColArray (int [,] matrix)
{
    Console.Write("Среднее арифметическое каждого столбца: ");

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double count = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            count += matrix[i, j];
        }
        
        if (j == matrix.GetLength(0))
        {
            Console.Write($"{count / matrix.GetLength(0)}. ");
        }
        else
        {
            Console.Write($"{count / matrix.GetLength(0)}; ");
        }
    }
    
}

FillArray(matrix);
PrintArray(matrix);
SumColArray(matrix);