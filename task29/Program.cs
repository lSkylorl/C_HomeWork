Console.Write("Введите длинну массива: ");
int lenArr = Convert.ToInt32(Console.ReadLine());

int[] Arr = new int[lenArr];
for (int i = 0; i < Arr.Length; i++)
{
    Arr[i] = new Random().Next(0,9);
    Console.Write($"{Arr[i]} ");
}