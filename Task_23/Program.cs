// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
    
for (int n = 1; n <= number; n += 1)
    Console.WriteLine(Math.Pow(n,3));