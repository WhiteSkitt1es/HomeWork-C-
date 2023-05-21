// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] matrixA = new int[2,2];

int [,] matrixB = new int[2,2];

int [,] matrixC = new int[2,2];

void PrintmatrixA (int [,] matrixA)
{
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            matrixA[i,j] = new Random().Next(1, 10);
            Console.Write($"{matrixA[i,j]} ");
        }
        Console.WriteLine();
    }
}

void PrintmatrixB (int [,] matrixB)
{
    for (int i = 0; i < matrixB.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixB[i,j] = new Random().Next(1, 10);
            Console.Write($"{matrixB[i,j]} ");
        }
        Console.WriteLine();
    }
}

void MultiplicationMatrix (int [,] matrixA, int [,] matrixB, int[,] matrixC)
{
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            int sum = 0;

            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                sum += matrixA[i,k] * matrixB[k,j]; 
            }
            matrixC[i,j] = sum;
        }
    }
    
}   

void PrintMassive (int [,] matrixC)
{
    for (int i = 0; i < matrixC.GetLength(0); i++)
    {
        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
            Console.Write($"{matrixC[i,j]} ");
        }
        Console.WriteLine();
    }
}

PrintmatrixA(matrixA);
Console.WriteLine();
PrintmatrixB(matrixB);
Console.WriteLine("Результрирующая матрица будет: ");
MultiplicationMatrix(matrixA,matrixB,matrixC);
PrintMassive(matrixC);