// Задайте двумерный массив, задайте его случайными числами. 
// Найдите сумму элементов на главной диагонали. (0, 0), (1,1), (2, 2).
// 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//
// Сумма элементов главной диагонали 1 + 9 + 2 = 12 

// Создаем функцию двумерного массива.

int [,] matrix = new int [5,5];

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

// Проходимся по каждому элементу массива и при равности номера строки и столбца.

int CheckArray (int [,] matrix)
{
    int count = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                count += matrix[i, j];
            }
            
        }
    }
    return count;

}
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine("Сумма чисел по диагонали массива равен: " + CheckArray(matrix));