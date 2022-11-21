Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = 0;

if (num > -100 & num <100 )
{
    Console.WriteLine("третьей цифры нет");
}
else if (num <=-100 || num >=100)
{
    while(num <=-1000 || num >=1000)
    {
        num = num/10;
    }
    res = num%10;
    
    if (res < 0)
    {
        res = res * -1;
    }
    Console.WriteLine(res);
}

