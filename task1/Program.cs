//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

//Например:
//78 -> 8
//12-> 2
//85 -> 8

int num = new Random().Next(10, 100);
Console.WriteLine(num);

int firstNum = num / 10;
int secondNum = num % 10;

if(firstNum < secondNum)
{
  Console.WriteLine(secondNum);
}
else
{
  Console.WriteLine(firstNum);
}
