//  Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

void ReverseArray (int[] array)
{
    int size = array.Length;
    int index1 = 0;
    int index2 = size - 1;

    while (index1 < index2)
    {
        int obj = array[index1];
        array[index1] = array[index2];
        array[index2] = obj;

        index1++;
        index2--;
    }
}

int[] arr = CreateArrayRndInt(4, 1, 9);
PrintArray(arr);
ReverseArray(arr);
PrintArray(arr);
Array.Reverse(arr);
PrintArray(arr);

void ReverseArray2 (int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size/2; i++)
    {
        int ttemp = array[i];
        array[i] = array[array.Length - 1 -i];
        array[array.Length - 1 -i] = ttemp;
    }
 
}

