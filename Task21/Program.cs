// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки ");
Console.WriteLine("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второй первой точки ");
Console.WriteLine("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int dotX1, int dotY1, int dotZ1, int dotX2, int dotY2, int dotZ2) 
{
    double result = Math.Sqrt(Math.Pow((dotX2 - dotX1), 2) + Math.Pow((dotY2 - dotY1), 2) + Math.Pow((dotZ2 - dotZ1), 2));
    return result;
}

double distance = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));