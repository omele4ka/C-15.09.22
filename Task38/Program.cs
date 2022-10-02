// // array1[i] = rnd.NextDouble() * (max - min) + min;

// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round (rnd.NextDouble() * (max - min) + min, 1);
    }
    return array;
}

void PrintArray (double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double GetMinElem (double[] array)
{
    double minResult = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minResult) minResult = array[i];
    }
    return minResult;
}

double GetMaxElem (double[] array)
{
    double maxResult =  array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxResult) maxResult = array[i];
    }

    return maxResult;
}

double GetDifferenceMaxMin (double[] array)
{
    double maxElem = GetMaxElem(array);
    double minElem = GetMinElem(array);
    double result = Math.Round(maxElem - minElem, 1);
    return result;
}


double[] arr = CreateArrayRndInt(5, -10, 10);
PrintArray(arr);

double differenceMaxMinElem = GetDifferenceMaxMin(arr);
Console.WriteLine(differenceMaxMinElem);