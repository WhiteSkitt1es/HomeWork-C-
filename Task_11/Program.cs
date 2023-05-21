// Задача 11: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает первую и вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int RandomDigit(int minNumber = 100, int maxNumber = 1000)
{
int number = new Random().Next(minNumber, maxNumber);
return number;
}

int FirstDigit (int number)
{
number = number / 100;
return number;
}

int ThirdDigit (int number)
{
number =number % 10;
return number;
}

int number = RandomDigit();
Console.WriteLine (number);
Console.Write(FirstDigit(number));
Console.WriteLine(ThirdDigit(number));