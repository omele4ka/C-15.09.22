// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел: ");
int quantityNumbers = Convert.ToInt32(Console.ReadLine());

int QuantityPositiveNum (int number, int quantity)
{
    int counter = default;
    for (int i = 0; i < quantity; i++)
    {
        Console.WriteLine("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > number) counter++;
    }
    return counter;
}

int quantityPositiveNumbers = QuantityPositiveNum (0, quantityNumbers);
Console.WriteLine($"Количество чисел больше нуля => {quantityPositiveNumbers}");

