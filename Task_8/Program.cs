// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
    
for (int n = 2; n <= number; n += 2)
    Console.WriteLine(n);