Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int maxN = 0;

if(numberA > numberB)
{
    maxN = numberA;
}
else
{
    maxN = numberB;
}

if(numberC > maxN)
{
    Console.WriteLine($"max: {numberC}");
}
else 
{
    Console.WriteLine($"max: {maxN}");
}