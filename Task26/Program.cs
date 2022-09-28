// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int counter = 0;

int FindNumberLength(int number)
{
    int i = 0;
    while (number > 0)
    {
        number = number / 10;
        counter++;
    }
    return counter;
}

int result = FindNumberLength(Math.Abs(num));
Console.WriteLine(result);