// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GetRandomNum (int length = 5)
{
    double[] numbers = new double [length];

    for (int i = 0; i < length; i++)
    {
        numbers [i] = new Random().NextDouble() * 100;
    }
    return numbers;
}

double GetMinNumbers(double[] numbers)
{
    double minValve = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers [i] < minValve)
        {
            minValve = numbers [i];
        }
    }
    return minValve;
}

double GetMaxNumbers(double[] numbers)
{
    double maxValve = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers [i] > maxValve)
        {
            maxValve = numbers [i];
        }
    }
    return maxValve;
}

double [] mass1 = GetRandomNum();

Console.Write("Вывод массива: ");

Console.WriteLine(string.Join(';', mass1));
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элемента данного массива равняется: " + (GetMaxNumbers(mass1) - GetMinNumbers(mass1)));