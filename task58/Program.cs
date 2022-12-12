void FillArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 9);
        }
    }
}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите размернось матриц: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[size, size];
FillArr(matrix1);
int[,] matrix2 = new int[size, size];
FillArr(matrix2);
int[,] matrixMult = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int f = 0; f < size; f++)
        {
            matrixMult[i, j] = matrixMult[i, j] + (matrix1[i, f] * matrix2[f, j]);
        }
    }
}

Console.WriteLine("Матрица 1");
PrintArr(matrix1);
Console.WriteLine();
Console.WriteLine("Матрица 2");
PrintArr(matrix2);
Console.WriteLine();
Console.WriteLine("Результирующая матрица");
PrintArr(matrixMult);