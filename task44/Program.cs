// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8
PrintFibNums(7);
void PrintFibNums(int N)
{
    int firstNum = 0;
    int secondNum = 1;
    if(N == 1)
    {
        System.Console.WriteLine(firstNum);
        return;
    }

    System.Console.WriteLine(firstNum);
    System.Console.WriteLine(secondNum);
    for(int i = 3; i <= N; i++)
    {
        int curentNum = firstNum + secondNum;
        System.Console.WriteLine(curentNum);
        firstNum = secondNum;
        secondNum = curentNum;
    }
}





int[] GetRandomArray(int length)
{
    int[] result = new int[length];

    for (int i = 0; i < length; i++) 
    {
        result[i] = new Random().Next(1, 20);
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