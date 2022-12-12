Console.WriteLine("Введите трехмерный массив X x Y x Z");
Console.Write("Введите X: ");
int coordX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y: ");
int coordY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z: ");
int coordZ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
const int con = 89; 

if (coordX * coordY * coordZ > con)
{
    Console.Write("Массив превышает лимит двухзначных чисел");
    return;
}

int[,,] IDcoords = CreateXYZMass(coordX, coordY, coordZ);

for (int i = 0; i < IDcoords.GetLength(0); i++)
{
    for (int j = 0; j < IDcoords.GetLength(1); j++)
    {
        for (int f = 0; f < IDcoords.GetLength(2); f++)
        {
            Console.WriteLine($"{i},{j},{f} - {IDcoords[i, j, f]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,,] CreateXYZMass(int sizeX, int sizeY, int sizeZ)
{
    int[,,] arr = new int[sizeX, sizeY, sizeZ];
    int[] value = new int[con];
    int minNum = 10;
    for (int i = 0; i < value.Length; i++)
    {
        value[i] = minNum++;
    }
    for (int i = 0; i < value.Length; i++)
    {
        int randomInd = new Random().Next(0, value.Length);
        int temp = value[i];
        value[i] = value[randomInd];
        value[randomInd] = temp;
    }

    int valueInd = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int f = 0; f < arr.GetLength(2); f++)
            {
                arr[i, j, f] = value[valueInd++];
            }
        }
    }
    return arr;
}