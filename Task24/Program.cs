// Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введие число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int number)
{
    int sum = default; //для типа int default = 0
    for (int i = 0; i <= number; i++)
    {
        sum = sum + i;
        
    }
    return sum;
}

Console.WriteLine(SumNumbers(num));

