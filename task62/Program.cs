Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] sMatrix = new int[size, size];

int temp = 1;
int i = 0;
int j = 0;
while (temp <= size * size)
{
    sMatrix[i, j] = temp;
    if (i <= j + 1 && i + j < size - 1)
    {
        j++;
    }
    else if (i < j && i + j >= size - 1)
    {
        i++;
    }
    else if (i >= j && i + j > size - 1)
    {
        j--;
    }
    else
    {
        i--;
    }
    temp++;
}

for (int f = 0; f < size; f++)
{
    for (int d = 0; d < size; d++)
    {
        if(sMatrix[f, d] / 10 <= 0)
        {
            Console.Write($"0{sMatrix[f,d]} ");
        }
        else
        {
            Console.Write(sMatrix[f, d] + " ");
        }
    }
    Console.WriteLine();
}