Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
int lenght = Numlen(number);
SumNumbers(number, lenght);

int Numlen(int a)
{
    int i = 0;
    while (a > 0)
    {
        a /= 10;
        i++;
    }
    return i;
}

void SumNumbers(int number, int lenght)
{
    int sum = 0;
    for (int i = 1; i <= lenght; i++)
    {
        sum = sum + number % 10;
        number /= 10;
    }
    Console.WriteLine($"сумма цифр: {sum}");
}