// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void CubeNumTable(int num) 
{
    int counter = 1;
    while (counter <= num)
    {
        Console.WriteLine($"| {counter, 3} | {Math.Pow(counter, 3), 5} |");
        counter++;
    }
}

if (number > 0) CubeNumTable(number);
else Console.WriteLine("Введите положительное число");