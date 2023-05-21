// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] GetRandomNum (int length = 5)
{
    int[] numbers = new int [length];

    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите число элемента массива под номером {i + 1}: ");
        numbers [i] = int.Parse(Console.ReadLine()!);
    }
    return numbers;
}

int CheckEvenNumbers(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}

int [] mass1 = GetRandomNum();

Console.Write("Вывод массива: ");

Console.WriteLine(string.Join(',', mass1));

Console.WriteLine($"Количество чисел больше 0, данном массиве равняется: " + CheckEvenNumbers(mass1));