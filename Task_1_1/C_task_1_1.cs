// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("enter 2 numbers: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"{a} number greater");
}
else
Console.WriteLine($"{b} number greater");