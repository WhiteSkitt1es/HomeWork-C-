// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine()!;

if (number.Length == 5)
{
    Checkingnumber(number);
}
else 
{
    Console.WriteLine($"Введи правильное число");
}

void Checkingnumber(string number)
{
    if(number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("Данное число является палеондромом!");
    }
    else
    {
        Console.WriteLine("Данное число не является палеондромом!");
    }

}