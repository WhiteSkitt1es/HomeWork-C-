// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] numbers = new int [8];

for (int i = 0; i < 8; i++)
{
    numbers [i] = new Random().Next(0, 99);
}
Console.Write("Вывод массива: ");

Console.WriteLine(string.Join(',', numbers));

// Console.Write("Введите количество элементов массива: ");

// int elementsCount = int.Parse(Console.ReadLine()!);

// int [] array = new int [elementsCount];

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($"Введите число элемента массива под номером {i + 1}: ");
//     array [i] = int.Parse(Console.ReadLine()!);
// }

// Console.Write("Вывод массива: ");

// Console.WriteLine(string.Join(',', array));