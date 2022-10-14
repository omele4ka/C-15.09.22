﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int result = AckermanFunction(numberM, numberN);
Console.WriteLine(result);

int AckermanFunction (int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numM > 0 && numN == 0) return AckermanFunction(numM - 1, 1);
    return AckermanFunction(numM - 1, AckermanFunction(numM, numN - 1)); 
}