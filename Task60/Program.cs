﻿// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] array3D = Create3DMatrixRndInt(2, 2, 2, 10, 99);
Print3DMatrix(array3D);

bool IsNumberInArray (int[] array, int num)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) 
        {
            result = true;
            break;
        }
    }
    return result;
}

int[,,] Create3DMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];
    int[] arrValueInMatrix = new int[ rows * columns * depth];
    int countArrValue = 0;
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i,j,k] = rnd.Next(min, max + 1);
                while (IsNumberInArray(arrValueInMatrix, matrix[i,j,k]))
                {
                    matrix[i,j,k] = rnd.Next(min, max + 1);
                }
                arrValueInMatrix[countArrValue] = matrix[i,j,k];
                countArrValue++;
            }
        }
    }

    return matrix;
}

void Print3DMatrix(int[,,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j, k], 4}, ");
                else Console.Write($"{matrix[i, j, k], 4}");
            }
        }
    
        Console.WriteLine("]");
    }
}