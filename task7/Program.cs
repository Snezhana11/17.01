// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных 
// координат точек в этой четверти (x и y).


int number1 = new Random().Next(1,5);
Console.WriteLine(number1);
if (number1 == 1) 
{
    Console.WriteLine("x:= (0; +бесконечность)     y:=(0; +бесконечность)");
}
else if (number1 == 2) 
{
    Console.WriteLine("x:= (0; -бесконечность)     y:=(0; +бесконечность)");
}
else if (number1 == 3) 
{
    Console.WriteLine("x:= (0; -бесконечность)     y:=(0; -бесконечность)");
}
else if (number1 == 4) 
{
    Console.WriteLine("x:= (0; +бесконечность)     y:=(0; -бесконечность)");
}
else if ((number1 <= 0) || (number1 >= 4))
{
    Console.WriteLine("Такой четверти нет");
}
