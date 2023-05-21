// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

// Заполняем нашу функцию случайными числами.

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

// Проверка заданной позиции двумерного массива.

void CheckArray (int [,] matrix)
{
    Console.WriteLine("Введите номер строки массива: ");
    int inRow = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите номер столбца массива: ");
    int inCol = int.Parse(Console.ReadLine()!);

    Console.WriteLine();

    if (inRow > matrix.GetLength(0)|| inCol > matrix.GetLength(1))
    {
        Console.WriteLine($"{inRow}{inCol} -> Такого числа в массиве нет!");
    }
    else
    {
        Console.WriteLine($" Значение элемента указанной позиции равен = {matrix[inRow, inCol]}");
    }
}

FillArray(matrix);
PrintArray(matrix);
CheckArray(matrix);