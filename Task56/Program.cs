﻿// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array2D = CreateMatrixRndInt(3, 2, 1, 3);
PrintMatrix(array2D);
Console.WriteLine();
int[] sumInRowArray = SumInRow(array2D);
int minSumIndex = MinSumIndex(sumInRowArray);
Console.WriteLine($"Номер строк с наименьшей суммой {minSumIndex}");

int[] SumInRow (int[,] matrix)
{
    int[] sumInRow =new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = default;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        sumInRow[i] = sum;
    }
    return sumInRow;
}

int MinSumIndex (int[] array)
{
    int minIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[minIndex]) minIndex = i;
    }
    return minIndex + 1;
}

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
            else Console.Write($"{matrix[i, j], 4}");
        }
    
        Console.WriteLine("]");
    }
}