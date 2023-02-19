// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("enter a number: ");
int a = Convert.ToInt32(Console.ReadLine());

int evenNum = 2;

if (a > 1)
{
    while (evenNum <= a)
    {
        Console.Write(evenNum + " ");
        evenNum = evenNum + 2;
    }
}
else
Console.WriteLine($"{a} <= 1");

