int size = 123;
int[] num = new int[size];
int count = 0;

Console.Write("массив: ");
Arr(num);
void Arr(int[] num)
{
    for(int i = 0; i < size; i++)
    {
        num[i] = new Random().Next(1,1000);
        Console.Write($"{num[i]} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < size; i++)
{
    if (num[i] > 9 && num[i] < 100 )
    {
        count++;
    }
}
Console.WriteLine($"массив из {size} чисел, из которых в отрезке от 10 до 99 лежит {count} чисел ");