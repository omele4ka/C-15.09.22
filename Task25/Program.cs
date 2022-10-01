// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int newNum = GetDegree(num1, num2);

int GetDegree(int number1, int number2)
{
    int result = 1;
    for (int i = 1; i <= number2; i++)
    {
        result = number1 * result;
    }

    return result;
}
Console.WriteLine(newNum);
