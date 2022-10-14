// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumDigits = SumDigitsInNumber(number);
Console.WriteLine(sumDigits);

int SumDigitsInNumber (int num)
{
    int sum = num % 10;
    if (num > 0) sum += SumDigitsInNumber(num / 10);
    return sum;
}