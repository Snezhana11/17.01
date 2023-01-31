// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

int a = new Random().Next (1, 10);
int b = new Random().Next (1, 10);
int c = new Random().Next (1, 10);

bool CheckTriangle(int a, int b, int c)
{
    return (((a + b) > c) && ((a + c) > b) && ((b + c) > a));
}
System.Console.WriteLine(CheckTriangle(a, b, c));

