Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] num = new double[size];
double min = Int32.MaxValue;
double max = Int32.MinValue;

Console.Write("массив: ");
Arr(num);
void Arr(double[] num)
{
    for(int i = 0; i < size; i++)
        {
            num[i] = Convert.ToDouble(new Random().Next(1,100)) / 10;
            Console.Write($"{num[i]} ");
        }
    Console.WriteLine();
}

for (int i = 0; i < size; i++)
{
    if (num[i] > max)
        {
            max = num[i];
        }
    if (num[i] < min)
        {
            min = num[i];
        }
}

Console.Write($"массив из {num.Length} чисел. max = {max}, min = {min}. Размах = {max - min}");