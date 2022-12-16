Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

CallSumMN(m, n);
void CallSumMN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}

int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
    {
        return 0;
    }
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}