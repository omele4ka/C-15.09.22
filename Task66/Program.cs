// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM > numberN)
{
    int temp = numberM;
    numberM = numberN;
    numberN = temp;
}

int sum = SumNumbersBetweenMN(numberM, numberN);
Console.WriteLine(sum);

int SumNumbersBetweenMN (int numM, int numN)
{
    if (numM + 1 >= numN) 
    {
        return numM + numN;
    }
    return numM + SumNumbersBetweenMN(numM + 1, numN);
}