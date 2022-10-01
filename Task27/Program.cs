// Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumDigits(int number)
{
    int res = default;
    while(number > 0)
    {
        int lastDigit = number % 10;
        number = number / 10;
        res = res + lastDigit;
    }
    return res;
}

int sumDigits = SumDigits(num);

Console.WriteLine(sumDigits);
