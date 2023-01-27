/*Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6]-> 36 21*/


int[] newArray = FindSumOfPairs(new int[] { 1, 2, 3, 4 });
PrintArray(newArray);


int[] FindSumOfPairs(int[] array)
{
    int newSize = array.Length / 2;

    if(array.Length % 2 == 1)
    {
        newSize++;
    }

    int[] result = new int[newSize];

    for(int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length -1 - i];
    }

    if(array.Length % 2 == 1)
    {
        result[newSize - 1] = array[array.Length / 2];
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