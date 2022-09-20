// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int num)
{
    int digit2 = num % 100 / 10;
    return digit2;
}

int secondNumber = SecondDigit(number);

Console.WriteLine($"{secondNumber}");
