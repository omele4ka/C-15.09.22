// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("Введите позицию элемента: ");
int indexXChosenElem = Convert.ToInt32(Console.ReadLine());
int indexYChosenElem = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }

        Console.WriteLine("]");
    }
}

int ChosenIndexElemValue(int[,] matrix, int indexX, int indexY)
{

    int elemValue = matrix[indexX, indexY];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (indexX < matrix.GetLength(0) && indexY < matrix.GetLength(1)) return elemValue;
        }
    }
    return elemValue;
}


int[,] array2D = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2D);
Console.WriteLine();

if (indexXChosenElem < array2D.GetLength(0) && indexYChosenElem < array2D.GetLength(1))
{
    int chosenIndexElemValue = ChosenIndexElemValue(array2D, indexXChosenElem, indexYChosenElem);
    Console.WriteLine(chosenIndexElemValue);
}
 else Console.WriteLine("Такого элемента нет в массиве");