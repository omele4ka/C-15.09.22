// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 это {number}");
// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit == secondDigit) Console.WriteLine("Цифры равны");
// else if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа = {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа = {secondDigit}");

// int maxDigit = firstDigit > secondDigit ? firstDgit : secondDigit  ТЕРНАРНЫЙ ОПЕРАТОР (краткая запись If)

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    // if (firstDigit > secondDigit) return firstDigit;
    // return secondDigit;
    if (firstDigit == secondDigit) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

//int result = MaxDigit (number);
int maxDigit = MaxDigit(number);
string result = maxDigit > 0 ? maxDigit.ToString() : "Цифры равны";
 Console.WriteLine($"Наибольшая цифра числа = {result}");

