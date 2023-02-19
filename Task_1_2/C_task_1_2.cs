// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("enter 3 numbers: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int maxNum = 0;

if (a > b)
{
    maxNum = a;
} 
if (maxNum < b)
{
    maxNum = b;
} 
if (maxNum < c)
{
    maxNum = c;
} 
Console.WriteLine($"{maxNum} number greater");