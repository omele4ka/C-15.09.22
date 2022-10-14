// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 5, 7, 8"

Console.WriteLine("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

NaturalNumbersFromMToN(numM, numN);

void NaturalNumbersFromMToN(int firstNum, int secondNum)
{
    if (firstNum < secondNum)
    {
    
        Console.Write($"{firstNum} ");
        NaturalNumbersFromMToN(firstNum + 1, secondNum);
        
    }
    if (firstNum > secondNum) 
    {
        Console.Write($"{firstNum} ");
        NaturalNumbersFromMToN(firstNum - 1, secondNum);
    }

    if (firstNum == secondNum) Console.Write($"{firstNum}" );
}

