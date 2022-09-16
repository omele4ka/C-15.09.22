// Напишите программу, которая принимает на вход трехщначное число,
// а на выходе показывает последнюю цифру этого числа

Console.WriteLine("Введите трехначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num % 10;
Console.WriteLine($"Последняя цифра {result}");

