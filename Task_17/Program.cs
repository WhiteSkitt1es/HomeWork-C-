// Напишите программу которая принимает на вход координаты (X, Y), и выдает номер четверти в которой находится точка.

int GetNumberOfQuarterPlane (int x, int y)
{
    if (x == 0 || y == 0)
    {
    return -1;
    }

    if (x > 0 && y > 0)
    {
        return 1;
    }

    else if (x < 0 && y > 0)
    {
        return 2;
    }

    else if (x < 0 && y < 0)
    {
        return 3;
    } 
    else 
    {
        return 4;
    }
}
Console.WriteLine("Введите координаты: ");
int x = int.Parse(Console.ReadLine()!);
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine("Вы попали в четверть номер: " + GetNumberOfQuarterPlane(x,y));