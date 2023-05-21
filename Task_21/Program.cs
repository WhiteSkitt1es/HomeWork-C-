// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double DistanceXYZ(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distanse = Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2);
    distanse = Math.Sqrt(distanse);

    return distanse; 
}
Console.WriteLine("Введите координаты первой точки по X");
double x1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты первой точки по Y");
double y1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты первой точки по Z");
double z1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты второй точки по X");
double x2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты второй точки по Y");
double y2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты второй точки по Z");
double z2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Расстояние между точками = " + DistanceXYZ(x1,y1,z1,x2,y2,z2));