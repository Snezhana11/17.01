// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//m = 3, n = 4
//1 4 8 19
//5 -2 33 -2
//77 3 8 1

Print2DArray(Generate2DArray(3, 4));
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