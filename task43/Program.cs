﻿Console.Write("введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());


if(b1 == b2 && k1 == k2)
{
    Console.WriteLine("Прымые находятся на одной линии");
    return;
}
if(k1 == k2)
{
    Console.WriteLine("Прымые параллельны");
}
else
{
    double x = (b2-b1)/(k1-k2);
    double y = k2 * (b2-b1)/(k1-k2) + b2;
    Console.WriteLine($"прямые пересекутся в точке с координатами X= {x}, Y= {y}");
}