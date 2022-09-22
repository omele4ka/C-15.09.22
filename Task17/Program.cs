// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.
Console.WriteLine("Введите координаты точки ");
Console.Write("X: ");
int xC = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yC = Convert.ToInt32(Console.ReadLine());

int quater = Quater(xC, yC);
Console.WriteLine(quater == 0 ? "Введены некорректные координаты" : quater);


int Quater(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

