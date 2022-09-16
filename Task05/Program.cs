// Написать программу, которая на вход принимает одно число (N), 
// а на выходе выводит все целые числа в промежутке от -N до N


Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int counter = -num;
while (counter <= num)
{
Console.Write($"{counter} ");
counter++;
}