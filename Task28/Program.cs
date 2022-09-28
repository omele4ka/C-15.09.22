// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int FindMultiply(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result = result * i;
    }
    return result;
}

if (num > 0)
{
    int multiply = FindMultiply(num);
    Console.WriteLine(multiply);
}

else Console.WriteLine("Введено некорректное значение");
