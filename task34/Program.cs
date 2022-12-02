Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
int count = 0;

Console.Write("массив: ");
Arr(num);
void Arr(int[] num)
{
    for(int i = 0; i < size; i++)
    {
        num[i] = new Random().Next(100,1000);
        Console.Write($"{num[i]} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < size; i++)
{
    if (num[i] % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine($"массив из {size} чисел, из которых {count} четные");