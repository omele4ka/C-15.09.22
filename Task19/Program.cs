// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 10000 && number > -9999) Console.WriteLine("Введите корректное число");

void FindDigit(int num) 
{
    int num1 = num / 10000;
    int num2 = num / 1000 % 10;
    int num4 = num % 100 / 10;
    int num5 = num % 10;

    if (num1 == num5 && num2 == num4) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}

FindDigit(number);



