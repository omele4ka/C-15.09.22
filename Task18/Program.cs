// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите четверть: ");
int quater = Convert.ToInt32(Console.ReadLine());
string result = Diaposon(quater);

string Diaposon(int quater1)
{
    if (quater1 == 1) return "x > 0, y > 0";
    if (quater1 == 2) return "x < 0, y > 0";
    if (quater1 == 3) return "x < 0, y < 0";
    if (quater1 == 4) return "x > 0, y < 0";
    return "Введены некорректные данные";
}

Console.WriteLine(result);
