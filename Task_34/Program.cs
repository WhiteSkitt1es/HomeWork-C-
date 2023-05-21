// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetRandomNum (int length = 4, int minNumber = 100, int maxNumber = 999)
{
    int[] numbers = new int [length];

    for (int i = 0; i < length; i++)
    {
        numbers [i] = new Random().Next(minNumber, maxNumber);
    }
    return numbers;
}

int CheckEvenNumbers(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}

int [] mass1 = GetRandomNum();

Console.Write("Вывод массива: ");

Console.WriteLine(string.Join(',', mass1));

Console.WriteLine($"Количество четных чисел в данном массиве равняется: " + CheckEvenNumbers(mass1));