void Numbers(int num)
{
    if (num == 0)
    {
        return;
    }
    Console.Write($"{num}, ");
    Numbers(num - 1);
}

Console.Write("Введите число: ");
int nums = int.Parse(Console.ReadLine());
Numbers(nums);