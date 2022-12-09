Random random = new Random();
int[,] matrix = new int[random.Next(3, 10), random.Next(3, 10)];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = random.Next(1, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Поиск элемента...");
Console.Write("Введите позицию столбца элемента: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию строки элемента: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > matrix.GetLength(0) || b > matrix.GetLength(1))
{
   Console.WriteLine("такого числа в массиве нет");
}
else
{
    object c = matrix.GetValue(a,b);
    Console.WriteLine(c);
}