﻿Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA > numberB)
{
    Console.WriteLine($"max {numberA}");
    Console.WriteLine($"min {numberB}");
}
else
{
    Console.WriteLine($"max {numberB}");
    Console.WriteLine($"min {numberA}");
}