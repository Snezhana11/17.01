// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5


static int GetCountNum(int num)
{
    Console.WriteLine(num);
    int count = 0;
    while (num > 0)
    {
        count++;
        num /= 10;
    }
    return count;
}

Console.WriteLine(GetCountNum(new Random().Next(1000, 100000)));
