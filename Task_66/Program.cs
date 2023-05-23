// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write($"Введите число M: ");

int m = int.Parse(Console.ReadLine()!);

Console.Write($"Введите число N: ");

int n = int.Parse(Console.ReadLine()!);
int Numbers (int m, int n)
{
    if (m == n) return m;
    else return n + Numbers(m, n - 1);
}

Console.WriteLine($"M = {m}; N = {n} -> {Numbers(m,n)}");