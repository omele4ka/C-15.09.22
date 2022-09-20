// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Weekend(int num)
{
    return num == 6 || num == 7;

}

if (Weekend(number)) Console.WriteLine("Да");
else if (number > 7) Console.WriteLine("Такого дня недели не существует. Введите корректный номер");
else Console.WriteLine("Нет");




