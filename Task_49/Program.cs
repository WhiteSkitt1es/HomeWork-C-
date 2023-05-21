// Задайте двумерный массив. Найдите элементы у которых оба индекса являются нечетными,
// и замените эти элементы на их квадраты. 
// 1 4 7 2      1 4 7 2
// 5 9 2 3  =>  5 81 2 9
// 8 4 2 4      8 4 2 4

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

// Заполняем нашу функцию случайными числами.

void FillArray (double [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

// Проходимся по каждому элементу массива и нечетные числа возводим в степень.

void CheckArray (double [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 !=0)
            {
                matrix[i, j] = Math.Pow((matrix[i, j]), 2);
            }
        }
    }
}
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
CheckArray(matrix);
PrintArray(matrix);