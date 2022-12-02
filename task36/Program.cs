Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
int sum = 0;

Console.Write("массив: ");
Arr(num);
void Arr(int[] num)
{
    for(int i = 0; i < size; i++)
        {
            num[i] = new Random().Next(1,100);
            Console.Write($"{num[i]} ");
        }
    Console.WriteLine();
}


for (int i = 0; i < size; i++)
{
    if (i % 2 != 0)
    {
        sum = sum + num[i];
    }
}
Console.WriteLine($"Массив из {size} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");