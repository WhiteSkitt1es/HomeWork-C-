// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка.

int [,] massive = new int[4,4];

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

void SortingSumLineMassive (int [,] massive)
{
    int sum = int.MaxValue;
    int index = 0;

    for (int i = 0; i < massive.GetLength(0); i++)
    {
        int count = 0;
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            count += massive[i,j];
        }

        if (count < sum)
        {
            sum = count;
            index = i;
        }

    }
    Console.WriteLine($"Строка: {index + 1} является наименьшей.");

}

FillMassive(massive);
PrintMassive(massive);
SortingSumLineMassive(massive);