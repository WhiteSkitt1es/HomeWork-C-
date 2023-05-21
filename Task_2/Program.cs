//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите два числа: ");
int number1, number2;

number1 = int.Parse(Console.ReadLine()!);
number2 = int.Parse(Console.ReadLine()!);

int max = number1;

if (number1 > number2)
{
    Console.WriteLine($"Число {number1} является наибольшим!");
}
else
{
    Console.WriteLine($"Число {number2} является наибольшим");
}





