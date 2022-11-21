Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 999 || num < 100)
{
    Console.WriteLine("Число не трехзначное");
}
else
{
    int res = num%100;
    int res2 = res/10;
    Console.Write(res2);
}
