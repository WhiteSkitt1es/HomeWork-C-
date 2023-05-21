// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetRandomNum (int length = 4, int minNumber = 1, int maxNumber = 99)
{
    int[] numbers = new int [length];

    for (int i = 0; i < length; i++)
    {
        numbers [i] = new Random().Next(minNumber, maxNumber);
    }
    return numbers;
}

int SumEvenNumbers(int[] numbers)
{
    int count = 0;
    for (int i = 1; i < numbers.Length; i += 2)
    {
        count += numbers[i];
    }
    return count;
}

int [] mass1 = GetRandomNum();

Console.Write("Вывод массива: ");

Console.WriteLine(string.Join(',', mass1));

Console.WriteLine($"Сумма нечетных элементов в данном массиве равняется: " + SumEvenNumbers(mass1));