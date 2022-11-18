Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int res = 1;

if(number <= 0)
{
    Console.WriteLine($"Число {number} не входит в диапазон от 1 до N");
}
if (res == 1)
{
    res = res + 1;
}
while(res <= number)
{
    Console.WriteLine(res);
    res = res + 2;
}