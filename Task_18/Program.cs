//Задача 18. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат
//точек в этой четверти (х и у)

string defQuart (int quarter)
{
    if (quarter > 4)
    {
        return "Такого номера номера четверти не существует";
    }


    if (quarter == 1)
    {
        return "В данный диапазон попадают координаты (+X, +Y)";
    }
    else if (quarter == 2)
    {
        return "В данный диапазон попадают координаты (-X, +Y)";
    }
    else if (quarter == 3)
    {
        return "В данный диапазон попадают координаты (-X, -Y)";
    }
    else
    {
        return " В данный диапазон попадают координаты (+X, +Y)";
    }

}

Console.WriteLine("Введите номер четверти: ");
int quarter = int.Parse(Console.ReadLine()!);
Console.WriteLine(defQuart(quarter));