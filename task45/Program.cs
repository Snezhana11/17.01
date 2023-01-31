// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] arr = GetRandomArray(10);
PrintArray(arr);
int[] arr2 = CopyArray(arr);
PrintArray(arr2);

int[] CopyArray(int[] arr)
{
    int[] NewArr = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++) 
    {
        NewArr[i] = arr[i];
    }
    return NewArr;
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
