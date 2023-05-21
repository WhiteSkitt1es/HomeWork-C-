double DistanceXY(double ax, double bx, double ay, double by)
{
    double distanse = Math.Pow(ax - ay, 2) + Math.Pow(bx - by, 2);
    distanse = Math.Sqrt(distanse);
    distanse = Math.Round(distanse, 2);

    return distanse; 
}
Console.WriteLine("Введите 1 число по X");
double ax = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите 2 число по X");
double bx = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите 1 число по Y");
double ay = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите 2 число по Y");
double by = double.Parse(Console.ReadLine()!);

Console.WriteLine("Расстояние между точками = " + DistanceXY(ax,bx,ay,by));
