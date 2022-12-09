Console.Write("Введите элементы массива: ");
int[] shlepa = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < shlepa.Length; i++) 
{
    if (shlepa[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Количество элементов > 0: {count}");