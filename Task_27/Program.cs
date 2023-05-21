// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine()!);
int number2 = 0;
while (number1 > 0)
{
    number2 += number1 % 10;
}
Console.WriteLine(number2);