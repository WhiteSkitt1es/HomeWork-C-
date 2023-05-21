// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int TypeMathPow (int a, int b)
{
    int num = 1;

    for (int i = 0; i < b; i++)
    {
        num = num * a;
    }
    return num;
}

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{a} ^ {b} = {TypeMathPow(a,b)}");