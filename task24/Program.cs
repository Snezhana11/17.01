// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

int num1 = 7;
Console.WriteLine(GetSum(num1));

static int GetSum(int num)
{
    int res = 0;
    for(int i = 1; i <= num; i++)
    {
        res += i;
    }
    return res;
}