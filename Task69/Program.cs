//  Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень: ");
int degree = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int result = GetNumToDegree (number, degree);
Console.WriteLine(result);

// int GetNumToDegree (int num, int deg)
// {
//     if (deg == 0) return 1;
//     int res = num;
//     res *= GetNumToDegree(num, deg - 1);
//     return res;
// }

int GetNumToDegree (int num, int deg)
{
    return deg == 0 ? 1 : num * GetNumToDegree(num, deg - 1);
}