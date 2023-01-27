// адача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] arr = GetRandomArray(10);
PrintArray(arr);
System.Console.WriteLine(FindNum(10, arr));

bool FindNum(int num, int[] array)
{
    for (int i = 0; i < array.Length; i++) 
    {
        if(array[i] == num)
        {
            return true;
        }
    }
    return false;
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