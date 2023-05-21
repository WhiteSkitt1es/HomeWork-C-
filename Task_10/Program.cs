// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int RandomDigit(int minNumber = 100, int maxNumber = 1000)
{
int number = new Random().Next (minNumber, maxNumber);
return number;
}
int SecondDigit(int number)
{
number = number / 10;
number = number % 10;
return number;
}
int number = RandomDigit();
Console.WriteLine (number);
Console.WriteLine(SecondDigit(number));