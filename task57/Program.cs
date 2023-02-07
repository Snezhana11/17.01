// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.


void GetCountOfEachElement(int[] array)
{
    int el = array[0];
    int count = 1;
    for(int i = 1; i < array.Length; i++)
    {
        if(el != array[i])
        {
            Console.WriteLine($"Element {el} count => {count}");
            count = 1;
            el = array[i];
        }
        else
        {
            count++;

        }
    }
}

int[] GerRowArray(int[,] arr)
{
    int[] result = new int[arr.GetLength(0) * arr.GetLength(1)];
    int index = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            result[index] = arr[i, j];
            index++;
        }
    }
    return result;
}

int[,] Generate2DArray(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 10);
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

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}


static int[,] WriteMatr(int k, int l)
{
    int[,] matr = new int[k, l];
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
    return matr;
}

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

// 2 второй вариант

void GetCountOfEachElementDictionaryVersion(int[,] array)
{
    Dictionary<int, int> dict = new Dictionary<int, int>();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (dict.TryGetValue(array[i, j], out int val))
            {
                dict[array[i, j]] += 1;
            }
            else
            {
                dict.Add(array[i, j], 1);
            }
        }
    }

    foreach(var key in dict)
    {
        Console.WriteLine($"{key.Key} meet => {key.Value}");
    }
}

