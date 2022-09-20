// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Hundred(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }

    return num;

}

int ThirdDigit(int newNum)
{
    int digit = newNum % 10;
    return digit;
}

if (number < 100) Console.WriteLine("Третьей цифры нет");
else
{
    int newNumber = Hundred(number);
    int result = ThirdDigit(newNumber);
    Console.WriteLine($"{result}");
}

