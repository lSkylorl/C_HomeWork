Random random = new Random();
int[,] matrix = new int[3, 4];
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
Console.WriteLine(" Массив с упорядоченными значениями");
Console.WriteLine("  ↓  ");

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int f = 0; f < matrix.GetLength(1) - 1; f++)
        {
            if (matrix[i, f] < matrix[i, f + 1])
            {
                int temp = 0;
                temp = matrix[i, f + 1];
                matrix[i, f + 1] = matrix[i, f];
                matrix[i, f] = temp;
            }
        }
    }
}

PrintMatrix(matrix);
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}