// Задача 51: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Сумма элементов главной диагонали: 1+9+2 = 12


var arr = Generate2DArray(3, 4);
Print2DArray(arr);
var sum = GetSum(arr);
Console.WriteLine();
Console.WriteLine(GetSum);

int GetSum(int[,] arr)
{
    int length = arr.GetLength(0) < arr.GetLength(1) ? arr.GetLength(0) : arr.GetLength(1);
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, i];
    }
    return sum;
}

int[,] Generate2DArray(int m, int n)
{
    int[,] result = new int[m, n];

    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 100);
        }
    }
    return result;
}

void Print2DArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
