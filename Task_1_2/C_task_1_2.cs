// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("enter 3 numbers");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max_num = 0;

if (a > b)
{max_num = a;} 
if (max_num < b)
{max_num = b;} 
if (max_num < c)
{max_num = c;} 
Console.WriteLine($"{max_num} number greater");