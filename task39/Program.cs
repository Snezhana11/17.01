// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

int[] arr = GetRandomArray(10);
PrintArray(arr);
Console.WriteLine(ReverseArray(arr));
PrintArray(ReverseArray(arr));

int[] ReverseArray(int[] arr)
{
    int length = arr.Length;
    int[] result = new int[length];
    for (int i = 0; i < length; i++) 
    {
        result[i] = arr[length - 1 - i];
    }
    return result;
}

int[] GetRandomArray(int length)
{
    int[] result = new int[length];

    for (int i = 0; i < length; i++) 
    {
        result[i] = new Random().Next(-20, 21);
    }
    return result;
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
