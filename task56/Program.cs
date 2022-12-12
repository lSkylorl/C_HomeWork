Random random = new Random();
int[,] matrix = new int[5, 3];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = random.Next(1, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int minsum = Int32.MaxValue;
int pos = 0;
for(int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[i, j];
    }
    if( sum < minsum)
    {
        minsum = sum;
        pos++;
    }
}

Console.WriteLine($"Строка с наименьшей суммой элементов {pos}");