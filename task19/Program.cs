Console.Write("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.Write($"{number} - Палиндром");
    }
    else
    {
        Console.Write($"{number} - Не палиндром");
    }
}
else
{
    Console.Write($"{number} - не является пятизначным");
}
